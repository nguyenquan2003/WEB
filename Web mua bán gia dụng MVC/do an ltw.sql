USE MASTER
drop database QL_DGD
CREATE DATABASE QL_DGD

USE QL_DGD

CREATE TABLE QuanLy(
	MaQuanLy int not null primary key,
	TaiKhoan char(50) null,
	MatKhau int null,
	
)
CREATE TABLE KhachHang(
	MaKhachHang char(10) not null primary key,
	HoTen nvarchar(50) null,
	NgaySinh datetime null,
	GioiTinh nvarchar(5) null,
	DienThoai varchar(50) null,
	TaiKhoan varchar(50) null,
	MatKhau nvarchar(50) null,
	Email varchar(50) null,
	DiaChi nvarchar(max) null,
	
)
CREATE TABLE DonHang(
	MaDonHang int not null primary key,
	NgayGiao datetime null,
	NgayDat datetime null,
	DaThanhToan nvarchar(50) null,
	TinhTrangGiaoHang nvarchar (100) null,
	MaKhachHang char(10) null,
	MaQuanLy int null,
	CONSTRAINT FK_DonHang_QuanLy FOREIGN KEY (MaQuanLy) REFERENCES QuanLy(MaQuanLy),
	CONSTRAINT FK_DonHang_KhachHang FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
)
CREATE TABLE NhaSanXuat(
	MaNSX char(10) not null primary key,
	TenNSX nvarchar(50) null,
	DiaChi nvarchar(max) null,
	DienThoai varchar(50) null,
)
CREATE TABLE LoaiHang(
	MaLoai char(10) not null primary key,
	TenLoai nvarchar (max) null
	
)
CREATE TABLE SanPham(
	MaSanPham int not null primary key,
	TenSanPham nvarchar(100) null,
	GiaBan int,
	MoTa nvarchar (max) null,
	NgaySanXuat datetime null,
	AnhBia nvarchar (max) null,
	SoLuongTon int,
	MaNSX char(10) null,
	MaLoai char(10) null,
	CONSTRAINT FK_SanPham_LoaiHang FOREIGN KEY (MaLoai) REFERENCES LoaiHang(MaLoai),
	CONSTRAINT FK_SanPham_NhaSanXuat FOREIGN KEY (MaNSX) REFERENCES NhaSanXuat(MaNSX)
)
CREATE TABLE ChiTietDonHang(	
	MaDonHang int not null ,
	MaSanPham int not null ,
	SoLuong int null,
	DonGia int null,
	primary key(MaDonHang,MaSanPham),
	CONSTRAINT FK_ChiTietDonHang_DonHang FOREIGN KEY (MaDonHang) REFERENCES DonHang(MaDonHang),
	CONSTRAINT FK_ChiTietDonHang_SanPham FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham),
)

INSERT INTO QuanLy(MaQuanLy,TaiKhoan,MatKhau)
VALUES
(1,'duongvankhuong',123);


INSERT INTO KhachHang(MaKhachHang,HoTen,NgaySinh,GioiTinh,DienThoai,TaiKhoan,MatKhau,Email,DiaChi)
VALUES
('KH001',N'Dương Vạn Khương','2003-10-14',N'Nam','0356094197','Duongvankhuong','duongvankhuong','DuongVanKhuong197@gmail.com',N'Sóc Trăng'),
('KH002',N'Nguyễn Thị Thu Thảo','2002-7-10',N'Nữ','035568741','Nguyenthithuthao','nguyenthithuthao','Hanam2002@gmail.com',N'Lâm Đồng'),
('KH003',N'Trần Lệ Quyên','1995-01-21',N'Nữ','0981149744','Tranlequyen','tranlequyen','Lequyen1017@gmail.com',N'Tây Ninh'),
('KH004',N'Lê Cẩm Tú','1983-02-13',N'Nữ','0986374097','Camtu','tu123456789','Camtu1983@gmail.com',N'Bình Thuận'),
('KH005',N'Trương Thế Sang','1993-04-04',N'Nam','0356094114','Truongthesang','truongthesang','Thesang93@gmail.com',N'Bình Dương'),
('KH006',N'Đậu Quang Ánh','1994-12-03',N'Nam','0359665489','Anhquang','anhquang123','Anhquang197@gmail.com',N'Long An'),
('KH007',N'Phạm Quang Hậu','1995-10-12',N'Nam','0357412589','Phamquanghau','quanghau113','phamquanghau113@gmail.com',N'Tây Ninh'),
('KH008',N'Huỳnh Kim Chi','1996-10-18',N'Nữ','0356094197','Huynhkimchi','huynhkimchi','kichikichi@gmail.com',N'TP.Hồ Chí Minh');

INSERT INTO DonHang(MaDonHang,NgayGiao,NgayDat,DaThanhToan,TinhTrangGiaoHang,MaKhachHang,MaQuanLy)
VALUES
(001,'2023-07-15','2023-07-11',N'Rồi','Đã giao','KH001',1),
(002,'2023-07-17','2023-07-11',null,null,'KH005',1),
(003,'2023-07-15','2023-07-11',null,null,'KH004',1),
(004,'2023-08-15','2023-07-01',null,null,'KH003',1),
(005,'2023-07-10','2023-07-03',N'Rồi','Đã giao','KH008',1),
(006,'2023-06-01','2023-05-20',null,null,'KH002',1),
(007,'2023-07-13','2023-07-11',N'Rồi','Đã giao','KH007',1),
(008,'2023-07-01','2023-06-11',N'Rồi',null,'KH006',1);

