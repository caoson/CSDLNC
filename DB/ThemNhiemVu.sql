
/* insert nhiem vu*/
CREATE PROCEDURE spThemNhiemVu
@MAPHANCONG INT, @TIEUDE NVARCHAR(200), @NOIDUNG NVARCHAR(500),
@TAILIEUDINHKEM VARCHAR(100), @THOIGIANBATDAU DECIMAL(13,0), @THOIGIANKETTHUC DECIMAL(13,0),
@TRANGTHAI NVARCHAR(50), @TIENDO INT, @THOIGIANTHUCHIEN INT, 
@TANSUATNHACNHO INT, @MUCDOUUTIEN INT,
@DANHGIANHIEMVU NVARCHAR(300) 
AS
BEGIN
	INSERT INTO NHIEMVU(
			[MAPHANCONG], 
			[TIEUDE], 
			[NOIDUNG],
			[TAILIEUDINHKEM],
			[THOIGIANBATDAU],
			[THOIGIANKETTHUC],
			[TRANGTHAI],
			[TIENDO],
			[THOIGIANTHUCHIEN],
			[TANSUATNHACNHO],
			[MUCDOUUTIEN],
			[DANHGIANHIEMVU])
			VALUES (
			@MAPHANCONG,
			@TIEUDE,
			@NOIDUNG,
			@TAILIEUDINHKEM,
			@THOIGIANBATDAU,
			@THOIGIANKETTHUC,
			@TRANGTHAI,
			@TIENDO,
			@THOIGIANTHUCHIEN,
			@TANSUATNHACNHO,
			@MUCDOUUTIEN,
			@DANHGIANHIEMVU
			)
END	