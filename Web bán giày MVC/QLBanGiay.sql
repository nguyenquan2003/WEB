CREATE DATABASE QLWEBGIAY;
GO
USE QLWEBGIAY;
GO

CREATE TABLE loaiSanPham
(
    maLoaiSP INT IDENTITY(1,1) NOT NULL,
    tenLoaiSP NVARCHAR(50) UNIQUE,
    CONSTRAINT Pk_loaiSanPham PRIMARY KEY (maLoaiSP)
);

CREATE TABLE sanPham
(
    maSanPham INT IDENTITY(1,1) NOT NULL,
    tenSanPham NVARCHAR(100) NULL UNIQUE,
    ngaySanXuat DATE NULL,
    soLuongSanPham INT NULL,
    maLoaiSP INT,
    gia FLOAT NULL,
    chuThichSanPham NVARCHAR(MAX) NULL,
    hinhAnh NVARCHAR(MAX),
    hinh1 NVARCHAR(MAX),
    hinh2 NVARCHAR(MAX),
    hinh3 NVARCHAR(MAX),
    hinh4 NVARCHAR(MAX),
    CONSTRAINT Pk_sanPham PRIMARY KEY (maSanPham)
); 

CREATE TABLE donHang
(
    maDon INT IDENTITY(1,1) NOT NULL,
    ngayDat DATETIME NULL,
    tinhTrang INT NULL,
    maNguoiDung INT,
    thanhToan FLOAT NULL,
    diaChiNhanHang NVARCHAR(MAX),
    tongTien INT NULL,
    CONSTRAINT Pk_donhang PRIMARY KEY (maDon)
);

CREATE TABLE chiTietDonHang
(
    maDon INT NOT NULL,
    maSanPham INT NOT NULL,
    soLuong INT NULL,
    donGia FLOAT NULL,
    thanhTien FLOAT NULL,
    phuongThucThanhToan INT NULL,
    CONSTRAINT PK_chiTietDonHang PRIMARY KEY (maDon, maSanPham)
);

CREATE TABLE nguoiDung
(
    maNguoiDung INT IDENTITY(1,1) NOT NULL,
    tenNguoiDung NVARCHAR(50) NOT NULL,
    matKhau VARCHAR(50) NOT NULL,
    eMail NVARCHAR(50) NOT NULL UNIQUE,
    dienThoai NCHAR(10) NULL UNIQUE,
    IdQuyen INT NULL,
    diaChi NVARCHAR(MAX) NULL,
    CONSTRAINT Pk_nguoiDung PRIMARY KEY (maNguoiDung)
);


CREATE TABLE phanQuyen
(
    IdQuyen INT IDENTITY(1,1) NOT NULL,
    tenQuyen NVARCHAR(20) UNIQUE,
    CONSTRAINT Pk_phanQuyen PRIMARY KEY (IdQuyen)
);

ALTER TABLE sanPham
ADD CONSTRAINT Fk_Sp_Loai FOREIGN KEY (maLoaiSP) REFERENCES loaiSanPham (maLoaiSP);

ALTER TABLE donHang
ADD CONSTRAINT Fk_Dh_Nd FOREIGN KEY (maNguoiDung) REFERENCES nguoiDung (maNguoiDung);

ALTER TABLE nguoiDung
ADD CONSTRAINT Fk_Tk_Id FOREIGN KEY (IdQuyen) REFERENCES phanQuyen (IdQuyen);

ALTER TABLE chiTietDonHang
ADD CONSTRAINT Fk_ChiTiet_Dh FOREIGN KEY (maDon) REFERENCES donHang (maDon),
    CONSTRAINT Fk_ChiTiet_Sp FOREIGN KEY (maSanPham) REFERENCES sanPham (maSanPham);


INSERT INTO phanQuyen 
VALUES 
(N'Admin'),
(N'User');
GO

INSERT INTO nguoiDung 
VALUES 
(N'Nguyễn Ngoc Bảo', N'12345678', N'Admin@gmail.com', N'0398482660', 1, N'Bình dương'),
(N'Tran Van An', N'12345678', N'user1@gmail.com', N'0324896547', 2, N'Ha Long'),
(N'Le Thi Giang', N'12345678', N'user2@gmail.com', N'0987654321', 2, N'Nha Trang'),
(N'Nguyen Van Tuan', N'12345678', N'user3@gmail.com', N'0912345679', 2, N'Ho Chi Minh'),
(N'Tran Thi Binh', N'12345678', N'user4@gmail.com', N'0987654322', 2, N'Hanoi'),
(N'Le Van Canh', N'password789', N'canh@gmail.com', N'0865432109', 2, N'Da Nang');
GO
 
