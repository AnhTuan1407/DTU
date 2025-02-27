﻿create database pvms;

use pvms;

CREATE TABLE T_CUSTOMER (
    CUSTOMER_ID VARCHAR(10) ,
    CUSTOMER_NAME NVARCHAR(50) NOT NULL,
    CUSTOMER_ADDRESS NVARCHAR(50) NOT NULL,
    CITY NVARCHAR(50) NOT NULL,
    STATE NVARCHAR(10) NOT NULL,
    POSTAL_CODE VARCHAR(10) NOT NULL,
    CONSTRAINT pk_CUSTOMER_ID PRIMARY KEY(CUSTOMER_ID)
);

CREATE TABLE T_ORDER (
    ORDER_ID VARCHAR(10) ,
    ORDER_DATE DATE NOT NULL,
    CUSTOMER_ID VARCHAR(10),
    CONSTRAINT pk_ORDER_ID PRIMARY KEY(ORDER_ID),
	CONSTRAINT fk_CUSTOMER_ID FOREIGN KEY(CUSTOMER_ID) REFERENCES T_CUSTOMER(CUSTOMER_ID)
);

CREATE TABLE T_PRODUCT (
    PRODUCT_ID VARCHAR(10) ,
    PRODUCT_DESCRIPTION NVARCHAR(100) NOT NULL,
    PRODUCT_FINISH NVARCHAR(10) NOT NULL,
    STANDARD_PRICE FLOAT ,
    STATE NVARCHAR(10) NOT NULL,
    PRODUCT_UNE_ID VARCHAR(10) NOT NULL,
    CONSTRAINT pk_PRODUCT_ID PRIMARY KEY(PRODUCT_ID),
	CONSTRAINT ch_STANDARD_PRICE CHECK(STANDARD_PRICE>=0)
);

CREATE TABLE T_ORDER_UNE (
    ORDER_ID VARCHAR(10),
    PRODUCT_ID VARCHAR(10),
    ORDERED_QUANTITY INT ,
    CONSTRAINT pk_ORDER_UNE PRIMARY KEY(ORDER_ID,PRODUCT_ID),
	CONSTRAINT fk_ORDER_ID FOREIGN KEY(ORDER_ID) REFERENCES T_ORDER(ORDER_ID),
	CONSTRAINT fk_PRODUCT_ID FOREIGN KEY(PRODUCT_ID) REFERENCES T_PRODUCT(PRODUCT_ID),
	CONSTRAINT ch_ORDERED_QUANTITY CHECK(ORDERED_QUANTITY>=0)
);

--1. Thêm dữ liệu vào bảng bằng INSERT INTO

INSERT INTO T_CUSTOMER VALUES 
(N'C001', N'Nguyễn Văn A', N'Cẩm Lệ', N'Đà Nẵng', N'VIP', N'99999' ),
(N'C002', N'Nguyễn Văn B', N'Thanh Khê', N'Đà Nẵng', N'DIAMON', N'99999' ),
(N'C003', N'Nguyễn Văn C', N'Ngũ Hành Sơn', N'Đà Nẵng', N'GOLD', N'99999' ),
(N'C004', N'Phạm Thị C', N'Hòa Vang', N'Đà Nẵng', N'GOLD', N'99999' ),
(N'C005', N'Nguyễn Thị D', N'Sơn Trà', N'Đà Nẵng', N'SILVER', N'99999' );


INSERT INTO T_PRODUCT VALUES 
(N'P001', N'Gà truyền thống', N'06/10/2024', 35000, N'Còn hàng', N'UNE001' ),
(N'P002', N'Gà sốt cay', N'06/10/2024', 30000, N'Còn hàng', N'UNE002' ),
(N'P003', N'Pepsi', N'06/10/2024', 10000, N'Còn hàng', N'UNE003' ),
(N'P004', N'Kem', N'06/10/2024', 5000, N'Còn hàng', N'UNE004' ),
(N'P005', N'Cơm', N'06/10/2024', 40000, N'Còn hàng', N'UNE005' );

