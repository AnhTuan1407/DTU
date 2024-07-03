create database qlnv_280524;
use qlnv_280524;

create table phong 
( MaPhong char(10),
  TenPhong nvarchar(50) not null,
  Diadiem nvarchar(100), 
  SoNV int,
  constraint pk_MaPhong primary key(MaPhong),
  constraint ch_SoNV check(SoNV >= 0)
);

create table duan 
( MaDuan char(10),
  TenDuan nvarchar(100) not null,
  KinhPhi float, 
  constraint pk_MaDuan primary key(MaDuan),
  constraint ch_KinhPhi check(KinhPhi >= 0)
);

create table nhanvien 
( MaNV char(10),
  HoLot nvarchar(50) not null,
  TenNV nvarchar(50) not null,
  SDT varchar(10),
  MaPhong char(10),
  constraint pk_MaNV primary key(MaNV),
  constraint fk_MaPhong foreign key(MaPhong) references phong(MaPhong)
);

create table NV_DA 
( MaNV char(10),
  MaDuan char(10),
  Sogio float,
  constraint fk_MaNV foreign key(MaNV) references nhanvien(MaNV),
  constraint fk_MaDuan foreign key(MaDuan) references duan(MaDuan),
  constraint ch_Sogio check(Sogio >= 0)
);
/* Thêm trường địa chỉ vào bảng nhân viên */
alter table nhanvien
add diachi nvarchar(100);

/*2. Xóa trường địa chỉ của bảng nhân viên */
alter table nhanvien
drop column diachi;

/*3. Thêm 1 trường giới tính và cso ràng buộc miền giá trị "Nam, Nữ, Khác" */
Alter table nhanvien
add gioitinh nvarchar(5);

/*4. Thêm ràng buộc */
alter table nhanvien;

INSERT INTO phong
VALUES ('P1', N'PHÒNG TỔ CHỨC', N'ĐÀ NẴNG', 0);
INSERT INTO phong
VALUES ('P2', N'PHÒNG IT', N'ĐÀ NẴNG', 0);
INSERT INTO phong
VALUES ('P3', N'PHÒNG KẾ TOÁN', N'ĐÀ NẴNG', 0);
SELECT * FROM PHONG;


INSERT INTO nhanvien
VALUES ('NV01', N'Nguyễn Văn', N'A', N'0987324561', N'P1'),
('NV02', N'Nguyễn Văn', N'B', N'0987324561', N'P1'),
('NV03', N'Phạm Thị', N'C', N'0987324561', N'P3'),
('NV04', N'Nguyễn Anh', N'D', N'0987324561', N'P2'),
('NV05', N'Nguyễn Thị', N'E', N'0987324561', N'P2');

SELECT * FROM nhanvien;

INSERT INTO duan
VALUES ('DA01', N'Đầu tư chứng khoáng', 10000),
('DA02', N'Phát triển website bán hàng tự động', 150000),
('DA03', N'Phát triển trí tuệ nhân tạo có cảm súc', 300000);
SELECT * FROM duan;

CREATE TABLE luunvp1(
MaNV char(10),
TenNV nvarchar(100),
MaPhong char(10),
constraint pk_MaNV1 primary key (MaNV)
);

INSERT INTO luunvp1
SELECT MaNV, TenNV, MaPhong
FROM nhanvien
WHERE MaPhong = 'P1';

SELECT * FROM luunvp1;

/* Cập nhật dữ liệu*/
/* 
	Update <Table>
	Set <Tên trường> = <Giá trị>
	[Where <điều kiện>]
	[From <Tên Bảng>];
*/

/* vd1: cập nhật địa điểm là Hội An cho phòng1 */
UPDATE phong
SET DiaDiem = N'Hội An'
WHERE MaPhong = 'P1';

-- Xóa dữ liệu
-- DELETE FROM <table>
-- [WHERE <Điều kiện>]

INSERT INTO NV_DA
VALUES ('NV01', N'DA01', 10000),
('NV02', N'DA01', 150000),
('NV01', N'DA03', 300000);


SELECT DISTINCT MaNV
FROM NV_DA;

SELECT * FROM NHANVIEN 
WHERE HOLOT like 'Nguyễn%';

SELECT MANV, TENNV, A.MAPHONG, TENPHONG
FROM NHANVIEN A, PHONG B;

SELECT MANV, TENNV, A.MAPHONG, TENPHONG
FROM NHANVIEN A, PHONG B 
WHERE A.MAPHONG = B.MAPHONG;


SELECT nvda.MANV, nv.TENNV, nvda.MADUAN, da.TENDUAN
FROM NV_DA nvda, NHANVIEN nv, DUAN da
WHERE nvda.MANV = nv.MANV && nvda.MADUAN = da.MADUAN;
