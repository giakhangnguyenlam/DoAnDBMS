USE dbms_final_proj
GO

--<<================================================Khách hàng(dbo.khachhang)===============================================>>
-- kiểm tra khách hàng đã tồn tại hay chưa nếu có thì rollback
Create TRIGGER tg_ThemKhachHang ON dbo.khachhang INSTEAD OF INSERT
As
	DECLARE @cid VARCHAR(20), @count int
	SELECT @cid = cid FROM inserted
	SELECT @count = COUNT(*) FROM dbo.khachhang WHERE @cid = cid


	IF(@count = 0) 
		BEGIN
			INSERT khachhang
			SELECT *
			FROM inserted
		END
	ELSE
		BEGIN
			print N'khách hàng đã tồn tại'
			rollback tran;
		END
Go
--xóa trigger
--drop trigger tg_ThemKhachHang
go

--Thêm khách hàng
Create PROC pro_ThemKhachHang (@cid VARCHAR(20), @fname NVARCHAR(50), @lname NVARCHAR(50))
AS
BEGIN
	
	INSERT INTO dbo.khachhang(cid, fname, lname) VALUES (@cid, @fname, @lname)
END
Go

--chỉnh sửa khách hàng
create PROC pro_ChinhSuaKhachHang(@cid VARCHAR(20), @fname NVARCHAR(50), @lname NVARCHAR(50))
AS
BEGIN
	UPDATE dbo.khachhang SET fname=@fname, lname=@lname WHERE cid=@cid
END
GO

--Xóa khách hàng
Alter PROC pro_XoaKhachHang(@cid VARCHAR(20))
AS
BEGIN Transaction
	DELETE FROM dbo.sohuuxe WHERE oid=@cid
	DELETE FROM dbo.hopdong WHERE cid=@cid
	DELETE FROM dbo.khachhang WHERE cid=@cid
Commit
GO

--Tìm kiếm khách hàng
Create function func_TimKiemKhachHang(@lname NVARCHAR(50))
returns table
As return
	Select * from dbo.khachhang WHERE lname LIKE '%' + @lname + '%'
GO
--Load tất cả các khách hàng
Create function func_TatCaKhachHang ()
returns table
As return
	Select * from dbo.khachhang
GO

--xóa procedure
--drop proc pro_ThemKhachHang
go



--Test thử
exec pro_ThemKhachHang 'a141', 'abc', 'xyz'
go
exec pro_XoaKhachHang 'a141'
go
Select * From dbo.khachhang
Go







--<<=============================================================Xe(dbo.xe và dbo.sohuuxe)==========================================>>

--Thực hiện thêm xe và thêm chủ sỡ hữu của xe
CREATE PROC pro_ThemXe (@bienso VARCHAR(20), @loaixe NVARCHAR(50), @hieuxe NVARCHAR(50), @hinhanh IMAGE, @cosan INT, @oid VARCHAR(20))
AS
BEGIN TRANSACTION
	INSERT INTO dbo.xe(bienso, loaixe, hieuxe, hinhanh, cosan) VALUES (@bienso, @loaixe, @hieuxe, @hinhanh, @cosan)
	INSERT INTO dbo.sohuuxe(bienso, oid) VALUES (@bienso, @oid)
COMMIT	
GO

--Xóa xe
Create PROC pro_XoaXe(@bienso VARCHAR(20))
AS
BEGIN TRANSACTION
	DELETE FROM dbo.sohuuxe WHERE bienso=@bienso
	DELETE FROM dbo.xe WHERE bienso=@bienso
COMMIT
GO

--Lấy danh sách xe có thể cho thuê
Create function func_DanhSachThueXe()
returns table
As return
	Select * from dbo.xe Where cosan=1
go


--Test thử
exec pro_ThemXe 'p123','xe may','lead', '12312312313', 1, 'a123'
Go
Select * From dbo.xe
Select * From dbo.sohuuxe
Select * from dbo.chitiethd
Select * from dbo.hopdong
go




