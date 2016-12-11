/* Lay danh sach cong tac minh tao cho nguoi khac*/
CREATE PROCEDURE spDanhSachCongTacDuocTao
@MANHANVIEN INT
AS
BEGIN
	SELECT * 
	FROM LICHCONGTAC	
	WHERE NGUOITAO = @MANHANVIEN 
END	