INSERT INTO NhaSanXuat(MaNSX,TenNSX,DiaChi,DienThoai)
VALUES
('CRYSTAL',N'Crystal',N'128 Trần Quang Khải, P.Tân Định, Q.1, TP.Hồ Chí Minh','18001061'),
('DQUANG',N'Điện Quang',N'5D Cù Chính Lan, P.12, Tân Bình, TP.Hồ Chí Minh','18001063'),
('KANGAR',N'Kangaroo',N'214 Nguyễn Oanh, P.14, Gò Vấp, TP.Hồ Chí Minh','18001065'),
('DELITES',N'Delites',N'75 Phú Thọ, P.1, Q.11, TP.Hồ Chí Minh','18001088'),
('BLUES',N'BlueStone',N'123 Đường 28, P.6, Gò Vấp, TP.Hồ Chí Minh','18001999');


INSERT INTO LoaiHang(MaLoai,TenLoai)
VALUES
('BD',N'Bình đun'),
('HN',N'Bếp hồng ngoại'),
('NC',N'Nồi chiên'),
('ML',N'Máy lọc nước'),
('NR',N'Nồi cơm'),
('BT',N'Bếp từ'),
('BL',N'Bếp lẩu'),
('BU',N'Bàn ủi'),
('LN',N'Lò nướng'),
('MS',N'Máy sấy');




