use QLKhachSan

create table khachhang
(
	makh nvarchar(10) not null primary key,
	tenkh nvarchar(30) not null,
	cccd nvarchar(12) unique not null,
	gioitinh nvarchar(3),
	sdt varchar(10),
	diachi nvarchar(50)
)

create table phong
(
	maphg nvarchar(4) not null primary key,
	loaiphg nvarchar(9) not null,
	ngaydatphg date not null,
	ngaytraphg date not null,
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
	tongtien money,

	constraint fk_makh foreign key (makh) references khachhang(makh),
	constraint fk_maphong foreign key (maphg) references phong(maphg),
	constraint fk_tp foreign key (tendv) references dichvu(tendv)
)
