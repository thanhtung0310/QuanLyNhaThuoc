

--------------------form nhap thuoc-----------------------------
create proc proc_searchNhanVien 
	@maNV char(15)
as begin
	select TenNhanVien, SoDienThoai from NHANVIEN where MaNhanVien like @maNV
end



create proc proc_searchNhaCungCap
	@tenNCC nvarchar(30)
as begin
	select MaNhaCungCap,ThongTinDaiDien from NHACUNGCAP where TenNhaCungCap like @tenNCC
end


create proc proc_searchHangSanXuat
as begin
	select TenHangSX from HANGSANXUAT
end


	create proc proc_searchLoaiThuoc
	as
	begin
		select TenLoaiThuoc from LOAITHUOC
	end

	




create proc proc_addThuoc
	@maT char(20),
	@mahang char(15),
	@nsx date,
	@hsd date,
	@ten nvarchar(max),
	@cd nvarchar(max),
	@tp nvarchar(max),
	@sl int,
	@dang nvarchar(20),
	@mLoai char(15),
	@date date,
	@mncc char(15),
	@mnv char(15),
	@gia int
as begin
	declare @maThuoc char(20)
	declare @maLo char(15)
	set @maLo = rtrim(@mahang) +'.'+ RIGHT('00' + RTRIM(CAST(MONTH(@nsx) AS varchar(2))),2)+Right(Year(@nsx),2)
	set @maThuoc= rtrim(@maLo)+'.'+rtrim(@mLoai)+'.'+rtrim(@maT)
	insert into dbo.LOTHUOC
				(MaLoThuoc,MaHangSX,NgaySanXuat,HanSuDung,SoLuongThuoc)
		values(@maLo,@mahang,@nsx,@hsd,@sl)
	insert into dbo.THUOC
			(MaThuoc,MaLoThuoc,TenThuoc,CongDung,ThanhPhan,SoLuongTon,DangThuoc,MaLoaiThuoc)
	values(@maThuoc,@maLo,@ten,@cd,@tp,0,@dang,@mLoai)
		declare @mpn char(20)
	set @mpn=replace(convert(varchar, getdate(),103),'/','') + rtrim(@mnv)

	insert into dbo.PHIEUNHAP
			(MaPhieuNhap,NgayNhap,MaNhaCungCap,MaNhanVien)
	values(@mpn,@date,@mncc,@mnv)
	insert into dbo.CHITIETPHIEUNHAP
			(MaPhieuNhap,MaThuoc,SoLuong,DonGia)
	values(@mpn,@maThuoc,@sl,@gia)
end
create trigger Update_CTPN_Thuoc on dbo.CHITIETPHIEUNHAP
INSTEAD OF INSERT
as begin
	declare @SLT int
	set @SLT = (select SoLuongTon from THUOC where MaThuoc in (select MaThuoc from inserted))
	declare @SLM int
	set @SLM = (select SoLuong from inserted)
	
		begin
			insert into CHITIETPHIEUNHAP
					(MaPhieuNhap,MaThuoc,SoLuong,DonGia)
			select * from inserted
			update THUOC
			set SoLuongTon=SoLuongTon+@SLM
			where MaThuoc in (select MaThuoc from inserted)
		end
	
end



create proc proc_selectMaHangSX
	@tenHSX nvarchar(50)
as begin
	select MaHangSX from HANGSANXUAT where TenHangSX like @tenHSX
end

create proc proc_selectLoaiThuoc
	@tenLoaiThuoc nvarchar(30)
as begin
	select MaLoaiThuoc from LOAITHUOC where TenLoaiThuoc like @tenLoaiThuoc
end

create proc proc_searchTenNhaCungCap
as begin
	select TenNhaCungCap from NHACUNGCAP
end
--------end form nhap thuoc ------------------------------

--------form ban thuoc -----------------------------------
create proc proc_searchTenThuoc
as begin
	select TenThuoc from THUOC
end

create proc proc_searchThuocBan
	@tenThuoc nvarchar(max)
as begin
	select MaThuoc,ThanhPhan,CongDung,SoLuongTon,DonGia from THUOC where TenThuoc like @tenThuoc 
end

create proc proc_searchKH
	@cmt nchar(12)
as begin
	select * from KHACHHANG where [CMND/TCCCD] like @cmt 
end