INSERT INTO loaiSanPham
VALUES
(N'Giày'),
(N'Giày da'),
(N'Giày cổ cao'),
(N'Giày lười');
GO

SET DATEFORMAT DMY
INSERT INTO sanPham
VALUES
(N'Vintas Nauda Ext','2022-1-15',14,1,550800, NULL,'ha0001.jpg','ha0001_1.jpg','ha0001_2.jpg','ha0001_3.jpg','ha0001_4.jpg'),
(N'VINTAS NAUDA EXT - LOW TOP - MONKS ROBE','2022-4-11',20,1,650000, null,'ha0005.jpg','ha0005_1.jpg','ha0005_2.jpg','ha0005_3.jpg','ha0005_4.jpg'),
(N'URBAS RETROSPECTIVE - LOW TOP - POPULAR BLUE','2022-4-11',20,1,650000, N'Với việc đưa những chiếc đế cao su "xuyên thấu" rực rỡ trở lại, kết hợp cùng phần upper bằng vải canvas với những màu sắc tươi rói, Urbas Retrospective đã khắc họa nên bức tranh đầy sinh động về một thời kỳ phát triển rực rỡ của thời trang và nghệ thuật của những thập kỉ trước. Đây chắc chắn sẽ là lựa chọn không thể thiếu trong tủ đồ đối với những bạn trẻ đang tìm kiếm nguồn cảm hứng cổ điển trong phong cách thời trang hiện đại và độc đáo của bản thân.','ha0006.jpg','ha0006_1.jpg','ha0006_2.jpg','ha0006_3.jpg','ha0006_4.jpg'),
(N'ANANAS X DORAEMON 50 YEARS PATTAS - WHITE/CORYDALIS 50TH','2022-4-11',20,1,890000, N'Ananas x Doraemon 50 Years Pattas thể hiện chân thật nét vẽ nguyên bản của bộ truyện từ cái nhìn đầu tiên. Sử dụng chất liệu Action Leather (da) phủ khắp thân giày, pha trộn cùng các chi tiết đắt giá được sắp đặt hợp lí. Ra mắt với số lượng đặc biệt giới hạn, phiên bản này phát hành với mục đích kỉ niệm, tôn vinh giá trị mà bộ truyện Doraemon đã mang lại suốt 50 năm qua.','ha00016.jpg','ha00016_1.jpg','ha00016_2.jpg','ha00016_3.jpg','ha00016_4.jpg'),
(N'TRACK 6 I.S.E.E - PURE WHITE/ICY BLUE','2022-4-11',20,1,1490000, N'Ananas x Doraemon 50 Years Pattas thể hiện chân thật nét vẽ nguyên bản của bộ truyện từ cái nhìn đầu tiên. Sử dụng chất liệu Action Leather (da) phủ khắp thân giày, pha trộn cùng các chi tiết đắt giá được sắp đặt hợp lí. Ra mắt với số lượng đặc biệt giới hạn, phiên bản này phát hành với mục đích kỉ niệm, tôn vinh giá trị mà bộ truyện Doraemon đã mang lại suốt 50 năm qua.','ha00017.jpg','ha00017_1.jpg','ha00017_2.jpg','ha00017_3.jpg','ha00017_4.jpg'),
(N'URBAS SC - LOW TOP - FOLIAGE','2022-4-11',20,1,580000, null,'ha00011.jpg','ha00011_1.jpg','ha00011_2.jpg','ha00011_3.jpg','ha00011_4.jpg'),