INSERT INTO T_ORDER VALUES 
(N'O001', '2024-06-08', N'C001'),
(N'O002', '2024-06-09', N'C002'),
(N'O003', '2024-06-10', N'C001'),
(N'O004', '2024-06-10', N'C003'),
(N'O005', '2024-06-10', N'C005');


INSERT INTO T_ORDER_UNE VALUES 
(N'O001', N'P001', 2),
(N'O002', N'P001', 1),
(N'O003', N'P005', 2),
(N'O004', N'P002', 4),
(N'O005', N'P004', 5);

--2. Các câu lệnh truy vấn 

--Hiển thị tất cả thông tin các bảng 
SELECT * FROM T_CUSTOMER;
SELECT * FROM T_PRODUCT;

--Hiển thị các sản phẩm còn hàng
SELECT * FROM T_PRODUCT 
WHERE STATE = N'Còn hàng';

--Hiển thị đơn hàng của khách hàng có mã C001
SELECT * FROM T_ORDER WHERE CUSTOMER_ID = N'C001';

--Hiển thị tổng số lượng sản phẩm đã được đặt hàng trong bảng T_ORDER_UNE
SELECT PRODUCT_ID, SUM(ORDERED_QUANTITY) as TOTALQUANTITY
FROM T_ORDER_UNE
GROUP BY PRODUCT_ID;

--Hiển thị các khách hàng thuộc loại VIP
SELECT * FROM T_CUSTOMER WHERE STATE = N'VIP';

--Hiển thị các đơn hàng được đặt vào ngày '2024-06-10'
SELECT * FROM T_ORDER WHERE ORDER_DATE = '2024-06-10';

--Hiển thị tổng giá trị các đơn hàng của từng khách hàng
SELECT C.CUSTOMER_ID, C.CUSTOMER_NAME, SUM(P.STANDARD_PRICE * OU.ORDERED_QUANTITY) as TOTAL_ORDER_VALUE
FROM T_CUSTOMER C
JOIN T_ORDER O ON C.CUSTOMER_ID = O.CUSTOMER_ID
JOIN T_ORDER_UNE OU ON O.ORDER_ID = OU.ORDER_ID
JOIN T_PRODUCT P ON OU.PRODUCT_ID = P.PRODUCT_ID
GROUP BY C.CUSTOMER_ID, C.CUSTOMER_NAME;

--Hiển thị danh sách các khách hàng và các đơn hàng của họ
SELECT C.CUSTOMER_ID, C.CUSTOMER_NAME, O.ORDER_ID, O.ORDER_DATE
FROM T_CUSTOMER C
JOIN T_ORDER O ON C.CUSTOMER_ID = O.CUSTOMER_ID;

--Hiển thị các sản phẩm đã được đặt nhiều nhất
SELECT P.PRODUCT_ID, P.PRODUCT_DESCRIPTION, SUM(OU.ORDERED_QUANTITY) as TOTAL_ORDER
FROM T_PRODUCT P
JOIN T_ORDER_UNE OU ON P.PRODUCT_ID = OU.PRODUCT_ID
GROUP BY P.PRODUCT_ID, P.PRODUCT_DESCRIPTION
ORDER BY TOTAL_ORDER DESC;

--Hiển thị chi tiết đơn hàng của khách hàng
SELECT O.CUSTOMER_ID, C.CUSTOMER_NAME, P.PRODUCT_DESCRIPTION, OU.ORDERED_QUANTITY, (P.STANDARD_PRICE * OU.ORDERED_QUANTITY) AS TOTAL_PRICE
FROM T_ORDER O JOIN T_CUSTOMER C
ON O.CUSTOMER_ID = C.CUSTOMER_ID
JOIN T_ORDER_UNE OU 
ON O.ORDER_ID = OU.ORDER_ID
JOIN T_PRODUCT P 
ON P.PRODUCT_ID = OU.PRODUCT_ID
WHERE O.CUSTOMER_ID = N'C001';

