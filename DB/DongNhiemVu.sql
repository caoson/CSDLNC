/* Dong nhiem vu*/
CREATE PROCEDURE spDongNhiemVu
@MANHIEMVU INT
AS
BEGIN
	UPDATE NHIEMVU
	SET
		TRANGTHAI = 1
	WHERE MANHIEMVU = @MANHIEMVU	
END	