INSERT INTO SanPham(MaSanPham,TenSanPham,GiaBan,MoTa,NgaySanXuat,AnhBia,SoLuongTon,MaNSX,MaLoai)
VALUES
(001,N'Bình đun siêu tốc',170000,N'Bình đun siêu tốc Điện Quang 1.8 lít ĐQ EKT06 1518 BL có kiểu dáng đơn giản, gọn đẹp, ruột bình làm từ inox 201 với công suất 1500W hoạt động ổn định, cùng với nhiều tiện ích và chế độ an toàn.','2023-01-15',N'0001.jpg',10,'CRYSTAL','BD'),
(002,N'Bếp hồng ngoại',55000,N'Thiết kế bếp hồng ngoại đơn nhỏ gọn, có 1 vùng nấu, phù hợp cho căn bếp nhỏ hẹp. Có thể đặt trực tiếp trên bàn ăn để thưởng thức các món nướng, món lẩu nóng hổi thơm ngon.','2022-12-12',N'0002.jpg',3,'DQUANG','HN'),
(003,N'Nồi chiên không dầu 5.5L',1390000,N'Nồi chiên không dầu AVA màu đen sang trọng, chất liệu vỏ nhựa PVC cao cấp, kháng vỡ, chịu nhiệt tốt, dễ bố trí ở nhiều nơi trong bếp.','2023-05-15',N'0003.jpg',2,'KANGAR','NC'),
(004,N'Máy lọc nước',7590000,N'Thay đổi kết cấu bộ dây điện và bầu nóng (dung tích bầu nóng không thay đổi) của máy lọc nước RO Kangaroo KG10A4 VTU. Thay đổi chất liệu giá đỡ từ sắt sang nhựa và có thêm công tắc bơm trợ lực.','2022-10-14',N'0004.jpg',3,'CRYSTAL','ML'),
(005,N'Nồi cơm nắp rời',490000,N'Nồi cơm điện nắp rời kiểu dáng đơn giản, màu sắc trang nhã, phù hợp với mọi không gian bếp.','2023-07-28',N'0005.jpg',7,'BLUES','NR'),
(006,N'Bếp từ đôi',4990000,N'Bếp từ đôi Midea với mẫu mã hiện đại, có thể sử dụng bếp nổi hoặc lắp đặt âm gọn gàng, sang trọng, thiết kế nổi bật cho không gian bếp thêm tinh tế.','2023-02-25',N'0006.jpg',2,'DELITES','BT'),
(007,N'Bếp lẩu nướng đa năng',990000,N'Bếp lẩu nướng đa năng Crystal HY-6320 với thiết kế thông minh, màu sắc trang nhã, dung tích 2 lít cùng công suất 1600W, dễ dàng điều chỉnh nhiệt độ vùng nấu lẩu và vùng nướng bằng hai nút vặn độc lập.','2022-06-30',N'0007.jpg',2,'BLUES','BL'),
(008,N'Bàn ủi hơi nước',790000,N'Bàn ủi hơi nước cầm tay Philips thiết kế cầm tay gọn gàng, đẹp mắt, cầm thuận tay, dễ dàng di chuyển tùy theo nhu cầu, có thể mang theo đi công tác, du lịch,...','2023-03-10',N'0008.jpg',9,'DQUANG','BU'),
(009,N'Nồi chiên không dầu 5L',1290000,N'Nồi chiên không dầu thiết kế đơn giản, tinh tế với lớp vỏ nhựa PVC cao cấp cho nồi bóng sáng, sang trọng ấn tượng.','2022-05-20',N'0009.jpg',3,'DQUANG','NC'),
(010,N'Lò nướng Kangaro',2290000,N'Lò nướng Kangaroo kết cấu chắc chắn, thiết kế thanh lịch. Kiểu dáng lò nướng thùng gọn gàng, sang trọng, vỏ kim loại, mặt cửa lò bằng kính tráng gương bóng sáng, góp phần làm tăng tính thẩm mỹ của sản phẩm.','2023-01-01',N'0010.jpg',2,'DELITES','LN'),
(011,N'Máy sấy tóc 1100W',250000,N'Máy sấy tóc Ava hoạt động hiệu quả với 2 tốc độ sấy và chế độ sấy mát 2 tốc độ sấy tùy chỉnh bằng nút gạt trên tay cầm, giúp bạn dễ dàng lựa chọn theo nhu cầu sử dụng và tình trạng của tóc.','2021-02-15',N'0011.jpg',5,'CRYSTAL','MS'),
(012,N'Bếp hồng ngoại lắp âm',2490000,N'Bếp từ Midea MC-IHD361 thiết kế siêu mỏng, sang trọng, có thể lắp đặt âm dưới kệ bếp. Giúp tăng tính thẩm mỹ cho gian bếp hiện đại của nhà hàng, gia đình, quán ăn...','2023-05-02',N'0012.jpg',1,'DQUANG','HN'),
(013,N'Máy sấy tóc 1200 Delites',170000,N'Máy sấy tóc Delites MST02 thiết kế màu trắng trang nhã, thanh lịch, tiện dụng để sấy khô, tạo kiểu tóc. Công suất 1200W giúp làm khô tóc nhanh, tiết kiệm điện năng tối đa cho gia đình.','2022-09-19',N'0013.jpg',5,'DELITES','MS'),
(014,N'Bình đun siêu tốc Hafele',515000,N'Bình đun siêu tốc Hafele thiết kế sang trọng, hiện đại','2023-02-15',N'0014.jpg',2,'BLUES','BD'),
(015,N'Máy sấy tóc 1800W Showsee',379000,N'Công suất 1800W giúp sấy tóc nhanh, tiết kiệm điện năng và thời gian. Máy có 2 tốc độ sấy, giúp bạn dễ dàng điều chỉnh theo nhu cầu của mình.','2022-07-15',N'0015.jpg',5,'DQUANG','MS'),
(016,N'Bếp từ hồng ngoại lắp âm Ferroli',6990000,N'Công suất tổng 4200W, vùng từ 2000/2200W, vùng hồng ngoại 2000W. Mặt bếp bằng kính Ceramic - Schott Ceran dễ vệ sinh.','2023-06-20',N'0016.jpg',2,'DELITES','HN'),
(017,N'Nồi cơm điện tử Philips 1.8 lít',1490000,N'Công suất tối đa 940W cùng công nghệ nấu 3D nấu cơm chín đều, giàu dưỡng chất. Dung tích 1.8 lít, phù hợp sử dụng cho gia đình 4 - 6 người.','2023-03-12',N'0017.jpg',4,'BLUES','NR'),
(018,N'Máy lọc nước RO nóng nguội lạnh Karofi',9990000,N'Máy lọc nước RO nóng lạnh thiết kế sang trọng, nổi bật với 2 vòi 3 chế độ nước mang đến sự tiện nghi, đáp ứng nhu cầu sử dụng nước của người dùng','2023-04-01',N'0018.jpg',1,'DQUANG','ML'),
(019,N'Lò nướng Sunhouse Mama SHD4250S 50 lít',2345000,N'Dung tích 50 lít thích hợp sử dụng trong gia đình có đông thành viên, nhà hàng, khách sạn,…','2022-11-11',N'0019.jpg',5,'KANGAR','LN'),
(020,N'Bàn ủi khô Crystal RC-02 1000W',150000,N'Bàn ủi khô Crystal RC-02​ thiết kế đơn giản, đẹp mắt, công suất 1000W, mặt đế Ceramic chống dính, lướt êm ái trên mặt vải, tính năng tự ngắt khi quá nhiệt an toàn khi sử dụng.','2021-03-19',N'0020.jpg',7,'CRYSTAL','BU');

INSERT INTO ChiTietDonHang(MaDonHang,MaSanPham,SoLuong,DonGia)
VALUES
(001,001,2,240000),
(002,003,1,139000),
(003,005,1,490000),
(004,020,2,450000),
(005,011,2,500000),
(006,012,1,249000),
(007,015,1,379000),
(008,009,1,1290000);


Select*From QuanLy
Select*From KhachHang
Select*From DonHang
Select*From LoaiHang
Select*From NhaSanXuat
Select*From SanPham
Select*From ChiTietDonHang



drop table QuanLy
drop table KhachHang
drop table DonHang
Drop table LoaiHang
Drop table NhaSanXuat
Drop table SanPham
Drop table ChiTietDonHang
