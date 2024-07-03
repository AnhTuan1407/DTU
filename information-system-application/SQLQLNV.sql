CREATE DATABASE QUANLYNHANVIEN;
USE QUANLYNHANVIEN;

create table PHONG 
( MAPHONG char(10),
  TENPHONG nvarchar(50) not null,
  DIADIEM nvarchar(100), 
  SONV int,
  constraint pk_MAPHONG primary key(MAPHONG),
  constraint ch_SONV check(SONV >= 0)
);

create table DUAN 
( MADUAN char(10),
  TENDUAN nvarchar(100) not null,
  KINHPHI float, 
  constraint pk_MADUAN primary key(MADUAN),
  constraint ch_KINHPHI check(KINHPHI >= 0)
);

create table NHANVIEN 
( MANV char(10),
  HOLOT nvarchar(50) not null,
  TENNV nvarchar(50) not null,
  SDT varchar(10),
  MAPHONG char(10),
  constraint pk_MANV primary key(MANV),
  constraint fk_MAPHONG foreign key(MAPHONG) references PHONG(MAPHONG)
);

create table NV_DA 
( MANV char(10),
  MADUAN char(10),
  SOGIO float,
  constraint fk_MANV foreign key(MaNV) references NHANVIEN(MANV),
  constraint fk_MADUAN foreign key(MADUAN) references DUAN(MADUAN),
  constraint ch_SOGIO check(SOGIO >= 0)
);

/* Thêm trường địa chỉ vào bảng nhân viên */
alter table NHANVIEN
add DIACHI nvarchar(100);

/*2. Xóa trường địa chỉ của bảng nhân viên */
alter table NHANVIEN
drop column DIACHI;

/*3. Thêm 1 trường giới tính và cso ràng buộc miền giá trị "Nam, Nữ, Khác" */
Alter table NHANVIEN
add GIOITINH nvarchar(5);


INSERT INTO PHONG
VALUES ('P1', N'PHÒNG TỔ CHỨC', N'ĐÀ NẴNG', 0);
INSERT INTO PHONG
VALUES ('P2', N'PHÒNG IT', N'ĐÀ NẴNG', 0);
INSERT INTO PHONG
VALUES ('P3', N'PHÒNG KẾ TOÁN', N'ĐÀ NẴNG', 0);
SELECT * FROM PHONG;


INSERT INTO NHANVIEN
VALUES ('NV01', N'Nguyễn Văn', N'A', N'0987324561', N'P1'),
('NV02', N'Nguyễn Văn', N'B', N'0987324561', N'P1'),
('NV03', N'Phạm Thị', N'C', N'0987324561', N'P3'),
('NV04', N'Nguyễn Anh', N'D', N'0987324561', N'P2'),
('NV05', N'Nguyễn Thị', N'E', N'0987324561', N'P2');

SELECT * FROM NHANVIEN;

INSERT INTO DUAN
VALUES ('DA01', N'Đầu tư chứng khoáng', 10000),
('DA02', N'Phát triển website bán hàng tự động', 150000),
('DA03', N'Phát triển trí tuệ nhân tạo có cảm súc', 300000);
SELECT * FROM DUAN;

INSERT INTO NV_DA
VALUES ('NV01', N'DA01', 10000),
('NV02', N'DA01', 150000),
('NV01', N'DA03', 300000);

--Viết thủ tục nhập dữ liệu cho bảng PHONG, nếu trùng khóa thì phải báo lỗi, ngược lại ra thông báo 'Nhập liệu thành công'. Giao diện nhập dữ liệu

CREATE PROCEDURE SP_INSERT_PHONG
(@MAPHONG VARCHAR(10), @TENPHONG NVARCHAR(50), @DIADIEM NVARCHAR(100), @SONV INT)
AS
	BEGIN
			IF EXISTS (SELECT * FROM PHONG WHERE MAPHONG = @MAPHONG)
				BEGIN 
					RAISERROR (N'Mã phòng đã tồn tại. Mời bạn nhập lại!', 16,1);
					ROLLBACK TRANSACTION;
				END
			ELSE
				BEGIN
					INSERT INTO PHONG
					VALUES (@MAPHONG, @TENPHONG, @DIADIEM, @SONV)
					PRINT N'INSERT THÀNH CÔNG!';
				END
	END

