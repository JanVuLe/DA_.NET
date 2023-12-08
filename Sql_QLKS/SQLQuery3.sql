use QLKS
--Tạo bảng khách hàng
create table khachhang
(
	makh nvarchar(10) not null,
	tenkh nvarchar(30) not null,
	cccd nvarchar(12) unique not null,
	gioitinh nvarchar(3),
	sdt varchar(10),
	diachi nvarchar(50),
);
	alter table khachhang add constraint pk_kh primary key (makh);
	alter table khachhang add constraint check_gt check (gioitinh = 'Nam' or gioitinh = 'Nữ');
--Tạo bảng phòng
create table phong
(
	maphong nvarchar(4) not null,
	loaiphong nvarchar(9) ,
	ngaydatphong date not null,
	ngaytraphong date not null,
	trangthai nvarchar(15),
);
	alter table phong add constraint pk_phong primary key (maphong);
	alter table phong add constraint check_lp check (loaiphong = N'Phòng đơn' or loaiphong = N'Phòng đôi' or loaiphong = N'Phòng VIP');
	alter table phong add constraint get_date default getdate();
--Tạo bản dịch vụ
create table dichvu
(
	tendichvu nvarchar(20) not null,
	soluong tinyint,
	dongia int,
);
	alter table dichvu add constraint pk_dv primary key (tendichvu);
	alter table dichvu add constraint check_soluong check (soluong > 0);

--Tạo bản hóa đơn
create table hoadon
(
	mahd nvarchar(10) not null,
	makh nvarchar(10) , 
	maphong nvarchar(4) ,
	tendichvu nvarchar(20) ,
	ngaylaphd date,
	tongtien money,
);
	alter table hoadon add constraint pk_mahd primary key (mahd);
	alter table hoadon add constraint fk_makh foreign key (makh) references khachhang(makh);
	alter table hoadon add constraint fk_maphong foreign key (maphong) references phong(maphong);
	alter table hoadon add constraint fk_tp foreign key (tendichvu) references dichvu(tendichvu);