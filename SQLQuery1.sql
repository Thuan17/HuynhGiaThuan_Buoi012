create database QL_NhanSu
go


create table NhanVien(
	Id char(20)primary key ,
	Name nvarchar(max),
	
)
go


insert into NhanVien values('NV01',N'Thuận')
insert into NhanVien values('NV02',N'Tài')
insert into NhanVien values('NV03',N'Thủy')


select * from NhanVien

create table Khoa (
	MaKhoa char(20)primary key,
	TenKhoa nvarchar(max)
)
go

create table Lop(
Malop char(20)primary key ,
TenLop nvarchar(max),
MaKhoa char(20)
)
go


create table SinhVien (
	MaSinhVien char(20)primary key ,
	HoTen nvarchar(max),
)
go