create proc proc_addKH
	@ten nvarchar(40),
	@sdt char(15),
	@cmnd char(12)
as begin
	declare @makh char(35)
	set @makh=stuff(rtrim(@sdt),6,0,@cmnd)
	insert into dbo.KHACHHANG
			(MaKhachHang,TenKhachHang,SoDienThoai,[CMND/TCCCD])
	values(@makh,@ten,@sdt,@cmnd)
end

--thêm phiếu xuất + tự sinh mã phiếu
create proc proc_addPX
	@date date,
	@mkh char(35),
	@mnv char(15),
	@tong int
as begin
	declare @mpx char(20)
	declare @sdt char(15)
	if not exists (select * from KHACHHANG where MaKhachHang=@mkh)
	begin
		print N'Mã khách hàng không hợp lệ'
		return
	end
	else if not exists (select * from NHANVIEN where MaNhanVien=@mnv)
	begin
		print N'Mã nhân viên không hợp lệ'
		return
	end
	else
	begin
		set @sdt=(select SoDienThoai from KHACHHANG where MaKhachHang=@mkh)
		set @mpx=replace(convert(varchar, getdate(),103),'/','') + @sdt
		insert into dbo.PHIEUXUAT
				(MaPhieuXuat,NgayXuat,MaKhachHang,MaNhanVien,Tong)
		values(@mpx,@date,@mkh,@mnv,@tong)
	end
end
--chạy
--thêm phiếu xuất + tự sinh mã phiếu
create proc proc_addPX
	@date date,
	@mkh char(35),
	@mnv char(15)
as begin
	declare @mpx char(20)
	declare @sdt char(15)
	if not exists (select * from KHACHHANG where MaKhachHang=@mkh)
	begin
		print N'Mã khách hàng không hợp lệ'
		return
	end
	else if not exists (select * from NHANVIEN where MaNhanVien=@mnv)
	begin
		print N'Mã nhân viên không hợp lệ'
		return
	end
	else
	begin
		set @sdt=(select SoDienThoai from KHACHHANG where MaKhachHang=@mkh)
		set @mpx=replace(convert(varchar, getdate(),103),'/','') + replace(convert(varchar, getdate(),108),':','')
		insert into dbo.PHIEUXUAT
				(MaPhieuXuat,NgayXuat,MaKhachHang,MaNhanVien,Tong)
		values(@mpx,@date,@mkh,@mnv,0)
	end
end
----------------------------phieu nhap
create proc proc_addPN
	@date date,
	@mncc char(15),
	@mnv char(15)
as begin
	declare @mpn char(20)
	set @mpn=replace(convert(varchar, getdate(),103),'/','') + replace(convert(varchar, getdate(),108),':','')
	insert into dbo.PHIEUNHAP
			(MaPhieuNhap,NgayNhap,MaNhaCungCap,MaNhanVien)
	values(@mpn,@date,@mncc,@mnv)
end
	
--thêm chi tiết phiếu xuất kết hợp vs trigger update số lượng tồn
create proc proc_addCTPX
	@date date,
	@mkh char(35),
	@maT char(20),
	@sl int,
	@gia int
as begin
	declare @mpx char(20)
	declare @sdt char(15)
	set @sdt=(select SoDienThoai from KHACHHANG where MaKhachHang=@mkh)
	set @mpx=replace(convert(varchar, getdate(),103),'/','') + @sdt
	insert into dbo.CHITIETPHIEUXUAT
			(MaPhieuXuat,MaThuoc,SoLuong,DonGia)
	values(@mpx,@maT,@sl,@gia)
end



--trigger update số lượng tồn
create trigger Update_CTPX_Thuoc on dbo.CHITIETPHIEUXUAT
INSTEAD OF INSERT
as begin
	declare @SLT int
	set @SLT = (select SoLuongTon from THUOC where MaThuoc in (select MaThuoc from inserted))
	declare @SLM int
	set @SLM = (select SoLuong from inserted)
	if(@SLT>=@SLM)
		begin
			insert into CHITIETPHIEUXUAT
					(MaPhieuXuat,MaThuoc,SoLuong,DonGia)
			select * from inserted
			update THUOC
			set SoLuongTon=SoLuongTon-@SLM
			where MaThuoc in (select MaThuoc from inserted)
		end
	else
		print N'Kho không đủ thuốc'
end