--Hiển thị tổng số lượng đặt hàng và tổng giá trị của mỗi khách hàng
SELECT 
    C.CUSTOMER_ID,
    C.CUSTOMER_NAME,
    COUNT(O.ORDER_ID) AS TOTAL_ORDERS,
    SUM(P.STANDARD_PRICE * OU.ORDERED_QUANTITY) AS TOTAL_ORDER_VALUE
FROM 
    T_CUSTOMER C
JOIN 
    T_ORDER O ON C.CUSTOMER_ID = O.CUSTOMER_ID
JOIN 
    T_ORDER_UNE OU ON O.ORDER_ID = OU.ORDER_ID
JOIN 
    T_PRODUCT P ON OU.PRODUCT_ID = P.PRODUCT_ID
GROUP BY 
    C.CUSTOMER_ID, C.CUSTOMER_NAME
ORDER BY 
    TOTAL_ORDER_VALUE DESC;

--Hiển thị các sản phẩm được đặt hàng nhiều nhất và số lượng khách hàng đã đặt sản phẩm đó
SELECT 
    P.PRODUCT_ID,
    P.PRODUCT_DESCRIPTION,
    SUM(OU.ORDERED_QUANTITY) AS TOTAL_ORDERED_QUANTITY,
    COUNT(DISTINCT O.CUSTOMER_ID) AS CUSTOMER_COUNT
FROM 
    T_PRODUCT P
JOIN 
    T_ORDER_UNE OU ON P.PRODUCT_ID = OU.PRODUCT_ID
JOIN 
    T_ORDER O ON OU.ORDER_ID = O.ORDER_ID
GROUP BY 
    P.PRODUCT_ID, P.PRODUCT_DESCRIPTION
ORDER BY 
    TOTAL_ORDERED_QUANTITY DESC;

--Truy vấn các khách hàng có tổng giá trị đơn hàng lớn nhất
SELECT 
    C.CUSTOMER_ID,
    C.CUSTOMER_NAME,
    SUM(P.STANDARD_PRICE * OU.ORDERED_QUANTITY) AS TOTAL_ORDER_VALUE
FROM 
    T_CUSTOMER C
JOIN 
    T_ORDER O ON C.CUSTOMER_ID = O.CUSTOMER_ID
JOIN 
    T_ORDER_UNE OU ON O.ORDER_ID = OU.ORDER_ID
JOIN 
    T_PRODUCT P ON OU.PRODUCT_ID = P.PRODUCT_ID
GROUP BY 
    C.CUSTOMER_ID, C.CUSTOMER_NAME
ORDER BY 
    TOTAL_ORDER_VALUE DESC



--3. Thay đổi dữ liệu

--Cập nhật tên khách hàng có mã 'C001
UPDATE T_CUSTOMER 
SET CUSTOMER_NAME = N'Nguyễn Văn An'
WHERE CUSTOMER_ID = N'C001';

--Cập nhật giá sản phẩm 'P001'
UPDATE T_PRODUCT 
SET STANDARD_PRICE = 36000 
WHERE PRODUCT_ID = N'P001';

--Cập nhật số lượng sản phẩm đặt hàng trong đơn 'O001' và sản phẩm 'P001'
UPDATE T_ORDER_UNE 
SET ORDERED_QUANTITY = 3 
WHERE ORDER_ID = N'O001' AND PRODUCT_ID = N'P001';

--Xóa khách hàng có mã 'C005'
DELETE FROM T_CUSTOMER 
WHERE CUSTOMER_ID = N'C005';

--Xóa sản phẩm có mã 'P005'
DELETE FROM T_PRODUCT 
WHERE PRODUCT_ID = N'P005';

--Xóa đơn hàng có mã 'O005'
DELETE FROM T_ORDER 
WHERE ORDER_ID = N'O005';

--Xóa tất cả các bản ghi trong T_ORDER_UNE của đơn hàng 'O005'
DELETE FROM T_ORDER_UNE 
WHERE ORDER_ID = N'O005';

