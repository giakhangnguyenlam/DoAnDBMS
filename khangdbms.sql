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

--trigger khi thêm vào dbo,chitiethopdong thì thêm vào luôn dbo.hopdong


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


Alter proc pro_ThemVaoDanhSachThue(@ngayhd DATE, @ngayhieuluc DATE, @ngayhethan DATE, @trigiahd MONEY, @cid VARCHAR(20), @bienso VARCHAR(20))
AS
Begin Transaction
	Exec pro_HopDongMoi 2, @ngayhd, @ngayhieuluc, @ngayhethan, @trigiahd, @cid, @bienso
	Update dbo.xe Set cosan = 0 Where bienso=@bienso
Commit
go


Create function func_XeChuaDuocThue()
returns table
As return 
	Select * from dbo.xe Where cosan=1
go




--<<====================================================Thanh toán hợp đồng====================================================>>
--thực hiện thanh toán hợp đồng
create proc proc_ThemThanhToanHopDong(@sohd int, @fname NVARCHAR, @lname NVARCHAR, @thoigiantt DATETIME, @sotien MONEY)
AS
Begin transaction
	exec proc_XoaHopDong @sohd
	Insert into dbo.thanhtoanhd (sohd, fname, lname, thoigiantt, sotien) Values (@sohd, @fname, @lname, @thoigiantt, @sotien)
commit

