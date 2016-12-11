/* slect toan bo quan tri vien*/
CREATE PROCEDURE spDanhSachQuanTriVien
AS
BEGIN
		SELECT *
		FROM NHANVIEN nv
		WHERE  nv.QUYEN = 1
END