--Cập nhật trạng thái của tất cả các sản phẩm còn hàng thành 'Hết hàng'
UPDATE T_PRODUCT 
SET STATE = N'Hết hàng'
WHERE STATE = N'Còn hàng';


--Cập nhật địa chỉ của khách hàng 'C003'
UPDATE T_CUSTOMER 
SET CUSTOMER_ADDRESS = N'Hải Châu'
WHERE CUSTOMER_ID = N'C003';

--Xóa tất cả các đơn hàng có ngày đặt trước '2024-06-10'
DELETE FROM T_ORDER 
WHERE ORDER_DATE < '2024-06-10';

--Thay đổi mã sản phẩm 'P003' thành 'P007'
UPDATE T_PRODUCT 
SET PRODUCT_ID = N'P007'
WHERE PRODUCT_ID = N'P003';

--Cập nhật loại khách hàng của 'C004' thành 'PLATINUM'
UPDATE T_CUSTOMER 
SET STATE = N'PLATINUM'
WHERE CUSTOMER_ID = N'C004';

--Xóa tất cả các sản phẩm có giá dưới 10,000
DELETE FROM T_PRODUCT 
WHERE STANDARD_PRICE < 10000;

--Cập nhật số lượng đặt hàng cho sản phẩm 'P002' trong đơn hàng 'O004'
UPDATE T_ORDER_UNE 
SET ORDERED_QUANTITY = 5
WHERE ORDER_ID = N'O004' AND PRODUCT_ID = N'P002';

--Xóa tất cả các đơn hàng không có trong bảng T_ORDER_UNE
DELETE FROM T_ORDER 
WHERE ORDER_ID NOT IN (SELECT ORDER_ID FROM T_ORDER_UNE);

--Cập nhật tất cả các địa chỉ khách hàng tại thành phố 'Đà Nẵng' thành 'Hải Châu'
UPDATE T_CUSTOMER 
SET CUSTOMER_ADDRESS = N'Hải Châu'
WHERE CITY = N'Đà Nẵng';

--Xóa tất cả các bản ghi trong T_ORDER_UNE có số lượng đặt hàng là 0
DELETE FROM T_ORDER_UNE 
WHERE ORDERED_QUANTITY = 0;

--Cập nhật mã khách hàng trong đơn hàng 'O003' thành 'C002'
UPDATE T_ORDER 
SET CUSTOMER_ID = N'C002'
WHERE ORDER_ID = N'O003';

--Xóa tất cả các khách hàng không có đơn hàng nào
DELETE FROM T_CUSTOMER 
WHERE CUSTOMER_ID NOT IN (SELECT CUSTOMER_ID FROM T_ORDER);

--Cập nhật giá của tất cả các sản phẩm lên 10%
UPDATE T_PRODUCT 
SET STANDARD_PRICE = STANDARD_PRICE * 1.10;



--THỦ TỤC (PROCEDURE)

--5.1. Viết thủ tục Insert dữ liệu cho các bảng có kiểm tra ràng buộc

--Thủ tục nhập cho bảng T_PRODUCT 
ALTER PROCEDURE SP_NHAPTPRODUCT
@PRODUCT_ID VARCHAR(10), @PRODUCT_DESCRIPTION NVARCHAR(100), @PRODUCT_FINISH NVARCHAR(10), 
@STANDARD_PRICE FLOAT, @STATE NVARCHAR(10), @PRODUCT_UNE_ID NVARCHAR(10)
AS
	BEGIN 
		IF EXISTS (SELECT * FROM T_PRODUCT WHERE PRODUCT_ID = @PRODUCT_ID)
			BEGIN
				PRINT N'TRÙNG MÃ SẢN PHẨM. KIỂM TRA LẠI.'
			END			
		ELSE 
			IF @STANDARD_PRICE < 0
				PRINT N'GIÁ SẢN PHẨM PHẢI LỚN HƠN 0.'
			ELSE
				BEGIN
					INSERT INTO T_PRODUCT VALUES (@PRODUCT_ID, @PRODUCT_DESCRIPTION, @PRODUCT_FINISH, @STANDARD_PRICE, @STATE, @PRODUCT_UNE_ID)
					PRINT N'THÊM SẢN PHẨM THÀNH CÔNG.'
				END
	END