--Biên dịch
EXEC SP_INSERT_PHONG 'P8', N'Kiểm tra', N'Đà Nẵng', 0;

SELECT * FROM PHONG;

--vd1: Viết thủ tục khi người sử dụng nhập vào mã phòng thì list thông tin của nhân viên trong phòng đó diện cơ bản để chứng minh cho thủ tục trên 
CREATE PROCEDURE SP_DSPHONG
@MAPHONG VARCHAR(10)
AS 
	BEGIN
		IF EXISTS (SELECT * FROM PHONG WHERE MAPHONG = @MAPHONG)
			SELECT MANV, HOLOT, TENNV, SDT FROM NHANVIEN
			WHERE MAPHONG = @MAPHONG
		ELSE
			PRINT N'KHÔNG TỒN TẠI PHÒNG NÀY!'
	END

EXEC SP_DSPHONG 'P2';

--vd3: Viết thủ tục tính tổng số nhân viên của phòng khi người sử dụng truyền vào mã phòng
CREATE PROCEDURE SP_TONGNVPHONG
@MAPHONG VARCHAR(10),
@SOLUONG INT OUTPUT
AS
	SELECT @SOLUONG = COUNT (*)
	FROM NHANVIEN
	WHERE MAPHONG = @MAPHONG
GO 

--Thực hiện thủ tục
DECLARE @DEM INT;
DECLARE @PHONG VARCHAR(10);
SET @PHONG = 'P1';
	EXEC SP_TONGNVPHONG @MAPHONG = @PHONG, @SOLUONG = @DEM OUTPUT;
	PRINT N'SỐ LƯỢNG NHÂN VIÊN PHÒNG ' + @PHONG + N' LÀ: ' + CAST(@DEM AS CHAR(20))

--Viết thủ tục khi người dùng nhập vào mã nhân viên, hiển thị thông tin nhân viên và phòng ban tương ứng
CREATE PROCEDURE SP_THONGTINNV
@MANV VARCHAR(10)
AS
	BEGIN
		IF EXISTS (SELECT * FROM NHANVIEN WHERE MANV = @MANV)
			SELECT NV.HOLOT, NV.TENNV, NV.SDT, P.TENPHONG 
			FROM NHANVIEN NV
			JOIN PHONG P ON NV.MAPHONG = P.MAPHONG
			WHERE NV.MANV = @MANV;
		ELSE 
			PRINT N'NHÂN VIÊN NÀY KHÔNG TỒN TẠI!'
	END

SELECT * FROM NHANVIEN;
EXEC SP_THONGTINNV'NV01';
--Viết thủ tục khi người dùng nhập vào tên nhân viên, hiển thị thông tin nhân viên đã nhận những dự án nào
CREATE PROCEDURE SP_TIMTHEOTENNV
@TENNV VARCHAR(50)
AS
	BEGIN
		IF EXISTS (SELECT * FROM NHANVIEN WHERE UPPER(TENNV) = UPPER(@TENNV))
			SELECT NV.HOLOT, NV.TENNV, NV.SDT, DA.TENDUAN 
			FROM NHANVIEN NV
			LEFT JOIN NV_DA NVDA ON NVDA.MANV = NV.MANV
			LEFT JOIN DUAN DA ON DA.MADUAN = NVDA.MADUAN
			WHERE UPPER(NV.TENNV) = UPPER('A');
		ELSE 
			PRINT N'KHÔNG TỒN TẠI NHÂN VIÊN TÊN NÀY!'
	END

SELECT * FROM NHANVIEN;
EXEC SP_TIMTHEOTENNV'A';
--Viết thủ tục cập nhật lại SONV cho phòng ban
SELECT * FROM PHONG;
CREATE PROCEDURE SP_CAPNHATSONV
@MAPHONG VARCHAR(10), @SONV INT
AS 
	BEGIN
		IF EXISTS (SELECT * FROM PHONG WHERE MAPHONG = @MAPHONG)
			PRINT N'Phòng không tồn tại!!!'
		ELSE
			UPDATE PHONG
			SET SONV = @SONV
			WHERE PHONG.MAPHONG = @MAPHONG
	END

