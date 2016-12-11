/* sua phan cong*/
CREATE PROCEDURE spSuaPhanCong
@MAPHANCONG INT,@MACONGTAC INT, @MANHANVIEN INT, @VAITRO NVARCHAR(50),
@TIEUDE NVARCHAR(200), @NOIDUNG NVARCHAR(500), @TAILIEUDINHKEM VARCHAR(100),
@THOIGIANBATDAU DECIMAL(13,0) , @THOIGIANKETTHUC DECIMAL(13,0) ,@TRANGTHAI NVARCHAR(50), 
@TANSUATNHACNHO INT, @MUCDOUUTIEN INT, @DANHGIAPHANCONG NVARCHAR(100),
@NGUOITAO INT 
AS
BEGIN
	UPDATE PHANCONG
	SET 
		MACONGTAC = @MACONGTAC,
		MANHANVIEN = @MANHANVIEN,
		VAITRO = @VAITRO,
		TIEUDE = @TIEUDE,
		NOIDUNG = @NOIDUNG,
		TAILIEUDINHKEM = @TAILIEUDINHKEM,
		THOIGIANBATDAU = @THOIGIANBATDAU,
		THOIGIANKETTHUC = @THOIGIANKETTHUC,
		TRANGTHAI = @TRANGTHAI,
		TANSUATNHACNHO = @TANSUATNHACNHO,
		MUCDOUUTIEN = @MUCDOUUTIEN,
		DANHGIAPHANCONG = @DANHGIAPHANCONG,
		NGUOITAO = @NGUOITAO
	WHERE MAPHANCONG = @MAPHANCONG
		
END	