(N'TRACK 6 2.BLUES - LOW TOP - BLUEWASH','2022-4-11',20,2,1390000, null,'ha00019.jpg','ha00019_1.jpg','ha00019_2.jpg','ha00019_3.jpg','ha00019_4.jpg'),
(N'TRACK 6 CLASS E - LOW TOP - CRAFTSMAN BLUE','2022-4-11',20,2,1190000, N'Track 6 Class E (Essential, Enthusiasm) là bộ sản phẩm mang trên mình những yếu tố cơ bản trong cuộc sống thường ngày. Được sử dụng những chất liệu thường có trên những đôi giày cao cấp với da Nappa nhẵn bóng, lưới mesh nhỏ mịn kết hợp Suede (da lộn) phủ màu tạo nên tổng thể vừa tinh tế, với màu sắc nhã nhặn. Điểm nhấn thú vị trên chi tiết màu “Craftsman Blue” thể hiện một phần yếu tố cần thiết, đại diện cho niềm đam mê chế tác của con người với những thú vui gắn cùng thiên nhiên. Track 6 Class E - Craftsman Blue xứng đáng là một must-have item đối với những ai yêu thích sáng tạo và mong muốn thể hiện cá tính độc lập.','ha00020.jpg','ha00020_1.jpg','ha00020_2.jpg','ha00020_3.jpg','ha00020_4.jpg'),
(N'VINTAS MISTER - LOW TOP - NARCISSUEDE','2022-4-11',20,2,580000, 'Dáng Low Top truyền thống, kết hợp cùng phối màu gợi nét cổ điển, xưa cũ với chất liệu da Suede. Một sự lựa chọn của những ai muốn làm nổi bật lên sự chín chắn, tính điềm đạm cùng nét lịch thiệp cho bộ outfit của mình.','ha00014.jpg','ha00014_1.jpg','ha00014_2.jpg','ha00014_3.jpg','ha00014_4.jpg'),
(N'TRACK 6 TRIPLE BLACK - LOW TOP - BLACK','2022-4-11',20,2,990000, N'Với cảm hứng từ Retro Sneakers và âm nhạc giai đoạn 1970s, Ananas Track 6 ra đời với danh hiệu là mẫu giày Cold Cement đầu tiên của Ananas - một thương hiệu giày Vulcanized. Chất liệu Storm Leather đáng giá "càn quét" toàn bộ bề mặt upper cùng những chi tiết thiết kế đặc trưng và mang nhiều ý nghĩa. Chắc rắng, Track 6 sẽ đem đến cho bạn sự tự nhiên thú vị như chính thông điệp bài hát Let it be của huyền thoại The Beatles gửi gắm. Màu all black huyền bí luôn có mặt trong danh sách best seller.','ha00015.jpg','ha00015_1.jpg','ha00015_2.jpg','ha00015_3.jpg','ha00015_4.jpg'),
(N'URBAS CORLURAY MIX','2022-7-15',14,2,500800, NULL,'ha0002.jpg','ha0002_1.jpg','ha0002_2.jpg','ha0002_3.jpg','ha0002_4.jpg'),
(N'TRACK 6 UNNAMED NO.1 IN C MINOR - LOW TOP - BLACK','2022-4-11',20,2,1090000, N'Việc sử dụng phương pháp ứng tấu (improvise) với đề bài sử dụng 5 chất liệu da khác loại, khác màu trên cùng một thiết kế là chìa khoá để tạo nên đôi giày Track 6 không tên số thứ 1 (đầu tiên). Vẻ ngoài toát lên hơi hướng đượm buồn trong màu giọng Đô thứ (Cm), Track 6 Unnamed No.1 in C Minor sẽ thật sự gây bất ngờ cho những ai yêu thích việc tìm thấy sự tích cực trong những giai đoạn nhiều cảm xúc lẫn lộn đan xen.','ha0008.jpg','ha0008_1.jpg','ha0008_2.jpg','ha0008_3.jpg','ha0008_4.jpg'),
(N'TRACK 6 TRIPLE WHITE - LOW TOP - WHITE','2022-4-11',20,2,990000, N'Với cảm hứng từ Retro Sneakers và âm nhạc giai đoạn 1970s, Ananas Track 6 ra đời với danh hiệu là mẫu giày Cold Cement đầu tiên của Ananas - một thương hiệu giày Vulcanized. Chất liệu Storm Leather đáng giá "càn quét" toàn bộ bề mặt upper cùng những chi tiết thiết kế đặc trưng và mang nhiều ý nghĩa. Chắc rằng, Track 6 sẽ đem đến cho bạn sự tự nhiên thú vị như chính thông điệp bài hát Let it be của huyền thoại The Beatles gửi gắm. Màu all white chắc nhiều bạn sẽ thích.','ha00013.jpg','ha00013_1.jpg','ha00013_2.jpg','ha00013_3.jpg','ha00013_4.jpg'),