SELECT * FROM T_PRODUCT;
EXEC SP_NHAPTPRODUCT 'P009', N'Gà sốt trứng muối', '06/16/2024', -40000, N'Còn hàng', 'UNE008';

--Thủ tục nhập bảng T_CUSTOMER
ALTER PROCEDURE SP_NHAPTCUSTOMER
@CUSTOMER_ID VARCHAR(10), @CUSTOMER_NAME NVARCHAR(50), @CUSTOMER_ADDRESS NVARCHAR(50), 
@CITY NVARCHAR(50), @STATE NVARCHAR(10), @POSTAL_CODE NVARCHAR(10)
AS
	BEGIN 
		IF EXISTS (SELECT * FROM T_CUSTOMER WHERE CUSTOMER_ID = @CUSTOMER_ID)
			PRINT N'TRÙNG MÃ KHÁCH HÀNG. KIỂM TRA LẠI.'
		ELSE
			BEGIN
				INSERT INTO T_CUSTOMER VALUES (@CUSTOMER_ID, @CUSTOMER_NAME, @CUSTOMER_ADDRESS, @CITY, @STATE, @POSTAL_CODE)
				PRINT N'THÊM KHÁCH HÀNG THÀNH CÔNG.'
			END
	END

SELECT * FROM T_CUSTOMER;
EXEC SP_NHAPTCUSTOMER 'C006', N'Trần Thị E', N'Hải Châu', N'Đà Nẵng', 'GOLD', '99999';

--Thủ tục nhập bảng T_ORDER
ALTER PROCEDURE SP_NHAPTORDER
@ORDER_ID VARCHAR(10), @ORDER_DATE DATE, @CUSTOMER_ID VARCHAR(10)
AS
	BEGIN 
		IF NOT EXISTS (SELECT * FROM T_CUSTOMER WHERE CUSTOMER_ID = @CUSTOMER_ID)
			PRINT N'KHÔNG TỒN TẠI KHÁCH HÀNG NÀY. KIỂM TRA LẠI.'
		ELSE
			IF EXISTS (SELECT * FROM T_ORDER WHERE ORDER_ID = @ORDER_ID)
				PRINT N'TRÙNG MÃ ĐƠN HÀNG. KIỂM TRA LẠI.'
			ELSE
				BEGIN
					INSERT INTO T_ORDER VALUES (@ORDER_ID, @ORDER_DATE, @CUSTOMER_ID)
					PRINT N'NHẬP ĐƠN ĐẶT HÀNG THÀNH CÔNG.'
				END
	END

SELECT * FROM T_ORDER;
SELECT * FROM T_CUSTOMER;
EXEC SP_NHAPTORDER 'O008', '2024-06-12', 'C007';

--Thủ tục nhập bảng T_ORDER_LINE
CREATE PROCEDURE SP_NHAP_T_ORDER_LINE
@ORDER_ID VARCHAR(10), @PRODUCT_ID VARCHAR(10), @ORDERED_QUANTITY INT
AS
	BEGIN 
		IF NOT EXISTS (SELECT * FROM T_ORDER WHERE ORDER_ID = @ORDER_ID)
			PRINT N'KHÔNG TỒN TẠI ĐƠN HÀNG NÀY. KIỂM TRA LẠI.'
		ELSE
			IF NOT EXISTS (SELECT * FROM T_PRODUCT WHERE PRODUCT_ID = @PRODUCT_ID)
				PRINT N'KHÔNG TỒN TẠI SẢN PHẨM NÀY. KIỂM TRA LẠI.'
			ELSE
				IF EXISTS (SELECT * FROM T_ORDER_UNE WHERE ORDER_ID = @ORDER_ID AND PRODUCT_ID = @PRODUCT_ID)
					PRINT N'TRÙNG ĐƠN HÀNG. KIỂM TRA LẠI.'
				ELSE
					IF @ORDERED_QUANTITY < 0
						PRINT N'SỐ LƯỢNG ĐẶT HÀNG PHẢI LỚN HƠN 0'
					ELSE
						BEGIN
							INSERT INTO T_ORDER_UNE VALUES (@ORDER_ID, @PRODUCT_ID, @ORDERED_QUANTITY)
							PRINT N'THÊM ĐƠN HÀNG THÀNH CÔNG.'
						END
	END

