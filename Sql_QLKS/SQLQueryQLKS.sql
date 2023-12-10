use QLKhachSan

create table khachhang
(
	makh nvarchar(10) not null primary key,
	tenkh nvarchar(30) not null,
	cccd nvarchar(12) unique not null,
	gioitinh nvarchar(3),
	sdt varchar(10),
	diachi nvarchar(50),
	email nvarchar(50),
	quoctich nvarchar(50)
)

create table phong
(
	maphg nvarchar(4) not null primary key,
	loaiphg nvarchar(9) not null,
	trangthai nvarchar(15),
	giaphg money
)

create table dichvu
(
	tendv nvarchar(20) not null primary key,
	soluong tinyint,
	dongia int,
)

create table hoadon
(
	mahd nvarchar(10) not null primary key,
	makh nvarchar(10) , 
	maphg nvarchar(4) ,
	tendv nvarchar(20) ,
	ngaylaphd date,
	ngaydatphg date not null,
	ngaytraphg date not null,
	tongtien money,

	constraint fk_makh foreign key (makh) references khachhang(makh),
	constraint fk_maphong foreign key (maphg) references phong(maphg),
	constraint fk_tp foreign key (tendv) references dichvu(tendv)
)
--Thêm dữ liệu vào bảng phong
insert into phong (maphg, loaiphg, giaphg, trangthai) 
values
--Thêm phồng đơn
('P101',N'Đơn',250000,N'Trống'),
('P102',N'Đơn',250000,N'Trống'),
('P103',N'Đơn',250000,N'Trống'),
('P104',N'Đơn',250000,N'Trống'),
('P105',N'Đơn',250000,N'Trống'),
('P106',N'Đơn',250000,N'Trống'),
('P107',N'Đơn',250000,N'Trống'),
('P108',N'Đơn',250000,N'Trống'),
('P109',N'Đơn',250000,N'Trống'),
('P110',N'Đơn',250000,N'Trống'),
--Thêm phòng đôi
('P201',N'Đôi',350000,N'Trống'),
('P202',N'Đôi',350000,N'Trống'),
('P203',N'Đôi',350000,N'Trống'),
('P204',N'Đôi',350000,N'Trống'),
('P205',N'Đôi',350000,N'Trống'),
('P206',N'Đôi',350000,N'Trống'),
('P207',N'Đôi',350000,N'Trống'),
('P208',N'Đôi',350000,N'Trống'),
('P209',N'Đôi',350000,N'Trống'),
('P210',N'Đôi',350000,N'Trống'),
--Thêm Phòng V.I.P
('P301','VIP',600000,N'Trống'),
('P302','VIP',600000,N'Trống'),
('P303','VIP',600000,N'Trống'),
('P304','VIP',600000,N'Trống'),
('P305','VIP',600000,N'Trống'),
('P306','VIP',600000,N'Trống'),
('P307','VIP',600000,N'Trống'),
('P308','VIP',600000,N'Trống'),
('P309','VIP',600000,N'Trống'),
('P310','VIP',600000,N'Trống')
;
--Thêm dữ liệu vào bảng dịch vụ
insert into dichvu (tendv, soluong, dongia)
values
(N'Cơm Phần', 0, 100000),
(N'Mì Ý', 0, 80000),
(N'Trái Cây', 0, 20000),
(N'Snack', 0, 5000),
(N'Rượu Vang', 0, 200000),
(N'Sting', 0, 10000),
(N'Mirinda', 0, 10000),
(N'Coca Cola', 0, 10000),
(N'Trà Ô Long', 0, 10000)
;
--Kiểm tra dử liệu bảng phòng
select * from phong
select * from dichvu