EXEC SP_CAPNHATSONV 'P1', 10;
create procedure SP_Update_Phong
(@SoNV int,@MaPhong varchar(10) )
as 
	begin 
		if exists(select * from Phong where MaPhong=@MaPhong)
			update Phong set SoNV=@SoNV
			where MaPhong=@MaPhong
		else
				print(N'Không tồn tại dữ liệu phòng')
	end

EXEC SP_CAPNHATSONV 'P1';
--Viết thủ tục hiển thị số lượng nhân viện làm trong dự án khi người dùng nhập mã dự án
create procedure SP_SearchMaDA_Nhanvien
(@MaDuan Nvarchar(10))
as 
	begin 
		if exists(select * from NV_DA where MADUAN=@MaDuan)
			select a.MANV ,MADUAN,B.MAPHONG,c.SONV from NV_DA a,NHANVIEN b,PHONG c
			where MADUAN=@MaDuan and a.MANV=b.MANV and B.MAPHONG=c.MAPHONG
		else
				print(N'Không tồn tại dữ liệu')
	end
SELECT * FROM DUAN;
EXEC SP_SearchMaDA_Nhanvien 'DA01'

--6. Viết thủ tục nhập dữ liệu cho bảng NHANVIEN, nếu trùng khóa thì phải báo lỗi, ngược lại 
--thông báo 'Nhập dữ liệu thành công'. Kiểm tra không tồn tại PHONG thì cũng in ra câu thông báo

CREATE PROCEDURE SP_NHAPNHANVIEN
@MANV CHAR(10), @HOLOT NVARCHAR(50), @TEN NVARCHAR(15), @SDT VARCHAR(15),
@MAPHONG CHAR(10)
AS
	BEGIN
			IF NOT EXISTS (SELECT * FROM PHONG WHERE MAPHONG  = @MAPHONG)
				PRINT N'Không tồn tại phòng này. Kiểm tra lại!!'
			ELSE
				IF EXISTS (SELECT * FROM NHANVIEN WHERE MANV = @MANV)
					PRINT N'Trùng mã nhân viên. Kiểm tra lại!!!'
				ELSE
					BEGIN 
						INSERT INTO NHANVIEN VALUES(@MANV, @HOLOT, @TEN, @SDT, @MAPHONG)
						PRINT N'Nhập nhân viên thành công!!!'
					END
	END

SELECT * FROM NHANVIEN;
SELECT * FROM PHONG;

--Nhập không đúng mã phòng
EXEC SP_NHAPNHANVIEN 'NV06', N'Trần Thị ', 'F', '0968752311', 'P6';

--Nhập trùng mã nhân viên
EXEC SP_NHAPNHANVIEN 'NV05', N'Trần Thị ', 'F', '0968752311', 'P2';

--Nhập đúng 
EXEC SP_NHAPNHANVIEN 'NV06', N'Trần Thị ', 'F', '0968752311', 'P2';

--7. Nhập phòng
CREATE PROCEDURE SP_NHAPPHONG
@MAPHONG VARCHAR(10), @TENPHONG NVARCHAR(50), @DIADIEM NVARCHAR(100)
AS
	BEGIN
		IF EXISTS (SELECT * FROM PHONG WHERE MAPHONG = @MAPHONG)
			PRINT N'Trùng mã phòng!!!'
		ELSE
			BEGIN
				INSERT INTO PHONG VALUES (@MAPHONG, @TENPHONG, @DIADIEM, 0)
				PRINT N'Nhập phòng thành công!!!'
			END
	END

--8. Nhập bảng dự án
CREATE PROCEDURE SP_NHAPDUAN
@MADUAN VARCHAR(10), @TENDUAN NVARCHAR(100), @KINHPHI INT
AS
	BEGIN
		IF EXISTS (SELECT * FROM DUAN WHERE MADUAN = @MADUAN)
			PRINT N'Trùng mã dự án!!!'
		ELSE
			IF  @KINHPHI < 0
				PRINT N'Kinh phí phải lớn hơn 0';
			ELSE
				BEGIN
					INSERT INTO DUAN VALUES (@MADUAN, @TENDUAN, @KINHPHI)
				END
	END

