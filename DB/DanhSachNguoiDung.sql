/* slect toan bo nhan vien*/
CREATE PROCEDURE spDanhSachNguoiDung
AS
BEGIN
		SELECT *
		FROM NHANVIEN nv
		WHERE  nv.QUYEN = 0
END