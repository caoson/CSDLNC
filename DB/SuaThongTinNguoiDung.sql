/* update thong tin quan nguoi dung*/
CREATE PROCEDURE spSuaThongTinNhanVien
@MANHANVIEN int,@HOTEN NVARCHAR(50), @BIDANH NVARCHAR(50),
@GIOITINH NVARCHAR(8), @NGAYSINH DECIMAL(13,0), @QUEQUAN NVARCHAR(100),
@DIACHI NVARCHAR(100), @EMAIL VARCHAR(50), @SODIENTHOAI INT, 
@CHUCVU NVARCHAR(50), @MATKHAU NVARCHAR(300)
AS
BEGIN
	UPDATE NHANVIEN
	SET
		HOTEN= @HOTEN,
		BIDANH = @BIDANH,
		GIOITINH = @GIOITINH,
		NGAYSINH = @NGAYSINH,
		QUEQUAN = @QUEQUAN,
		DIACHI = @DIACHI,
		EMAIL = @EMAIL,
		SODIENTHOAI = @SODIENTHOAI,
		CHUCVU = @CHUCVU,
		MATKHAU = @MATKHAU
	WHERE MANHANVIEN=@MANHANVIEN
END