SELECT * FROM T_ORDER_UNE;
SELECT * FROM T_PRODUCT;
EXEC SP_NHAP_T_ORDER_UNE 'O009', 'P009', '3';

--5.2. Cho biết thông tin hóa đơn của khách hàng khi nhân viên nhập vào MAKH, Ngày mua hàng

ALTER PROCEDURE SP_THONGTINKH
@CUSTOMER_ID VARCHAR(10), @ORDER_DATE DATE
AS
	BEGIN
		IF NOT EXISTS (SELECT * FROM T_ORDER WHERE CUSTOMER_ID = @CUSTOMER_ID)
			PRINT N'KHÁCH HÀNG NÀY CHƯA CÓ ĐƠN HÀNG NÀO.'
		ELSE
			IF NOT EXISTS (SELECT * FROM T_CUSTOMER WHERE CUSTOMER_ID = @CUSTOMER_ID)
				PRINT N'KHÔNG TỒN TẠI KHÁCH HÀNG NÀY.'
			ELSE
				IF NOT EXISTS (SELECT * FROM T_ORDER WHERE ORDER_DATE = @ORDER_DATE)
					PRINT N'KHÔNG CÓ ĐƠN HÀNG NÀO VÀO NGÀY NÀY.'
				ELSE
					SELECT * FROM T_CUSTOMER C 
					JOIN T_ORDER O 
					ON C.CUSTOMER_ID = O.CUSTOMER_ID 
					WHERE O.CUSTOMER_ID = @CUSTOMER_ID AND O.ORDER_DATE = @ORDER_DATE
	END

EXEC SP_THONGTINKH 'C001', '2024-07-30';

--5.3. Viết thủ tục khi nhập ORDER_ID hiển thị thông tin khách hàng mua những mặt hàng gì, thành tiền bao nhiêu
ALTER PROCEDURE SP_THONGTINMUAHANG
@ORDER_ID VARCHAR(10)
AS
	BEGIN
		IF NOT EXISTS (SELECT * FROM T_ORDER WHERE ORDER_ID = @ORDER_ID)
			PRINT N'KHÔNG TỒN TẠI ĐƠN HÀNG NÀY. KIỂM TRA LẠI.'
		ELSE
			SELECT O.ORDER_ID, C.CUSTOMER_NAME, P.PRODUCT_DESCRIPTION, 
			P.STANDARD_PRICE, OUNE.ORDERED_QUANTITY, (P.STANDARD_PRICE * OUNE.ORDERED_QUANTITY) AS N'TOTAL_PRICE' FROM T_ORDER_UNE OUNE 
			JOIN T_PRODUCT P ON OUNE.PRODUCT_ID = P.PRODUCT_ID
			JOIN T_ORDER O ON OUNE.ORDER_ID = O.ORDER_ID
			JOIN T_CUSTOMER C ON C.CUSTOMER_ID = O.CUSTOMER_ID
			WHERE O.ORDER_ID = @ORDER_ID
	END

SELECT * FROM T_ORDER;
SELECT * FROM T_PRODUCT;
SELECT * FROM T_ORDER_UNE;
EXEC SP_THONGTINMUAHANG 'O002';