EXEC SP_NHAPDUAN 'DA05', 'KHOA HỌC MÁY TÍNH', '-2000';

--9. Nhập bảng nhân viên dự án
ALTER PROCEDURE SP_NHAPNVDA
@MANV VARCHAR(10), @MADUAN VARCHAR(10), @SOGIO INT
AS
BEGIN
	IF EXISTS (SELECT * FROM NV_DA WHERE MADUAN = @MADUAN AND MANV = @MANV)
		PRINT N'Đã tồn tại nhân viên nhận dự án này. Kiểm tra lại!!'
	ELSE
		IF NOT EXISTS (SELECT * FROM NHANVIEN WHERE MANV = @MANV)
			PRINT N'Không tồn tại nhân viên này!!!'
		ELSE
			IF NOT EXISTS (SELECT * FROM DUAN WHERE MADUAN = @MADUAN)
				PRINT N'Không tồn tại dự án này!!!'
			ELSE
				IF @SOGIO < 0
					PRINT N'Số giờ phải lớn hơn 0'
				ELSE
					BEGIN
						INSERT INTO NV_DA VALUES (@MANV, @MADUAN, @SOGIO)
					END
	END

SELECT * FROM NV_DA;
EXEC SP_NHAPNVDA 'NV01', 'DA100', 10; 


--TRIGGER

--Vd1: INSERT TRIGGER. Tự động thực hiện mỗi khi có hành động chèn bản ghi. Một bảng tạm có tên INSERTED tạo ra
--Bản ghi chèn vào được lưu vào table và INSERTED

--Tạo 1 trigger tự động thực hiện một câu thông báo mỗi khi nhập thêm một bản ghi mới cho table NHANVIEN

CREATE TRIGGER TR_INSNV
ON NHANVIEN
FOR INSERT
AS
	BEGIN
		RAISERROR ('%d Dòng đã được thêm vào trong bảng NHANVIEN',0,1,@@rowcount)
	END
SELECT * FROM NHANVIEN;
INSERT INTO NHANVIEN VALUES ('NV08', N'Phan Ngọc', 'G', '0875362611', 'P3');

--Vd2: DELETE TRIGGER. Tự động thực hiện mỗi khi có hành động xóa bản ghi.
--Tạo một trigger tự động được thực hiện một câu thông báo khi xóa một hoặc nhiều bản ghi trên bảng NHANVIEN

ALTER TRIGGER TR_DELNV
ON NHANVIEN
FOR DELETE
AS
	BEGIN
		RAISERROR ('%d Dòng đã được xóa trong bảng NHANVIEN',0,1,@@rowcount)
	END

DELETE FROM NHANVIEN WHERE MANV = 'NV08';

--Vd3: UPDATE TRIGGER. 
--Tạo một trigger tự chạy câu thông báo khi có một hành động cập nhật trên bảng NHANVIEN

ALTER TRIGGER TR_UPDNV
ON NHANVIEN
FOR UPDATE
AS
	BEGIN
		RAISERROR ('%d Dòng đã được thay đổi trong bảng NHANVIEN',0,1,@@rowcount)
		SELECT * FROM INSERTED;
	END
SELECT * FROM NHANVIEN;

UPDATE NHANVIEN
SET SDT = '987654321'
WHERE MANV = 'NV08';

--Vd4: Xóa hết dữ liệu của bảng NV_DA và bảng NHANVIEN

DELETE FROM NV_DA;
DELETE FROM NHANVIEN;

--------------------------------
--Cập nhật lại SONV của bảng PHONG về 0
UPDATE PHONG
SET SONV = 0;

--------------------------------
SELECT * FROM PHONG;
SELECT * FROM NHANVIEN;

--Trigger xử lý qui tắc nghiệp vụ
--Viết trigger khi chèn một nhân viên vào phòng ban nào đó trên bảng NHANVIEN thì SONV 
--trong bảng PHONG tăng lên 1