---------end form ban thuoc -------------------------------

---------form danh sach------------------------------------

create proc proc_SearchThuoc
	@s nvarchar(max)
as begin
	select MaThuoc,TenThuoc,THUOC.MaLoThuoc,MaLoaiThuoc,MaHangSX,ThanhPhan,CongDung,NgaySanXuat,HanSuDung,SoLuongTon,DangThuoc
	from THUOC,LOTHUOC
	where THUOC.TenThuoc like '%'+@s+'%' and THUOC.MaLoThuoc=LOTHUOC.MaLoThuoc 
end

exec proc_SearchThuoc 'ca'




--proc update thuốc

create proc proc_UpdateThuoc
	@mathuoc char(20),
	@malo char(15),
	@ten nvarchar(max),
	@tp nvarchar(max),
	@cd nvarchar(max),
	@nsx date,
	@hsd date,
	@slt int,
	@dt nvarchar(20)
as begin
	update THUOC
	set TenThuoc=@ten,ThanhPhan=@tp,CongDung=@cd,SoLuongTon=@slt,DangThuoc=@dt
	where MaThuoc=@mathuoc

	update LOTHUOC 
	set HanSuDung=@hsd,NgaySanXuat=@nsx
	where MaLoThuoc=@malo
end

exec proc_UpdateThuoc 'BG5T0519.TDY.CSR','BG5T0519',N'Casoran',N'Cao hoa hòe, Cao dừa cạn, Cao tâm sen',N'Thuốc hạ huyết áp','5/10/2019 12:00:00 AM','5/10/2022 12:00:00 AM',1500,N'Thuốc cốm'

--proc del thuốc         

create proc proc_deleteThuoc
	@ma char(20)
as begin
	delete from THUOC where MaThuoc=@ma
end



--------------end form danh sach----------------------------

-------------form nha cung cap-----------------------------

create proc proc_searchNCC
	@ten nvarchar(30)
as begin
	select * from NHACUNGCAP where TenNhaCungCap like '%'+@ten+'%'
end

create proc proc_addNCC
	@ma char(15),
	@ten nvarchar(30),
	@diachi nvarchar(50),
	@tt nvarchar(50),
	@sdt nchar(11)
as begin
	insert into dbo.NHACUNGCAP
			(MaNhaCungCap,TenNhaCungCap,DiaChi,ThongTinDaiDien,SoDienThoai)
	values(@ma,@ten,@diachi,@tt,@sdt)
end

create proc proc_updateNCC
	@ma char(15),
	@ten nvarchar(30),
	@diachi nvarchar(50),
	@tt nvarchar(50),
	@sdt nchar(11)
as begin
	update NHACUNGCAP set TenNhaCungCap = @ten, DiaChi = @diachi, ThongTinDaiDien = @tt, SoDienThoai = @sdt
	where MaNhaCungCap = @ma
end


create proc proc_deleteNCC
	@ma char(15)
as begin
	delete from CHITIETPHIEUNHAP where MaPhieuNhap in 
	(
		select MaPhieuNhap from PHIEUNHAP where MaNhaCungCap = @ma
	)
	delete from PHIEUNHAP where MaPhieuNhap in
	(
		select MaPhieuNhap from PHIEUNHAP where MaNhaCungCap = @ma
	)
	
	delete from NHACUNGCAP where MaNhaCungCap = @ma

end


-------------end form nha cung cap---------------------------

----------moi------------------------------------------------
--- form ban thuoc ---
--1. add phieu xuat
create proc proc_addPX
	@date date,
	@mkh char(35),
	@mnv char(15),
	@tong int--,
	--@mpx char(20) out
as begin
	declare @mpx char(20)
	declare @sdt char(15)
	if not exists (select * from KHACHHANG where MaKhachHang=@mkh)
	begin
		print N'Mã khách hàng không hợp lệ'
		return
	end
	else if not exists (select * from NHANVIEN where MaNhanVien=@mnv)
	begin
		print N'Mã nhân viên không hợp lệ'
		return
	end
	else
	begin
		set @sdt=(select SoDienThoai from KHACHHANG where MaKhachHang=@mkh)
		set @mpx=replace(convert(varchar, getdate(),103),'/','') + replace(convert(varchar, getdate(),108),':','')
		insert into dbo.PHIEUXUAT
				(MaPhieuXuat,NgayXuat,MaKhachHang,MaNhanVien,Tong)
		values(@mpx,@date,@mkh,@mnv,@tong)
		select @mpx as 'MaPX'
	end