--<<========================hợp đồng(dbo.chitiethopdong và dbo.hopdong)==================================================>>>
--Thêm một hợp đồng mới thì đầu tiên thêm vào chitiethopdong rùi thêm vào tiếp hopdong
Alter proc pro_HopDongMoi(@loaihd TINYINT, @ngayhd DATE, @ngayhieuluc DATE, @ngayhethan DATE, @trigiahd MONEY, @cid VARCHAR(20), @bienso VARCHAR(20))
AS
Begin Transaction
	INSERT INTO dbo.chitiethd (loaihd, ngayhd, ngayhieuluc, ngayhethan, trigiahd) Values (@loaihd, @ngayhd, @ngayhieuluc, @ngayhethan, @trigiahd)
	declare @sohd INT
	Select @sohd = Max(sohd) From dbo.chitiethd
	INSERT INTO dbo.hopdong(sohd, cid, bienso) VALUES (@sohd, @cid, @bienso)
Commit
Go

--Xóa hợp đồng
Create proc pro_XoaHopDong(@sohd int)
AS
Begin Transaction
	Delete from dbo.hopdong Where sohd=@sohd
	Delete from dbo.chitiethd Where sohd=@sohd
commit
go


--Thêm xe vào danh sách cho thuê
Create proc pro_ThemXeVaoDanhSachChoThue(@bienso VARCHAR(20), @loaixe NVARCHAR(50), @hieuxe NVARCHAR(50), @hinhanh IMAGE, @oid VARCHAR(20), @ngayhd DATE, @ngayhieuluc DATE, @ngayhethan DATE, @trigiahd MONEY)
AS
Begin Transaction
	Exec pro_ThemXe @bienso, @loaixe, @hieuxe, @hinhanh, 1, @oid
	Exec pro_HopDongMoi 1, @ngayhd, @ngayhieuluc, @ngayhethan, @trigiahd, @oid, @bienso
Commit
go


--Chỉnh sửa danh sách cho thuê
Alter proc pro_ChinhSuaDanhSachChoThue(@bienso VARCHAR(20), @loaixe NVARCHAR(50), @hieuxe NVARCHAR(50), @hinhanh IMAGE, @ngayhd DATE, @ngayhieuluc DATE, @ngayhethan DATE, @trigiahd MONEY)
As
Begin transaction
	update dbo.xe set loaixe=@loaixe, hieuxe=@hieuxe, hinhanh=@hinhanh Where bienso=@bienso
	declare @sohd int
	Select @sohd = hopdong.sohd From dbo.hopdong, dbo.chitiethd Where bienso=@bienso 
	Update dbo.chitiethd Set ngayhd=@ngayhd, ngayhieuluc=@ngayhieuluc, ngayhethan=@ngayhethan, trigiahd=@trigiahd Where sohd=@sohd
commit
go

--Bảng chỉnh sửa danh sách cho thuê
create function func_BangChinhSuaDanhSachChoThue()
Returns table
As return
	Select xe.bienso, loaixe, hieuxe, hinhanh, ngayhd, ngayhieuluc, ngayhethan, trigiahd 
	From dbo.xe, dbo.hopdong, dbo.chitiethd 
	Where xe.bienso=hopdong.bienso AND hopdong.sohd = chitiethd.sohd
go

--Tìm kiếm trong bảng chỉnh sửa danh sách cho thuê
Create function func_TimKiemTrongBangChinhSuaDanhSachChoThue(@bienso VARCHAR(20))
Returns table
As return 
	Select * from func_BangChinhSuaDanhSachChoThue() Where bienso like '%' + @bienso +'%'
go


--Thêm vào danh sách thuê
Alter proc pro_ThemVaoDanhSachThue(@ngayhd DATE, @ngayhieuluc DATE, @ngayhethan DATE, @trigiahd MONEY, @cid VARCHAR(20), @bienso VARCHAR(20))
AS
Begin Transaction
	Exec pro_HopDongMoi 2, @ngayhd, @ngayhieuluc, @ngayhethan, @trigiahd, @cid, @bienso
	Update dbo.xe Set cosan = 0 Where bienso=@bienso