--5.4. Viết thủ tục cho biết thông tin những mặt hàng nào được bán ra trong ngày, khi nhập ngày
ALTER PROCEDURE SP_THONGTINHANGTRONGNGAY
@ORDER_DATE DATE
AS
	BEGIN
		IF NOT EXISTS (SELECT * FROM T_ORDER WHERE ORDER_DATE = @ORDER_DATE)
			PRINT N'KHÔNG CÓ ĐƠN HÀNG NÀO ĐƯỢC BÁN RA TRONG NGÀY NÀY.'
		ELSE
			SELECT P.PRODUCT_DESCRIPTION, O.ORDER_DATE
			FROM T_ORDER_UNE OUNE 
			JOIN T_PRODUCT P ON OUNE.PRODUCT_ID = P.PRODUCT_ID
			JOIN T_ORDER O ON OUNE.ORDER_ID = O.ORDER_ID
			WHERE O.ORDER_DATE = @ORDER_DATE
	END

EXEC SP_THONGTINHANGTRONGNGAY '2024-06-30';

--5.5. Viết thủ tục tìm khách hàng mua mặt hàng 'xxxx' trong tháng/năm

ALTER PROCEDURE SP_THONGTINHANGTRONGTHANG
@PRODUCT_DESCRIPTION NVARCHAR(100), @ORDER_DATE DATE
AS
	BEGIN
		IF NOT EXISTS (SELECT * FROM T_PRODUCT WHERE PRODUCT_DESCRIPTION = @PRODUCT_DESCRIPTION)
			PRINT N'KHÔNG CÓ SẢN PHẨM TÊN NÀY.'
		ELSE
			IF NOT EXISTS (SELECT * FROM T_ORDER WHERE ORDER_DATE = @ORDER_DATE)
				PRINT N'KHÔNG CÓ ĐƠN HÀNG NÀO ĐƯỢC BÁN RA TRONG NGÀY NÀY.'
			ELSE
				SELECT C.CUSTOMER_NAME, P.PRODUCT_DESCRIPTION, O.ORDER_DATE
				FROM T_ORDER_UNE OUNE 
				JOIN T_PRODUCT P ON OUNE.PRODUCT_ID = P.PRODUCT_ID
				JOIN T_ORDER O ON OUNE.ORDER_ID = O.ORDER_ID
				JOIN T_CUSTOMER C ON C.CUSTOMER_ID = O.CUSTOMER_ID
				WHERE O.ORDER_DATE = @ORDER_DATE AND P.PRODUCT_DESCRIPTION = @PRODUCT_DESCRIPTION
	END

EXEC SP_THONGTINHANGTRONGTHANG N'Cơm', '2024-06-10';


--6. TRIGGER 

CREATE TABLE INVOICE(
INVOICE_NUMBER INT,
ORDER_ID VARCHAR(10),
INVOICE_DATE DATE NOT NULL,
CONSTRAINT pk_INVOICE_NUMBER PRIMARY KEY(INVOICE_NUMBER),
CONSTRAINT fk_ORDER_ID_INVOICE FOREIGN KEY(ORDER_ID) REFERENCES T_ORDER(ORDER_ID),
CONSTRAINT uq_ORDER_ID UNIQUE(ORDER_ID)
);

create table PAYMENT(
INVOICE_NUMBER INT,
PAYMENT_DATE DATE NOT NULL,
PAYMENT_AMOUNT FLOAT NOT NULL,
CONSTRAINT pk_PAYMENT_DATE PRIMARY KEY(PAYMENT_DATE),
CONSTRAINT fk_INVOICE_NUMBER FOREIGN KEY(INVOICE_NUMBER) REFERENCES INVOICE(INVOICE_NUMBER),
);

create table HISTORY_INVOICE(
INVOICE_NUMBER INT,
PAYMENT_TOTAL FLOAT NOT NULL,
AMOUNT_OWED FLOAT NOT NULL,
CONSTRAINT fk_INVOICE_NUMBER_HISTORY FOREIGN KEY(INVOICE_NUMBER) REFERENCES INVOICE(INVOICE_NUMBER),
CONSTRAINT uq_INVOICE_NUMBER UNIQUE(INVOICE_NUMBER)
);