end

create proc proc_addCTPX
	@mpx char(20),
	@maT char(20),
	@sl int,
	@gia int
as begin
	insert into dbo.CHITIETPHIEUXUAT
			(MaPhieuXuat,MaThuoc,SoLuong,DonGia)
	values(@mpx,@maT,@sl,@gia)
end

create trigger Update_CTPX_Thuoc on dbo.CHITIETPHIEUXUAT
INSTEAD OF INSERT
as begin
	declare @SLT int
	set @SLT = (select SoLuongTon from THUOC where MaThuoc in (select MaThuoc from inserted))
	declare @SLM int
	set @SLM = (select SoLuong from inserted)
	if(@SLT>=@SLM)
		begin
			insert into CHITIETPHIEUXUAT
					(MaPhieuXuat,MaThuoc,SoLuong,DonGia)
			select * from inserted
			update THUOC
			set SoLuongTon=SoLuongTon-@SLM
			where MaThuoc in (select MaThuoc from inserted)
		end
	else
		print N'Kho không đủ thuốc'
end
-- form danh sach

create proc proc_searchThuocDanhSachDGV
	@ten nvarchar(50)
as begin
	select MaThuoc,MaLoThuoc,TenThuoc,MaLoaiThuoc,DonGia,SoLuongTon from THUOC 
	where THUOC.TenThuoc like N'%'+@ten+'%'
end
exec proc_searchThuocDanhSachDGV 'd'

create proc proc_searchThuocSua
	@maT char(20)
as begin

select TenThuoc,THUOC.MaLoThuoc,MaLoaiThuoc,MaHangSX,ThanhPhan,CongDung,NgaySanXuat,HanSuDung,DonGia,SoLuongTon,DangThuoc
	from THUOC,LOTHUOC
	where THUOC.MaThuoc like @maT and THUOC.MaLoThuoc=LOTHUOC.MaLoThuoc 
end
exec proc_searchThuocSua 'AT670218.TTY.DCT5   '

alter proc proc_deleteThuoc
	@maT char(20)
as begin
	delete from CHITIETPHIEUNHAP where MaThuoc like @maT
	delete from CHITIETPHIEUXUAT where MaThuoc like @maT
	delete from THUOC where MaThuoc like @maT
end

exec proc_deleteThuoc 'DPPM.0115.TDY.BG05  '

alter proc [dbo].[proc_UpdateThuoc]
	@mathuoc char(20),
	@malo char(15),
	@ten nvarchar(max),
	@tp nvarchar(max),
	@cd nvarchar(max),
	@nsx date,
	@hsd date,
	@slt int,
	@dt nvarchar(20),
	@dongia int
as begin
	update THUOC
	set TenThuoc=@ten,ThanhPhan=@tp,CongDung=@cd,SoLuongTon=@slt,DangThuoc=@dt,DonGia=@dongia
	where MaThuoc=@mathuoc

	update LOTHUOC 
	set HanSuDung=@hsd,NgaySanXuat=@nsx
	where MaLoThuoc=@malo
end

exec proc_UpdateThuoc 'DPPM.0619.TTY.TT08  ','DPPM.0619      ',N'thuốc trợ tim mạch',N'cetamol',N'trợ tim','10-06-2018','02-21-2024',1000,N'viên nén',15000

create proc [dbo].[proc_addThuoc]
	@maT char(20),
	@mahang char(15),
	@nsx date,
	@hsd date,
	@ten nvarchar(max),
	@cd nvarchar(max),
	@tp nvarchar(max),
	@sl int,
	@dang nvarchar(20),
	@mLoai char(15),
	@date date,
	@mncc char(15),
	@mnv char(15),
	@gia int
