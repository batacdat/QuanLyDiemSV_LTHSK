create database BTL_QuanLyDiemSinhVien

use BTL_QuanLyDiemSinhVien
go

CREATE TABLE tblKhoa (
    sMaKhoa varchar(20) PRIMARY KEY not null,
    sTenKhoa NVARCHAR(50),
    sSDT varchar(12),
    sDiaChiKhoa nvarchar(50)
);

CREATE TABLE tblLop (
    sMaLop varchar(20) PRIMARY KEY not null,
    sTenLop NVARCHAR(50),
    sMaKhoa varchar(20)
);

ALTER TABLE tblLop
ADD CONSTRAINT FK_Khoa FOREIGN KEY (sMaKhoa) REFERENCES tblKhoa(sMaKhoa);

CREATE TABLE tblSinhVien (
    sMaSV varchar(20) PRIMARY KEY not null,
    sTenSV NVARCHAR(50),
    sGioiTinh nvarchar(10),
    sQueQuan NVarchar(30),
    dNgaySinh date,
	sUserName varchar(15),
	sPassWord varchar(15),
	sMaLop varchar(20)
);

ALTER TABLE tblSinhVien
ADD CONSTRAINT FK_Lop FOREIGN KEY (sMaLop) REFERENCES tblLop(sMaLop);
-- Tạo bảng Môn học
CREATE TABLE tblMonHoc (
	sMaMH Varchar(20) PRIMARY KEY NOT NULL,
	sTenMH NVarchar(20) NOT NULL,
	iSoTC int
	)

ALTER TABLE tblMonHoc
ALTER COLUMN sTenMH NVARCHAR(50) NOT NULL;

CREATE TABLE tblDiemHP (
    sMaSV varchar(20),
    sMaMH varchar(20),
    sHocKy NVARCHAR(10),
    sNamHoc NVARCHAR(10),
    fDiemCC FLOAT,
    fDiemGK FLOAT,
    fDiemCK FLOAT,
   
    PRIMARY KEY (sMaSV, sMaMH, sHocKy, sNamHoc),
    FOREIGN KEY (sMaSV) REFERENCES tblSinhVien(sMaSV),
    FOREIGN KEY (sMaMH) REFERENCES tblMonHoc(sMaMH)
    
);

CREATE TABLE tblGiangVien (
    sMaGV varchar(20) PRIMARY KEY not null,
    sTenGV NVARCHAR(50),
    sSDT VARCHAR(12),
    sBangCap NVARCHAR(50),
    sUserName varchar(10) not null,
    sPassWord varchar(10)
);

ALTER TABLE tblDiemHP
ADD sMaGV varchar(20);

ALTER TABLE tblDiemHP
ADD CONSTRAINT FK_GiangVien FOREIGN KEY (sMaGV) REFERENCES tblGiangVien(sMaGV);

INSERT INTO tblKhoa (sMaKhoa, sTenKhoa, sSDT, sDiaChiKhoa)
VALUES 
('K01', N'Khoa Công nghệ Thông tin', '0123456789', N'Hà Nội'),
('K02', N'Khoa Điện tử Viễn thông', '0987654321', N'Hà Nội'),
('K03', N'Khoa Cơ khí', '0934567890', N'Hà Nội');

INSERT INTO tblLop (sMaLop, sTenLop, sMaKhoa)
VALUES 
('L01', N'Lớp Công nghệ Thông tin 1', 'K01'),
('L02', N'Lớp Điện tử Viễn thông 1', 'K02'),
('L03', N'Lớp Cơ khí 1', 'K03');

INSERT INTO tblSinhVien (sMaSV, sTenSV, sGioiTinh, sQueQuan, dNgaySinh, sUserName, sPassWord, sMaLop)
VALUES 
('SV01', N'Nguyễn Văn An', N'Nam', N'Hà Nội', '2000-01-01', 'user1', 'pass1', 'L01'),
('SV02', N'Trần Thị Bình', N'Nữ', N'Hồ Chí Minh', '2000-02-02', 'user2', 'pass2', 'L02'),
('SV03', N'Phạm Văn Chung', N'Nam', N'Đà Nẵng', '2000-03-03', 'user3', 'pass3', 'L03');

INSERT INTO tblMonHoc (sMaMH, sTenMH, iSoTC)
VALUES 
('MH01', N'Lập trình Cơ bản', 3),
('MH02', N'Toán rời rạc', 4),
('MH03', N'Mạng máy tính', 4);

INSERT INTO tblDiemHP (sMaSV, sMaMH, sHocKy, sNamHoc, fDiemCC, fDiemGK, fDiemCK)
VALUES 
('SV01', 'MH01', N'HK1', N'2023-2024', 8.0, 7.5, 8.5),
('SV02', 'MH02', N'HK1', N'2023-2024', 7.0, 7.0, 7.5 ),
('SV03', 'MH03', N'HK1', N'2023-2024', 6.0, 7.5, 8.0);

INSERT INTO tblGiangVien (sMaGV, sTenGV, sSDT, sBangCap, sUserName, sPassWord)
VALUES 
('GV01', N'Nguyễn Văn Trình', '0123456789', N'Thạc sĩ', 'GV01', 'pass01'),
('GV02', N'Trần Thị Bắc', '0987654321', N'Tiến sĩ', 'GV02', 'pass02'),
('GV03', N'Phạm Văn Chiến', '0934567890', N'Thạc sĩ', 'GV03', 'pass03'),
('GV04', N'Lê Thị Doan', '0912345678', N'Cử nhân', 'GV04', 'pass04'),
('GV05', N'Hoàng Văn Minh', '0976543210', N'Tiến sĩ', 'GV05', 'pass05');

UPDATE tblDiemHP
SET sMaGV = 'GV01'
WHERE sMaSV = 'SV01' AND sMaMH = 'MH01' AND sHocKy = N'HK1' AND sNamHoc = N'2023-2024';

UPDATE tblDiemHP
SET sMaGV = 'GV02'
WHERE sMaSV = 'SV02' AND sMaMH = 'MH02' AND sHocKy = N'HK1' AND sNamHoc = N'2023-2024';

UPDATE tblDiemHP
SET sMaGV = 'GV03'
WHERE sMaSV = 'SV03' AND sMaMH = 'MH03' AND sHocKy = N'HK1' AND sNamHoc = N'2023-2024';
--Luật kinh tế
select * from tblSinhVien
select * from tblGiangVien
select * from tblMonHoc
select * from tblDiemHP
select * from tblKhoa










