/* lay danh sach nhiem vu con cua mot cong tac thuoc mot cong tac*/
CREATE PROCEDURE spDanhSachNhiemVuCon
@MAPHANCONG INT
AS
BEGIN
	SELECT *
	FROM NHIEMVU
	WHERE MAPHANCONG = @MAPHANCONG
		
END	

