CREATE DATABASE ESTATE

CREATE TABLE USERS (
	USID INT IDENTITY,
	TEN NVARCHAR(35),
	NGAYSINH DATE,
	DIACHI NVARCHAR(55),
	SDT CHAR(10),
	EMAIL VARCHAR(30),
	TENNGUOIDUNG VARCHAR(15),
	MATKHAU CHAR(15),
	QUYEN INT,
	PRIMARY KEY (USID)
)

CREATE TABLE VITRI(
	MAVITRI INT IDENTITY,
	QUAN NVARCHAR(35),
	THANHPHO NVARCHAR(55),
	QUOCGIA NVARCHAR(55),
	PRIMARY KEY (MAVITRI)
)

CREATE TABLE LOAIHINHBDS
(
	IDLOAI INT IDENTITY,
	TENLOAIHINH NVARCHAR(55),
	NHOMLOPBDS NVARCHAR(20),
	MUCDICHSUDUNG NVARCHAR(30),
	PRIMARY KEY (IDLOAI)
)

CREATE TABLE BATDONGSAN
(
	MABDS INT IDENTITY,
	TENBDS NVARCHAR(55),
	RONG INT,
	DAI INT,
	DIENTICH INT,
	VITRI INT, 
	LOAIHINHBDS INT,
	DIALY NVARCHAR(15),
	SOTANG INT,
	SOPHONGNGU INT,
	SOPHONGTAM INT,
	DICHVU BIT,
	GIA FLOAT,
	NVQUANLYBDS INT,
	CHUSOHUU INT,
	DUOCXAY BIT,
	HINHANH VARCHAR(350),
	PRIMARY KEY (MABDS)
)

CREATE TABLE GIAODICHKHACHHANG(
	MAGD INT IDENTITY,
	NGAYGIAODICH DATE,
	BENGIAO INT, 
	BENNHAN INT,
	BATDONGSAN INT,
	KYHAN DATE,
	DATCOC FLOAT,
	GIA FLOAT,
	PRIMARY KEY (MAGD)
)

CREATE TABLE HOPTACKHACHHANG
(
	MAHD INT IDENTITY,
	NHANVIENKY INT,
	KHACHHANG INT,
	NGAYKY DATE,
	GIABDS FLOAT,
	TILEHOAHONG FLOAT,
	PHIHOAHONG FLOAT,
	PRIMARY KEY (MAHD)
)

CREATE TABLE VIECLAM
(
	MAVL INT IDENTITY,
	CHUCVU NVARCHAR(55),
	SOLUONGTUYEN INT,
	NGAYDANG DATE,
	NGAYHETHAN DATE,
	MOTACV NVARCHAR(350),
	LUONG FLOAT,
	QLNHANSU INT,
	PRIMARY KEY (MAVL)
)

CREATE TABLE LICHHEN
(
	MALICHHEN INT IDENTITY,
	TENKH NVARCHAR(55),
	NGAYHEN DATE,
	SDT CHAR(10),
	EMAIL VARCHAR(30),
	DIACHI NVARCHAR(55),
	DICHVU NVARCHAR(30),
	GHICHU NVARCHAR(350),
	NVTIEPNHAN INT,
	PRIMARY KEY (MALICHHEN)
)

CREATE TABLE UNGCUVIEN
(
	MAUC INT IDENTITY,
	HOTEN NVARCHAR(55),
	NGAYSINH DATE,
	DIACHI NVARCHAR(55),
	SDT CHAR(10),
	EMAIL NVARCHAR(30),
	CHUCVU NVARCHAR(25),
	NAMKINHNGHIEM INT,
	QLNS INT,
	PRIMARY KEY (MAUC)
)

CREATE TABLE PICTURES
(
	PICTUREID INT IDENTITY,
	LINKANH VARCHAR(350),
	BDS INT,
	PRIMARY KEY (PICTUREID)
)

ALTER TABLE VIECLAM
ADD CONSTRAINT L1
FOREIGN KEY (QLNHANSU)
REFERENCES USERS(USID)


ALTER TABLE LICHHEN
ADD CONSTRAINT L2
FOREIGN KEY (NVTIEPNHAN)
REFERENCES USERS(USID)

ALTER TABLE UNGCUVIEN
ADD CONSTRAINT L3
FOREIGN KEY (QLNS)
REFERENCES USERS(USID)


ALTER TABLE  GIAODICHKHACHHANG
ADD CONSTRAINT L4
FOREIGN KEY (BENGIAO)
REFERENCES USERS(USID)

ALTER TABLE  GIAODICHKHACHHANG
ADD CONSTRAINT L5
FOREIGN KEY (BENNHAN)
REFERENCES USERS(USID)


