CREATE TABLE NhaXuatBan (
    MaXB NVARCHAR(10) PRIMARY KEY,     -- Mã nhà xuất bản (khóa chính)
    TenXB NVARCHAR(100) NOT NULL,      -- Tên nhà xuất bản
    DiaChi NVARCHAR(200)               -- Địa chỉ
);
GO