CREATE TRIGGER TR_TONGNV
ON NHANVIEN
FOR INSERT
AS
	UPDATE PHONG 
	SET SONV = SONV + 1
	WHERE PHONG.MAPHONG = (SELECT MAPHONG FROM INSERTED)

EXEC SP_NHAPNHANVIEN 'NV01', 'TRAN', 'B', '1111111111', 'P1';
EXEC SP_NHAPNHANVIEN 'NV02', N'NGUYỄN THỊ', 'A', '2222222222', 'P1';
EXEC SP_NHAPNHANVIEN 'NV03', N'PHẠM THỊ', 'C', '3333333333', 'P1';
EXEC SP_NHAPNHANVIEN 'NV04', N'NGUYỄN VĂN', 'D', '4444444444', 'P2';
EXEC SP_NHAPNHANVIEN 'NV05', N'PHAN ANH', 'E', '5555555555', 'P2';
SELECT * FROM PHONG;
SELECT * FROM NHANVIEN;

--Vd5: Xóa một nhân viên thì tổng số nhân viên trong phòng sẽ thay đổi
CREATE TRIGGER TR_XOAMOTNV
ON NHANVIEN
FOR DELETE
AS
	BEGIN
		UPDATE PHONG
		SET SONV = SONV - 1
		WHERE PHONG.MAPHONG = (SELECT MAPHONG FROM DELETED)
	END
DROP TRIGGER TR_XOAMOTNV;
--Vd6: Xóa cùng lúc nhiều nhân viên 
ALTER TRIGGER TR_XOANHIEUNV
ON NHANVIEN
FOR DELETE
AS
	BEGIN
		UPDATE PHONG
		SET SONV = SONV - (SELECT COUNT (*) FROM DELETED WHERE MAPHONG = PHONG.MAPHONG)
		FROM PHONG
		WHERE MAPHONG IN (SELECT MAPHONG FROM DELETED)
	END

DELETE FROM NHANVIEN;
SELECT * FROM NHANVIEN;
SELECT * FROM PHONG;

--VD7: Chuyển cùng lúc nhiều nhân viên ở các phòng khác nhau

ALTER TRIGGER TR_CHUYENNHIEUNV
ON NHANVIEN
FOR UPDATE
AS
	BEGIN
		UPDATE PHONG
		SET SONV = SONV + (SELECT COUNT (*) FROM INSERTED)
		WHERE MAPHONG IN (SELECT MAPHONG FROM INSERTED)

		UPDATE PHONG 
		SET SONV = SONV - (SELECT COUNT (*) FROM DELETED)
		WHERE MAPHONG IN (SELECT MAPHONG FROM DELETED)
	END

UPDATE NHANVIEN
SET MAPHONG = 'P1'
WHERE MANV IN ('NV01')
UPDATE NHANVIEN
SET MAPHONG = 'P2'
WHERE MANV IN ('NV05', 'NV04', 'NV03')

SELECT * FROM NHANVIEN;
SELECT * FROM PHONG;



--FUNCTION
--vd2: Hàm tính tổng 2 số nguyên
CREATE FUNCTION SUM_AB(@A INT, @B INT)
RETURNS INT
AS
	BEGIN
		RETURN @A + @B;
	END

SELECT dbo.SUM_AB(10, 20);

--vd1: Viết hàm tính tổng số nhân viên khi bạn truyền vào mã phòng
CREATE FUNCTION F_TONGSONV(@MAPHONG VARCHAR(10))
RETURNS INT 
AS	
	BEGIN
		DECLARE @SOLUONG INT
		SELECT @SOLUONG = COUNT(*)
		FROM NHANVIEN
		WHERE MAPHONG = @MAPHONG
		RETURN @SOLUONG
	END

SELECT DBO.F_TONGSONV('P1') AS TONGNV;

--vd3: Viết hàm có tên F_NGAYHIENTAI(), thì sẽ xuất hiện ngày tháng năm hiện tại của hệ thống
CREATE FUNCTION F_NGAYHIENTAI()
RETURNS DATE
AS
	BEGIN
		RETURN GETDATE()
	END

