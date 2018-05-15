use master
create database QLNHTC
use QLNHTC

--xoa database
drop database QLNHTC
create table KHACHHANG
(
    MaKH char(10) primary key,
	HoTenVo varchar(30),
	DiaChi varchar(50),
	SDT int,
	DOANHSO money,
)
create table NHANVIEN
(
    MANV char(10) primary key,
	HOTEN varchar(30),
	NAMSINH smalldatetime,
	NGAYLAMVIEC date,
    QUEQUAN varchar(20),
	SODT int,
	SOCMND int,
	BANGCAP varchar(20),
	GIOITINH varchar(10),
)
create table DICHVU
( 
    MADV char(10) primary key,
    TENDV varchar(20),
	DONGIA decimal(10,0),
)
create table MONAN
(
    MAMA char(10) primary key,
	TENMA varchar(20),
	DONGIA decimal(10,0)
)

--code chuan 

create table CA
(
	MaCa varchar(10) primary key,
	ThoiGianBatDau varchar(10),
	ThoiGianKetThuc varchar(10),
)
create table CA1
(
	MaCa int,
)
insert CA values('1','0:0','0:0')
insert into CA values ('2','0:0','0:0')
insert into CA1 values(100)
create table SANH
(
    MaSanh char(10) primary key,
	TenSanh varchar(30),
	SoLuongBanToiDa int,	
	SoLuongNhanVienToiDa int,
)
create table CHITIETSANH
(
    MaSanh char(10) foreign key (MaSanh) references Sanh(MaSanh),
    SoLuongBan int,
	SoLuongBanDuTru int,
	SoLuongBoDungCuDoAn int,
	SoLuongXeDayDoAn int,
	SoLuongNhanVienTrongSanh int,
)
create table HOPDONGDATTIEC
(
    MaHD char(10) primary key,
	MaKhachHang char(10) foreign key (MaKhachHang) references KHACHHANG(MAKH),
	NgayDatTiec date,
	TongTien Decimal(10,0),
	TienCoc Decimal(10,0),
	SoDT int,
)
create table PHIEUDATTIEC
(
    Maphieu char(10) primary key,
	Makhachhang char(10) foreign key (Makhachhang) references KHACHHANG(MAKH),
	MaSanh char(10) foreign key (MaSanh) references Sanh(MASANH),
	MaMonAn char(10) foreign key (MaMonAn) references MONAN(MAMA),
	MaDichVu char(10) foreign key (MaDichVu) references DICHVU(MADV),
	Ngaylamphieu date,
)
create table HOADON
(
    MAHD char(10) primary key,
	MaHopDong char(10) foreign key (MaHopDong) references HopDongDatTiec(MaHD),
	NgayThanhToan DATE NOT NULL,
	IienPhat DECIMAL(10,0),
	TongTienHoaDon DECIMAL(10,0),
	TienDatCoc DECIMAL(10,0),
	TienConThieu DECIMAL(10,0),
)
	 





	