as begin
	declare @maThuoc char(20)
	declare @maLo char(15)
	set @maLo = rtrim(@mahang) +'.'+ RIGHT('00' + RTRIM(CAST(MONTH(@nsx) AS varchar(2))),2)+Right(Year(@nsx),2)
	set @maThuoc= rtrim(@maLo)+'.'+rtrim(@mLoai)+'.'+rtrim(@maT)
	insert into dbo.LOTHUOC
				(MaLoThuoc,MaHangSX,NgaySanXuat,HanSuDung)
		values(@maLo,@mahang,@nsx,@hsd)
	insert into dbo.THUOC
			(MaThuoc,MaLoThuoc,TenThuoc,CongDung,ThanhPhan,SoLuongTon,DangThuoc,MaLoaiThuoc,DonGia)
	values(@maThuoc,@maLo,@ten,@cd,@tp,@sl,@dang,@mLoai,@gia*1.2)
		declare @mpn char(20)
	set @mpn=replace(convert(varchar, getdate(),103),'/','') + rtrim(@mnv)

	insert into dbo.PHIEUNHAP
			(MaPhieuNhap,NgayNhap,MaNhaCungCap,MaNhanVien)
	values(@mpn,@date,@mncc,@mnv)
	insert into dbo.CHITIETPHIEUNHAP
			(MaPhieuNhap,MaThuoc,SoLuong,DonGia)
	values(@mpn,@maThuoc,@sl,@gia)
end

-------------------form tìm kiếm--------------------------------------
------------------đưa ra toàn bộ thông tin của thuốc đã được nhập về và bán ra---------------------------------------
create procedure proc_TimKiem 
as begin
	select TenThuoc,CongDung,ThanhPhan,DangThuoc,NgaySanXuat,HanSuDung,C1.DonGia,C2.DonGia
	from THUOC T
	inner join LOTHUOC L on T.MaLoThuoc = L.MaLoThuoc
	inner join CHITIETPHIEUNHAP C1 on T.MaThuoc = C1.MaThuoc
	inner join CHITIETPHIEUXUAT C2 on T.MaThuoc = C2.MaThuoc
	order by C1.DonGia asc
end
------------------tìm kiếm theo tên thuốc---------------------------------------
create proc proc_TimKiemTheoTen(@ten nvarchar(max))
as begin
	select TenThuoc,CongDung,ThanhPhan,DangThuoc,NgaySanXuat,HanSuDung,C1.DonGia,C2.DonGia 
	from THUOC T 
	inner join LOTHUOC L on T.MaLoThuoc = L.MaLoThuoc
	inner join CHITIETPHIEUNHAP C1 on T.MaThuoc = C1.MaThuoc 
	inner join CHITIETPHIEUXUAT C2 on T.MaThuoc = C2.MaThuoc
	where T.TenThuoc = @ten
end
------------------tìm kiếm theo thời hạn sản xuất và sử dụng thuốc---------------------------------------
create proc proc_TimKiemTheoThoiHan (@date1 datetime, @date2 datetime)
as begin
	select TenThuoc,CongDung,ThanhPhan,DangThuoc,NgaySanXuat,HanSuDung,C1.DonGia,C2.DonGia 
	from THUOC T 
	inner join LOTHUOC L on T.MaLoThuoc = L.MaLoThuoc
	inner join CHITIETPHIEUNHAP C1 on T.MaThuoc = C1.MaThuoc 
	inner join CHITIETPHIEUXUAT C2 on T.MaThuoc = C2.MaThuoc
	where (NgaySanXuat <= @date1) and (HanSuDung >= @date2)
end
------------------tìm kiếm theo tên thuốc và thời hạn sản xuất và sử dụng thuốc---------------------------------------
create proc proc_TimKiemTheoTenVaThoiHan (@ten nvarchar(max), @date1 datetime, @date2 datetime)
as begin
	select TenThuoc,CongDung,ThanhPhan,DangThuoc,NgaySanXuat,HanSuDung,C1.DonGia,C2.DonGia 
	from THUOC T 
	inner join LOTHUOC L on T.MaLoThuoc = L.MaLoThuoc
	inner join CHITIETPHIEUNHAP C1 on T.MaThuoc = C1.MaThuoc 
	inner join CHITIETPHIEUXUAT C2 on T.MaThuoc = C2.MaThuoc
	where (NgaySanXuat <= @date1) and (HanSuDung >= @date2) and (T.TenThuoc = @ten)
end

-------------------end form tìm kiếm--------------------------------------