SELECT DBO.F_NGAYHIENTAI();

--vd4: Hiển thị thông tin mã phòng, số nv của tất cả các phòng ban có số lượng nhân viên lớn hơn phòng 1

SELECT MAPHONG, COUNT(*) AS SONV
FROM NHANVIEN 
GROUP BY MAPHONG 
HAVING COUNT(*) > (DBO.F_TONGSONV('P2'))

--HAM CHO KET QUA LA BANG TABLE
--vd: Tạo 1 hàm trả kết quả về là 1 table NHANVIEN gồm MANV, TENNV
CREATE FUNCTION F_TABLE_NV (@MAPHONG VARCHAR(10))
RETURNS @KETQUA TABLE(MANV CHAR(10), TENNV NVARCHAR(40))
AS
	BEGIN
		INSERT INTO @KETQUA
		SELECT MANV, TENNV FROM NHANVIEN WHERE MAPHONG = @MAPHONG
		RETURN;
	END

SELECT * FROM DBO.F_TABLE_NV('P1');

--CAC HAM NGAY THANG NAM THONG DUNG

--1. DATEPART(DATEPART, DATE)
SELECT DATEPART(YY, GETDATE()) AS 'NAM';
SELECT DATEPART(DD, GETDATE()) AS 'NGAY';
SELECT DATEPART(MM, GETDATE()) AS 'THANG';
SELECT DATEPART(DW, GETDATE()) AS 'THU';
SELECT DATEPART(QQ, GETDATE()) AS 'QUY';
SELECT DATEPART(DY, GETDATE()) AS 'NGAY CUA NAM';
SELECT DATEPART(WW, GETDATE()) AS 'TUAN CUA NAM';


--2. DATEDIFF(DATEPART, START DATE, END DATE) tra ve so ngay va thoi gian da qua

-- Con bao nhieu thang nua den ngay 2-9
SELECT DATEDIFF(MM, GETDATE(), '2024-09-02') AS 'SO THANG';
-- Con bao nhieu tuan nua den ngay 2-9
SELECT DATEDIFF(DD, GETDATE(), '2024-09-02') AS 'SO THANG';

--Nhap ngay cho ra thu
SELECT DATENAME(DW, '2024-01-29')

--BAITAP
--1. Viet ham tra ve so ngay cua thang, nam do nguoi su dung truyen vao
CREATE FUNCTION F_SONGAYCUATHANG(@THANG INT, @NAM INT)
RETURNS INT
AS 
	BEGIN
		DECLARE @SONGAY INT
		SET @SONGAY = CASE
		WHEN @THANG IN (1, 3, 5, 7, 8, 10, 12) 
			THEN 31
		WHEN @THANG IN (4, 6, 9, 11) 
			THEN 30
		WHEN (@NAM % 4 = 0 AND @NAM % 100 <> 0) AND @THANG = 2
			THEN 29
		ELSE 28
		END
		RETURN @SONGAY
	END

SELECT DBO.F_SONGAYCUATHANG(2, 2024);
--2. Viet ham xac dinh thu trong tuan khi truyen vao ngay
ALTER FUNCTION F_THUCUANGAY(@NGAY DATE)
RETURNS NVARCHAR(20)
AS 
	BEGIN
		DECLARE @THU NVARCHAR(20)
		SET @THU = CASE
		WHEN DATENAME(DW, @NGAY) = 'Monday'
			THEN N'Thứ hai'
		WHEN DATENAME(DW, @NGAY) = 'Tuesday'
			THEN N'Thứ ba'
		WHEN DATENAME(DW, @NGAY) = 'Wednesday'
			THEN N'Thứ tư'
		WHEN DATENAME(DW, @NGAY) = 'Thursday'
			THEN N'Thứ năm'
		WHEN DATENAME(DW, @NGAY) = 'Friday'
			THEN N'Thứ sáu'
		WHEN DATENAME(DW, @NGAY) = 'Saturday'
			THEN N'Thứ bảy'
		ELSE	
			N'Chủ nhật'
		END
		RETURN @THU
	END


SELECT DBO.F_THUCUANGAY('2024-06-19');