ALTER TABLE  HOPTACKHACHHANG
ADD CONSTRAINT L6
FOREIGN KEY (NHANVIENKY)
REFERENCES USERS(USID)


ALTER TABLE  HOPTACKHACHHANG
ADD CONSTRAINT L7
FOREIGN KEY (KHACHHANG)
REFERENCES USERS(USID)

ALTER TABLE BATDONGSAN
ADD CONSTRAINT L8
FOREIGN KEY (VITRI)
REFERENCES VITRI(MAVITRI)

ALTER TABLE BATDONGSAN
ADD CONSTRAINT L9
FOREIGN KEY (LOAIHINHBDS)
REFERENCES LOAIHINHBDS(IDLOAI)

ALTER TABLE  BATDONGSAN
ADD CONSTRAINT L10
FOREIGN KEY (NVQUANLYBDS)
REFERENCES USERS(USID)

ALTER TABLE  BATDONGSAN
ADD CONSTRAINT L11
FOREIGN KEY (CHUSOHUU)
REFERENCES USERS(USID)

ALTER TABLE  PICTURES
ADD CONSTRAINT L12
FOREIGN KEY (BDS)
REFERENCES BATDONGSAN(MABDS)


INSERT USERS VALUES 
		(N'Nguyễn Văn An','02/03/1995',N'15/2 Tôn Thất Tùng Q1 TPHCM', '0927365112','nvan@gmail.com','AnNguyen','12345',0),
		(N'Trần Thu Hà','02/03/1995',N'15/2 Tôn Thất Tùng Q1 TPHCM', '0927365112','hatran@gmail.com','HaTran','12345',1),
		(N'Lê Quốc Lâm','02/03/1995',N'15/2 Tôn Thất Tùng Q1 TPHCM', '0927365112','lamquoc@gmail.com','TanLe','12345',2),
		(N'Nguyễn Quốc Đạt','02/03/1995',N'15/2 Tôn Thất Tùng Q1 TPHCM', '0927365112','quocdat@gmail.com','DatQuoc','12345',3),
		(N'Phạm Quỳnh Anh','02/03/1995',N'15/2 Tôn Thất Tùng Q1 TPHCM', '0927365112','phamanh@gmail.com','AnhPham','12345',0),
		(N'Lữ Tấn Chương','02/03/1995',N'15/2 Tôn Thất Tùng Q1 TPHCM', '0927365112','chuonglu@gmail.com','LuChuong','12345',0),
		(N'Đặng Văn Bảo','02/03/1995',N'15/2 Tôn Thất Tùng Q1 TPHCM', '0927365112','baodang@gmail.com','BaoDang','12345',0),
		(N'Đặng Văn Bảo','02/03/1995',N'15/2 Tôn Thất Tùng Q1 TPHCM', '0927365112','baodang@gmail.com','BaoDang','12345',0),
		(N'Lê Minh Nhựt','08/02/1982',N'12/5 Lê Trọng Tấn Quận Hà Đông HN', '0938736465','Nhut@gmail.com','NhutLe','12345',0),
		(N'Lê Thị Thu Minh','03/01/1979',N'56 Võ Chí Công Quận Tây Hồ HN', '0938646545','MinhLe@gmail.com','MinhLee','12345',0),
		(N'Đặng Nhật Tân','01/02/1975',N'11 Tân Triều Quận Thanh Trì Hà Nội', '0983733131','Tan@gmail.com','TanDang','12345',0)