-------------------form thống kê, báo cáo--------------------------------------
-------------------thống kê các thuốc đã nhập về--------------------------------------
create proc proc_ThuocNhap(@start date, @end date)
as begin
	select MaLoThuoc,TenNhaCungCap,TenThuoc,DangThuoc,SoLuong,DonGia,SUM(DonGia*SoLuong) ThanhTien
	from THUOC T, PHIEUNHAP P, CHITIETPHIEUNHAP C, NHACUNGCAP N
	where T.MaThuoc = C.MaThuoc and P.MaPhieuNhap = C.MaPhieuNhap and P.MaNhaCungCap = N.MaNhaCungCap and (NgayNhap between @start and @end)
	group by MaLoThuoc, TenNhaCungCap, TenThuoc, DangThuoc, SoLuong, DonGia
end      
-------------------thống kê các thuốc đã bán ra--------------------------------------
create proc proc_ThuocBan(@start date, @end date)
as begin
	select MaLoThuoc,TenThuoc,DangThuoc,SoLuong,DonGia,SUM(DonGia*SoLuong) ThanhTien
	from THUOC T, PHIEUXUAT P, CHITIETPHIEUXUAT C
	where T.MaThuoc = C.MaThuoc and P.MaPhieuXuat = C.MaPhieuXuat and (NgayXuat between @start and @end)
	group by MaLoThuoc, TenThuoc, DangThuoc, SoLuong, DonGia
end
-------------------thống kê các thuốc còn tồn trong kho--------------------------------------
create procedure proc_ThongKeTon 
as begin
	select MaLoThuoc,TenNhaCungCap,TenThuoc,DangThuoc,DonGia,SoLuongTon
	from THUOC T, PHIEUNHAP P, CHITIETPHIEUNHAP C, NHACUNGCAP N
	where T.MaThuoc = C.MaThuoc and P.MaPhieuNhap = C.MaPhieuNhap and P.MaNhaCungCap = N.MaNhaCungCap
end
-------------------thống kê các thuốc đã hết hạn--------------------------------------
create procedure proc_ThongKeHetHan 
as begin
	select T.MaLoThuoc,TenThuoc,DangThuoc,NgaySanXuat,HanSuDung,SoLuongTon
	from THUOC T, LOTHUOC L
	where T.MaLoThuoc = L.MaLoThuoc and HanSuDung - GETDATE() < 0 
end
-------------------doanh thu của nhà thuốc--------------------------------------
--chức năng thống kê doanh thu theo từng tháng--------------------
--function tách phần tháng và phần năm
create function DOANHTHUTHANG(@date date)
returns int
as begin
	declare @month int = datepart(MONTH,@date)
	declare @year int = datepart(YEAR,@date)
	if not exists (select * from PHIEUXUAT where datepart(month,NgayXuat)=@month and datepart(year,NgayXuat)=@year)
		return 0
	else
		declare @a int = 0 
		select @a = sum(Tong)
		from PHIEUXUAT
		where datepart(month,NgayXuat)=@month and datepart(year,NgayXuat)=@year
		return @a
end
--procedure xuất ra thời gian và doanh thu của tháng đó
create proc DTThang(@ngay date)
as begin
	select DISTINCT MONTH(@ngay) as N'Tháng',YEAR(@ngay) as N'Năm',dbo.DOANHTHUTHANG(@ngay) as N'Doanh Thu'
	from PHIEUXUAT
end
--procedure đưa ra thông tin doanh thu tổng
create proc DTThang0
as begin
	select DISTINCT MONTH(NgayXuat) as N'Tháng',YEAR(NgayXuat) as N'Năm',dbo.DOANHTHUTHANG(NgayXuat) as N'Doanh Thu'
	from PHIEUXUAT
end
exec dbo.DTThang0
--chức năng thống kê doanh thu theo từng năm
--function tách phần năm
create function DOANHTHUNAM(@date date)
returns int
as begin
	declare @year int = datepart(YEAR,@date)
	if not exists (select * from PHIEUXUAT where datepart(year,NgayXuat)=@year)
		return 0
	else
		declare @a int = 0 
		select @a = sum(Tong)
		from PHIEUXUAT
		where datepart(year,NgayXuat)=@year
		return @a
end
--procedure xuất ra thời gian và doanh thu của năm đó
create proc DTNam (@ngay date)
as begin
	select DISTINCT YEAR(@ngay) as N'Năm',dbo.DOANHTHUNAM(@ngay) as N'Doanh thu'
	from PHIEUXUAT 
end
-------------------end form thống kê, báo cáo--------------------------------------