Commit
go

--Bảng xe chưa được thuê
Alter function func_XeChuaDuocThue()
returns table
As return 
	Select xe.bienso, loaixe, hieuxe, hinhanh, ngayhethan from dbo.xe, dbo.hopdong, dbo.chitiethd  Where cosan=1 AND xe.bienso = hopdong.bienso AND hopdong.sohd = chitiethd.sohd
go

--Bảng tìm kiếm xe chưa được thuê
Create function func_TimKiemXeChuaDuocThue(@hieuxe NVARCHAR(50))
returns table
As return
	Select * from func_XeChuaDuocThue() Where hieuxe like '%' + @hieuxe + '%'
go


--<<====================================================Thanh toán hợp đồng====================================================>>
--thực hiện thanh toán hợp đồng
Alter proc pro_ThemThanhToanHopDong(@sohd int, @fname NVARCHAR(50), @lname NVARCHAR(50), @thoigiantt DATETIME, @sotien MONEY)
AS
Begin
	Insert into dbo.thanhtoanhd (sohd, fname, lname, thoigiantt, sotien) Values (@sohd, @fname, @lname, @thoigiantt, @sotien)
end
go

--Thanh toán hợp đồng thuê
Alter proc pro_ThemThanhToanHopDongThue(@sohd int, @fname NVARCHAR(50), @lname NVARCHAR(50), @thoigiantt DATETIME, @sotien MONEY)
AS
Begin transaction
	declare @bienso VARCHAR(20)
	Select @bienso = bienso  From hopdong Where sohd = @sohd
	Exec pro_ThemThanhToanHopDong @sohd, @fname, @lname, @thoigiantt, @sotien
	update dbo.xe set cosan = 1 Where bienso = @bienso
	Delete From dbo.hopdong Where sohd=@sohd 
commit
go

--Thanh toán hợp đồng cho thuê
Alter proc pro_ThemThanhToanHopDongChoThue(@sohd int, @fname NVARCHAR(50), @lname NVARCHAR(50), @thoigiantt DATETIME, @sotien MONEY)
As
Begin Transaction
	declare @bienso VARCHAR(20)
	Select @bienso = bienso From hopdong Where sohd = @sohd
	Exec pro_ThemThanhToanHopDong @sohd, @fname, @lname, @thoigiantt, @sotien
	Delete From dbo.hopdong Where sohd=@sohd 
	Exec pro_XoaXe @bienso
commit
go


--Bảng thanh toán 
Alter function func_BangThanhToan()
returns table
As
return
	Select khachhang.cid, fname, lname, loaixe, hieuxe, xe.bienso, hinhanh, ngayhd, trigiahd, ngayhieuluc, ngayhethan, loaihd, hopdong.sohd
	From dbo.khachhang, dbo.xe, dbo.chitiethd, dbo.hopdong
	Where khachhang.cid = hopdong.cid AND xe.bienso = hopdong.bienso AND chitiethd.sohd = hopdong.sohd
go


--Sử dụng Trigger để trả xe cho chủ (trả xe khi xe có trong kho)
Create Trigger tg_TraXeChoChuXe on dbo.hopdong for delete
AS
Begin
	Declare @chuxe int, @sohd int, @bienso VARCHAR(20), @oid VARCHAR(20), @cosan int
	Select @sohd=sohd, @oid=cid, @bienso=bienso from deleted
	--Là chủ xe
	Select @chuxe=Count(*) From dbo.sohuuxe Where bienso=@bienso AND oid=@oid
	if(@chuxe > 0)
	Begin
		Select @cosan=cosan From dbo.xe Where bienso=@bienso
		if(@cosan = 0)
			Begin
				print N'Xin lỗi! Xe không có trong kho để trả'
				rollback tran
			End
	End
End


Select * from dbo.thanhtoanhd
go
Exec pro_ThemThanhToanHopDongThue 1006, 'khang', 'nguyen', '2021-01-03 09:47:51.347', 10000
Select * From dbo.thanhtoanhd
