--create database TEST1;
--use TEST1;

CREATE TABLE LOAI(
	[MALOAITS] [nvarchar](10) NOT NULL PRIMARY KEY,
	[TENLOAI] [nvarchar](50) NOT NULL,
	[DVIQLY] [nvarchar](50) NOT NULL,
	[CHUCNANG] [nchar](10) NULL,
	[GHICHU] [nchar](10) NULL);
--Drop table LOAI;
--delete from LOAI
insert into LOAI values(N'L001',N'Phương tiện giao thông',N'ABC',N'Đi lại',null);
insert into LOAI values(N'L002',N'Phương tiện giao dịch',N'XYZ',N'Giao dịch',null);
Select * from LOAI;

CREATE TABLE DONVI (
	[MADV] [nvarchar](10) NOT NULL PRIMARY KEY,
	[TENDONVI] [nvarchar](50) NOT NULL,
	NGUOIPT NVARCHAR(50) NOT NULL,
	CHUCNANG NCHAR(10) NULL);

--Drop table DONVI;
insert into DONVI values(N'DV001',N'ABC',N'Nguyễn Huy Hoàng',null);
insert into DONVI values(N'DV002',N'XYZ',N'Nguyễn Quốc Nam',null);
Select * from DONVI;

CREATE TABLE TAISAN(
	[MATS] [nvarchar](10) NOT NULL PRIMARY KEY,
	[TENTS] [nvarchar](50) NOT NULL,
	[MALOAITS] [nvarchar](10) NOT NULL references LOAI(MALOAITS),
	NAMSD INT NULL,
	NUOCSX [nvarchar](50) NULL,
	MADV [nvarchar](10) NOT NULL references DONVI(MADV));
--Drop table TAISAN;
insert into TAISAN values('TS001',N'Ô tô Huyndai',N'L001', 2022, N'Mỹ', N'DV001');
insert into TAISAN values('TS002',N'Vàng SJC',N'L002', 2022, N'Việt Nam', N'DV002');
--DELETE FROM TAISAN
Select * from TAISAN;


CREATE TABLE DIEUCHUYEN(
	[MADC] [nvarchar](10) NOT NULL PRIMARY KEY,
	[MATS] [nvarchar](10) NOT NULL references TAISAN(MATS),
	NGAYDC datetime not null,
	MADONVI_DEN [nvarchar](10) NOT NULL references DONVI(MADV),
	MADONVI_DI [nvarchar](10) NOT NULL references DONVI(MADV),
	TINHTRANG [nvarchar](20) NOT NULL );
--Drop table DIEUCHUYEN;
delete from DIEUCHUYEN
insert into DIEUCHUYEN values('DC001','TS001','8/12/2021','DV001','DV002',N'Đã chuyển' );
insert into DIEUCHUYEN values('DC002','TS002','2022-06-28','DV002','DV001',N'Chưa chuyển' );
Select * from DIEUCHUYEN;
--delete from DIEUCHUYEN

--Drop table DIEUCHUYEN;
--Drop table TAISAN;
--Drop table DONVI;
--Drop table LOAI;


Select * from DIEUCHUYEN;
Select * from TAISAN;
Select * from DONVI;
Select * from LOAI;
	
go
create proc SP_TIM_NUOCSX @nuocsx nvarchar(50)
as
begin
	select * from TAISAN where NUOCSX = @nuocsx;
end
go

exec SP_TIM_NUOCSX N'Việt Nam';