(N'VINTAS SAIGON 1980S','2023-8-25',20,3,450000, N'Lấy cảm hứng từ các màu sắc đặc trưng của đường phố Sài Gòn những năm 80, Vintas "Saigon 1980s" là BST mang đậm nét đẹp cổ kính, hoài niệm. Với những ai yêu mến nét xưa cũ, trầm mặc, "Saigon 1980s" hứa hẹn sẽ trở thành must-have item cho tủ giày của bạn.
','ha0003.jpg','ha0003_1.jpg','ha0003_2.jpg','ha0003_3.jpg','ha0003_4.jpg'),
(N'BASAS WORKADAY - HIGH TOP - REAL TEAL','2022-4-11',20,3,650000, null, 'ha0007.jpg','ha0007_1.jpg','ha0007_2.jpg','ha0007_3.jpg','ha0007_4.jpg'),
(N'URBAS RETROSPECTIVE - MID TOP - YELLOW SUBMARINE','2022-4-11',20,3,720000, N'Với việc đưa những chiếc đế cao su "xuyên thấu" rực rỡ trở lại, kết hợp cùng phần upper bằng vải canvas với những màu sắc tươi rói, Urbas Retrospective đã khắc họa nên bức tranh đầy sinh động về một thời kỳ phát triển rực rỡ của thời trang và nghệ thuật của những thập kỉ trước. Đây chắc chắn sẽ là lựa chọn không thể thiếu trong tủ đồ đối với những bạn trẻ đang tìm kiếm nguồn cảm hứng cổ điển trong phong cách thời trang hiện đại và độc đáo của bản thân. Sự độc đáo này còn mạnh mẽ hơn trên một form dáng Mid Top hoàn toàn mới.
','ha00012.jpg','ha00012_1.jpg','ha00012_2.jpg','ha00012_3.jpg','ha00012_4.jpg'),
(N'VINTAS SODA POP - HIGH TOP - RED VIOLET','2022-4-11',20,3,720000, N'Ananas x Doraemon 50 Years Pattas thể hiện chân thật nét vẽ nguyên bản của bộ truyện từ cái nhìn đầu tiên. Sử dụng chất liệu Action Leather (da) phủ khắp thân giày, pha trộn cùng các chi tiết đắt giá được sắp đặt hợp lí. Ra mắt với số lượng đặc biệt giới hạn, phiên bản này phát hành với mục đích kỉ niệm, tôn vinh giá trị mà bộ truyện Doraemon đã mang lại suốt 50 năm qua.','ha00018.jpg','ha00018_1.jpg','ha00018_2.jpg','ha00018_3.jpg','ha00018_4.jpg'),



(N'BASAS BUMPER GUM NE','2022-4-11',44,4,239000, N'Đánh dấu một bước trưởng thành nữa, Basas Bumper Gum NE (New Episode) ra đời với những cải tiến nhẹ nhàng nhưng đủ tạo được sự thay đổi trong cảm nhận khi trải nghiệm. Vẫn giữ ngoại hình gần như không thay để phát huy đặc tính ứng dụng cao của dòng Basas vốn đã được chứng minh, phần đế màu Gum thú vị và /Foxing thân/ mới làm nền cho phần chất liệu Upper được nâng cấp. Đây được xem là một trong những phiên bản được chúng tôi kì vọng có thể bền vững vượt qua thời gian và không gian, chắc chắn đáng để thử.','ha0004.jpg','ha0004_1.jpg','ha0004_2.jpg','ha0004_3.jpg','ha0004_4.jpg'),
(N'BASAS HOOK NLOOP NE - MULE - WHITE','2022-4-11',20,4,520000, N'Tiện lợi nhân đôi với quai dán đi cùng thiết kế hở gót độc đáo, Basas Hook’n Loop - Mule chính là đôi giày hoàn hảo cho cuộc sống nhộn nhịp, vội vã của giới trẻ. Phiên bản sở hữu chất liệu được nâng cấp gia tăng độ bền bỉ, cùng 2 lựa chọn màu sắc thân thiện bậc nhất cho mọi dáng hình phong cách. Basas Hook’n Loop - Mule chắc chắn sẽ là điểm nhấn đặc biệt và là một sự bổ sung xứng đáng cho tủ giày/dép của bạn.','ha0009.jpg','ha0009_1.jpg','ha0009_2.jpg','ha0009_3.jpg','ha0009_4.jpg'),
(N'PATTAS TOMO - MULE - PRIMROSE YELLOW','2022-4-11',20,4,720000, null,'ha00010.jpg','ha00010_1.jpg','ha00010_2.jpg','ha00010_3.jpg','ha00010_4.jpg');




SELECT * FROM nguoiDung;
SELECT * FROM phanQuyen;
SELECT * FROM loaiSanPham;
SELECT * FROM sanPham;
SELECT * FROM donHang;
SELECT * FROM chiTietDonHang;