--Viết trigger khi nhập dữ liệu cho bảng invoice thì dữ liệu bảng history_invoice cũng được thêm vào với pay_total = amount_owed = sum (ordered_quantity*standard_price)
CREATE TRIGGER tr_theminvoice
ON INVOICE
AFTER INSERT
AS
BEGIN
    INSERT INTO HISTORY_INVOICE (INVOICE_NUMBER, PAYMENT_TOTAL, AMOUNT_OWED)
    SELECT 
        i.INVOICE_NUMBER,
        SUM(ol.ORDERED_QUANTITY * p.STANDARD_PRICE) AS PAYMENT_TOTAL,
        SUM(ol.ORDERED_QUANTITY * p.STANDARD_PRICE) AS AMOUNT_OWED
    FROM 
        INSERTED i
        JOIN T_ORDER o ON i.ORDER_ID = o.ORDER_ID
        JOIN T_ORDER_UNE ol ON o.ORDER_ID = ol.ORDER_ID
        JOIN T_PRODUCT p ON ol.PRODUCT_ID = p.PRODUCT_ID
    GROUP BY 
        i.INVOICE_NUMBER;
END;

SELECT * FROM T_ORDER;
SELECT * FROM INVOICE;
SELECT * FROM HISTORY_INVOICE;
INSERT INTO INVOICE VALUES (001,'O001', '2024-06-08');

--Viết trigger khi khách hàng thanh toán tiền payment_amount thì số tiền trong amount_owed cũng giảm theo
CREATE TRIGGER tr_update_amount_owed
ON PAYMENT
AFTER INSERT
AS
BEGIN
    UPDATE HISTORY_INVOICE
    SET AMOUNT_OWED = AMOUNT_OWED - i.PAYMENT_AMOUNT
    FROM INSERTED i
    WHERE HISTORY_INVOICE.INVOICE_NUMBER = i.INVOICE_NUMBER;
END;

SELECT * FROM HISTORY_INVOICE;
SELECT * FROM PAYMENT;
INSERT INTO PAYMENT VALUES (001, '2024-06-08', 35000);

--7. FUNCTION

--Hàm Tính tổng số lượng khách hàng đặt hàng trong ngày,hiển thị những ngày có tổng số lượng khách hàng đặt lớn hơn ngày hiện tại--

CREATE FUNCTION TinhDonHang(@NgayDat date)
RETURNS int
AS
	BEGIN
		Declare @soluong int
		select @soluong= COUNT(Distinct CUSTOMER_ID)  from T_ORDER
		where ORDER_DATE=@NgayDat 
		return @soluong;
	END

SELECT  DBO.TinhDonHang('2020-01-15') as Tong_KhachHang

CREATE FUNCTION NgayLonHon()
RETURNS  @ketqua table(ORDER_DATE date,total_number int)
AS
	BEGIN
		insert into @ketqua
		select ORDER_DATE,COUNT(Distinct CUSTOMER_ID) as total_number from T_ORDER
		group by ORDER_DATE
		having COUNT(Distinct CUSTOMER_ID)> DBO.TinhDonHang('2020-01-15')
		return;
	END

SELECT  * from DBO.NgayLonHon()

--Viết hàm để xem tổng số đầu mặt hàng  cho các nhóm hàng khi nhập productID ,Xem nhóm hàng điện tử--
CREATE FUNCTION DemMatHangLine(@ProductLine NVARCHAR(20))
RETURNS int 
AS
	BEGIN
		DECLARE @ProductCount INT;
        SELECT @ProductCount = COUNT(DISTINCT PRODUCT_ID)
		FROM T_PRODUCT
		 WHERE PRODUCT_LINE_ID = @ProductLine;
		RETURN @ProductCount;
	END

SELECT DBO.DemMatHangLine('Electronic') AS Total_Products_Electronic;