INSERT VITRI VALUES 
		(N'Quận 1',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Quận 2',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Quận 3',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Quận 4',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Quận 5',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Quận 6',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Quận 7',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Quận 8',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Quận 9',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Quận 10',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Quận 11',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Quận 12',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Quận Gò Vấp',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Quận Bình Thạnh',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Quận Tân Bình',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Quận Bình Tân',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Quận Phú Nhuận',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Quận Thủ Đức',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Quận Tân Phú',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Huyện Bình Chánh',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Huyện Hóc Môn',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Quận Củ Chi',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Huyện Nhà Bè',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Huyện Cần Giờ',N'Thành Phố Hồ Chí Minh',N'Việt Nam'),
		(N'Hoàn Kiếm',N'Hà Nội',N'Việt Nam'),
		(N'Ba Đình',N'Hà Nội',N'Việt Nam'),
		(N'Hai Bà Trưng',N'Hà Nội',N'Việt Nam'),
		(N'Đống Đa',N'Hà Nội',N'Việt Nam'),
		(N'Cầu Giấy',N'Hà Nội',N'Việt Nam'),
		(N'Bắc Từ Liêm',N'Hà Nội',N'Việt Nam'),
		(N'Nam Từ Liêm',N'Hà Nội',N'Việt Nam'),
		(N'Chương Mỹ',N'Hà Nội',N'Việt Nam'),
		(N'Ba Vì',N'Hà Nội',N'Việt Nam'),
		(N'Đan Phượng',N'Hà Nội',N'Việt Nam'),
		(N'Đông Anh',N'Hà Nội',N'Việt Nam'),
		(N'Đống Đa',N'Hà Nội',N'Việt Nam'),
		(N'Long Biên',N'Hà Nội',N'Việt Nam'),
		(N'Mê Linh',N'Hà Nội',N'Việt Nam'),
		(N'Tây Hồ',N'Hà Nội',N'Việt Nam'),
		(N'Sơn Tây',N'Hà Nội',N'Việt Nam'),
		(N'Thanh Trì',N'Hà Nội',N'Việt Nam'),
		(N'Hà Đông',N'Hà Nội',N'Việt Nam')

INSERT LOAIHINHBDS VALUES 
	(N'Biệt Thự',N'Nhà Ở',N'Cư trú'),
	(N'Căn Hộ',N'Nhà Ở',N'Cư trú'),
	(N'Căn Hộ Thông Tầng',N'Nhà Ở',N'Cư trú'),
	(N'Nhà riêng',N'Nhà Ở',N'Cư trú'),
	('Studio',N'Công Sở',N'Làm việc'),
	(N'Văn Phòng',N'Công Sở',N'Làm việc'),
	('Officetel',N'Công Sở',N'Làm việc'),
	(N'Mặt Bằng Kinh Doanh',N'Kinh Doanh',N'Buôn bán'),
	(N'Nhà xưởng',N'Công Nghiệp',N'Sản xuất'),
	(N'Nhà máy',N'Công Nghiệp',N'Sản xuất'),
	(N'Đất nông nghiệp',N'Đất nền',N'Trồng trọt'),
	(N'Đất phi nông nghiệp',N'Đất nền',N'Xây dựng')


INSERT BATDONGSAN VALUES
	(N'Nhà phố Lake View',10,20,200,2,1,N'3 mặt tiền',4,5,6,0,25000000000,4,1,1,'https://file4.batdongsan.com.vn/2023/06/07/20230607140718-fb1f_wm.jpg'),
	(N'Chung cư Vinhome',6,20,120,14,2,N'3 View',0,3,2,0,8000000000,4,6,1,'https://file4.batdongsan.com.vn/2023/05/31/20230531180523-c0cb_wm.jpg'),
	(N'Văn phòng VCB Tower',40,50,1000,1,6,N'3 mặt tiền',0,0,2,1,500000000,4,7,1,'https://file4.batdongsan.com.vn/resize/1275x717/2023/05/24/20230524115849-07b3_wm.jpg'),
	(N'Nhà phố quận 7 xịn',5,18,90,7,4,N'1 mặt tiền',4,5,6,0,15000000000,4,1,1,'https://file4.batdongsan.com.vn/2023/06/07/20230607140718-fb1f_wm.jpg'),
	(N'Dự án Skypark Atria Saigon',90,100,9000,2,2,N'4 mặt tiền',20,0,0,0,0,4,5,0,'https://file4.batdongsan.com.vn/2023/04/08/20230408224953-353c_wm.jpg'),
	(N'Dự án văn phòng Detech Tower I',22,50,1100,3,7,N'4 mặt tiền',15,0,0,1,0,4,7,0,'https://file4.batdongsan.com.vn/resize/1275x717/2016/10/30/20161030182128-02e7.jpg'),
	(N'Đất nền',385,400,154600,18,12,N'5 mặt tiền',0,0,0,0,0,4,6,0,'https://file4.batdongsan.com.vn/2022/06/30/20220630111432-2722.jpg'),
	(N'Nhà mặt phố hàng phèn',6,8,48,25,4,N'1 mặt tiền',2,4,3,0,33000000000,4,1,1,'https://file4.batdongsan.com.vn/resize/1275x717/2023/03/29/20230329080311-9137_wm.jpg'),
	(N'Nhà phố Khúc Thừa Dụ',5,10,50,29,4,N'1 mặt tiền',7,5,4,0,15800000000,4,1,1,'https://file4.batdongsan.com.vn/resize/1275x717/2023/06/24/20230624151257-14cc_wm.jpg'),
	(N'Nhà phố vườn hoa siêu đẹp',10,20,200,42,4,N'1 mặt tiền',4,4,3,0,12000000000,4,8,1,'https://file4.batdongsan.com.vn/2023/06/09/20230609102644-eca0_wm.jpg'),
	(N'Biệt thự Võ Chí Công',9,20,180,39,1,N'1 mặt tiền',3,5,4,0,35000000000,4,9,1,'https://file4.batdongsan.com.vn/2023/06/21/20230621154309-ac66_wm.jpg'),
	(N'Biệt Thự Tân Triều',5,20,100,41,1,N'2 mặt tiền',3,5,4,0,12000000000,4,10,1,'https://file4.batdongsan.com.vn/2023/06/16/20230616112454-56ea_wm.jpg')
	
INSERT PICTURES VALUES
('https://file4.batdongsan.com.vn/resize/1275x717/2023/06/07/20230607140716-2b34_wm.jpg',   23),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/06/07/20230607140716-a3b2_wm.jpg',   23),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/06/07/20230607140716-ae4e_wm.jpg',   23),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/06/07/20230607140717-5bff_wm.jpg',	23),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/06/07/20230607140718-2267_wm.jpg',	23),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/04/09/20230409191629-8c7e_wm.jpg',	24),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/04/09/20230409191629-87eb_wm.jpg',	24),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/04/09/20230409191629-a3a0_wm.jpg',	24),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/04/09/20230409191629-268e_wm.jpg',	24),
('https://file4.batdongsan.com.vn/resize/1275x717/2022/08/19/20220819161612-acd6_wm.jpg',	25),
('https://file4.batdongsan.com.vn/resize/1275x717/2022/08/19/20220819161612-3efa_wm.jpg',	25),
('https://file4.batdongsan.com.vn/resize/1275x717/2022/08/19/20220819161612-d2cd_wm.jpg',	25),
('https://file4.batdongsan.com.vn/resize/1275x717/2022/08/19/20220819161611-8a09_wm.jpg',	25),
('https://file4.batdongsan.com.vn/resize/1275x717/2022/11/08/20221108135951-ab74_wm.jpg',	26),
('https://file4.batdongsan.com.vn/resize/1275x717/2022/11/08/20221108135949-cd33_wm.jpg',	26),
('https://file4.batdongsan.com.vn/resize/1275x717/2022/11/08/20221108135832-a92f_wm.jpg',	26),
('https://file4.batdongsan.com.vn/resize/1275x717/2022/11/08/20221108135832-ae26_wm.jpg',	26),
('https://file4.batdongsan.com.vn/resize/1275x717/2022/11/08/20221108135832-dbd3_wm.jpg',	26),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/07/21/20230721174717-a36f_wm.jpg',	27),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/07/21/20230721174739-ecae_wm.jpg',	27),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/07/21/20230721174800-538d_wm.jpg',	27),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/07/21/20230721174803-7c3b_wm.jpg',	27),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/07/21/20230721174833-7b12_wm.jpg',	27),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/07/21/20230721174834-9240_wm.jpg',	27),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/07/11/20230711104401-6537_wm.jpg',	28),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/07/11/20230711104401-e828_wm.jpg',	28),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/07/11/20230711104401-c8ed_wm.jpg',	28),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/07/11/20230711104424-8789_wm.jpg',	28),
('https://file4.batdongsan.com.vn/resize/1275x717/2022/01/03/20220103141840-dd21_wm.jpg',	29),
('https://file4.batdongsan.com.vn/resize/1275x717/2022/01/03/20220103141912-7de8_wm.jpg',	29),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/03/16/20230316135204-bcd6_wm.jpg',	29),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/07/18/20230718103153-6a39_wm.jpg',	30),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/07/18/20230718103153-3d0e_wm.jpg',	30),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/06/19/20230619095801-542b_wm.jpg',	31),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/06/19/20230619095805-425f_wm.jpg',	31),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/06/19/20230619095855-bb30_wm.jpg',	31),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/06/19/20230619095850-fc2c_wm.jpg',	31),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/02/27/20230227092246-8732_wm.jpg',	32),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/02/27/20230227092246-959a_wm.jpg',	32),
('https://file4.batdongsan.com.vn/resize/1275x717/2023/02/27/20230227092259-ad74_wm.jpg',	32),
('https://file4.batdongsan.com.vn/resize/1275x717/2020/08/30/20200830102937-936f_wm.jpeg',  33),
('https://file4.batdongsan.com.vn/resize/1275x717/2020/08/30/20200830102938-220c_wm.jpeg',  33),
('https://file4.batdongsan.com.vn/resize/1275x717/2020/08/30/20200830102941-4ea9_wm.jpeg',  33),
('https://file4.batdongsan.com.vn/resize/1275x717/2022/10/25/20221025091221-79f6_wm.jpg',	34),
('https://file4.batdongsan.com.vn/resize/1275x717/2022/10/25/20221025091221-529b_wm.jpg',	34),
('https://file4.batdongsan.com.vn/resize/1275x717/2022/10/25/20221025091222-2c50_wm.jpg',   34),
('https://file4.batdongsan.com.vn/resize/1275x717/2022/10/25/20221025091222-8cff_wm.jpg',	34)