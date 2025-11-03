-- ==========================
-- 💾 TẠO CƠ SỞ DỮ LIỆU
-- ==========================
IF DB_ID(N'QuanLyBanSach') IS NOT NULL
BEGIN
    PRINT N'Database "QuanLyBanSach" đã tồn tại, xóa để tạo mới...';
    ALTER DATABASE QuanLyBanSach SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QuanLyBanSach;
END
GO

CREATE DATABASE QuanLyBanSach;
GO

USE QuanLyBanSach;
GO

-- ==========================
-- 📘 TẠO BẢNG NhaXuatBan
-- ==========================
IF OBJECT_ID(N'dbo.NhaXuatBan', N'U') IS NOT NULL
BEGIN
    PRINT N'Bảng NhaXuatBan đã tồn tại, xóa để tạo mới...';
    DROP TABLE dbo.NhaXuatBan;
END
GO

CREATE TABLE dbo.NhaXuatBan
(
    MaXB NVARCHAR(10) NOT NULL PRIMARY KEY,   -- Mã nhà xuất bản
    TenXB NVARCHAR(100) NOT NULL,             -- Tên nhà xuất bản
    DiaChi NVARCHAR(200) NULL                 -- Địa chỉ
);
GO

-- ==========================
-- 🧾 THÊM DỮ LIỆU MẪU
-- ==========================
INSERT INTO dbo.NhaXuatBan (MaXB, TenXB, DiaChi)
VALUES 
    (N'NXB1', N'Nhà xuất bản Trẻ', N'TP. Hồ Chí Minh'),
    (N'NXB2', N'Nhà xuất bản Giáo Dục', N'Hà Nội'),
    (N'NXB3', N'Nhà xuất bản Văn Hóa', N'Đà Nẵng');
GO

-- ==========================
-- 🔍 KIỂM TRA DỮ LIỆU
-- ==========================
SELECT * FROM dbo.NhaXuatBan;
GO
