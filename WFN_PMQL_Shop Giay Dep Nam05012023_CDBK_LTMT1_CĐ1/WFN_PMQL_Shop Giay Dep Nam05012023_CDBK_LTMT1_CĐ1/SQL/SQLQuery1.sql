-- Xóa bảng cũ
IF OBJECT_ID(N'Sản_Phẩm', 'U') IS NOT NULL  
   DROP TABLE Sản_Phẩm;  
GO

-- Tạo bảng mới
CREATE TABLE Sản_Phẩm
(
	Mã_Sản_Phẩm  INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Tên_Sản_Phẩm nTEXT, -- NVARCHAR(150), -- Unicode Varchar không hay bằng Unicode Text
	Năm_Sản_Xuất INT,
	Đơn_Giá      FLOAT,
	Mã_Màu       CHAR, -- 'R', 'G', 'B', 'Y'
	BIT_Kho_Hàng BIT, -- 1=Còn hàng, 0=Hết hàng
	Kho_Hàng     nTEXT, -- NVARCHAR(32),
	Ảnh          nTEXT, -- VARCHAR(255),
)
GO

-- Thêm mới các dòng bản ghi dữ liệu vào bảng
INSERT INTO Sản_Phẩm(Tên_Sản_Phẩm,Năm_Sản_Xuất,Đơn_Giá, Mã_Màu, BIT_Kho_Hàng, Kho_Hàng, Ảnh) 
VALUES
('iPhone',      2022, 1.9, 'R', 1, N'Còn', 'images\no-image.jpg'),
('iPad',        2020, 1.7, 'G', 0, N'Hết', 'images\no-image.jpg'),
('iMac',        2018, 8.9, 'B', 1, N'Còn', 'images\no-image.jpg'),
('iWatch',      2022, 1.6, 'R', 1, N'Còn', 'images\no-image.jpg'),
('iPhone Pro',  2022, 1.6, 'G', 1, N'Còn', 'images\no-image.jpg'),
('MacBook Pro', 2021, 9.7, 'G', 1, N'Còn', 'images\no-image.jpg'),
('Mac Studio',  2022, 1.6, 'B', 0, N'Hết', 'images\no-image.jpg')
GO

IF OBJECT_ID(N'Số_Sản_Phẩm_theo_Mã_Màu','V') IS NOT NULL
DROP VIEW Số_Sản_Phẩm_theo_Mã_Màu;
GO

-- Tạo View: bảng tạm chứa dữ liệu thống kê/phân loại cho việc vẽ biểu đồ bánh
CREATE VIEW Số_Sản_Phẩm_theo_Mã_Màu AS
SELECT
	COUNT(Mã_Sản_Phẩm) AS Số_Sản_Phẩm,
	Mã_Màu
FROM
	Sản_Phẩm
GROUP BY
	Mã_Màu
GO