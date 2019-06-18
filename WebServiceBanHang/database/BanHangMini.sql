CREATE DATABASE BanHangMini
GO

USE BanHangMini
GO

CREATE TABLE LoaiSanPham
(
MaLoaiSanPham int PRIMARY KEY IDENTITY(1,1),
TenLoaiSanPham nvarchar(50),
HinhLoaiSanPham image
)
GO

CREATE TABLE SanPham
(
MaSanPham int PRIMARY KEY IDENTITY(1,1),
TenSanPham nvarchar(50),
GiaSanPham int,
HinhSanPham image,
MoTa nvarchar(50),
MaLoaiSanPham int FOREIGN KEY REFERENCES dbo.LoaiSanPham(MaLoaiSanPham)
)
GO


SELECT *
FROM dbo.SanPham
GO


INSERT INTO dbo.SanPham
        ( TenSanPham ,
          GiaSanPham ,
          HinhSanPham ,
          MoTa ,
          MaLoaiSanPham
        )
VALUES  ( N'Xiao mi' , -- TenSanPham - nvarchar(50)
          4500000 , -- GiaSanPham - int
          NULL , -- HinhSanPham - image
          N'Hàng mới nhập khẩu' , -- MoTa - nvarchar(50)
          1  -- MaLoaiSanPham - int
        )
GO

SELECT * FROM dbo.SanPham
GO

GO

SELECT *
FROM dbo.LoaiSanPham
GO



UPDATE dbo.SanPham
SET LinkHinhSanPham = 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQgkSviEwZbW35nmXWmF9kgHE_fkLJXIcj9-isEQVVkcOvMwUvi'
WHERE MaSanPham = 50
UPDATE dbo.SanPham
SET LinkHinhSanPham = 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxZu40TF5R4pcuAdayDeGcDSab9ZzpcpG5RWuT59-Ec5kLaVub'
WHERE MaSanPham = 51
UPDATE dbo.SanPham
SET LinkHinhSanPham = 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRI3D_HzmR-RBlm1n3j52ESXNAGEf8cTG2bNy-nqucPrV7ngyWy_g'
WHERE MaSanPham = 53
GO

CREATE TABLE TaiKhoan
(
MaTaiKhoan int PRIMARY KEY IDENTITY(1,1),
TenTaiKhoan varchar(50),
MatKhau varchar(20)
)
GO


SELECT *
FROM dbo.TaiKhoan
GO



