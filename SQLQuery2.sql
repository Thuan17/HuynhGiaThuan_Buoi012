create database QLSinhVien
go



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
	NgaySinh date,
	MaLop char(20)
)
go


