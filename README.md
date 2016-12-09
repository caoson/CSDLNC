"# CSDLNC" 
----------------
## Hướng dẫn cài đặt project
### Điều kiện tiên quyết: Tất cả các thành viên phải có tài khoản github của riêng mình.
### Các bước cài đặt:
    * 1. Đi đến trang: [link project](https://github.com/bistuido/CSDLNC)
    * 2. Click vào Fork để copy project về github của riêng mình.
    * 3. Quay về trang Github của mình và Clone project vừa Fork về.
    * 4. Mở cmd của thư mục vừa clone về máy mình, gõ câu lệnh sau: **git remote add upstream https://github.com/bistuido/CSDLNC.git**.
    * 5. Gõ tiếp **git remote -v** để kiểm tra xem đã tồn tại remote origin và remote upstream hay chưa? Nếu có đủ rồi thì OK.
    * 6. Tạo branch và checkout vào branch tên là **develope**.

### Quy trình làm việc
    * 1. Tạo branch và chekout vào branch có tên được đặt như sau:
        - Thắng: db_thangpv_actionName1 -> thay actionName1 bằng tên của Store proceduce đang định làm.
        - Sơn: db_sonnc_actionName1 -> thay actionName1 bằng tên của Store proceduce đang định làm.
        - Tùng: api_tungnt_actionName1 -> thay actionName1 bằng tên của API đang định làm.
        - Bách: ui_bachdv_actionName1 -> thay actionName1 bằng tên của UI đang định làm.

    * 2. Thực hiện công việc của mình
    * 3. Khi hoàn thành thì git push lên remote origin.
    * 4. Tiếp theo vào trang [link project](https://github.com/bistuido/CSDLNC) để click vào Compare and pull request, tạo merge request và thông báo qua Facebook Messenger cho Bachdv.
    * 5. Sau khi Bachdv accept merge request thì quay về project trên máy của mình gõ: 
        **git checkout develope**
        **git fetch upstream**
        **git rebase upstream/develope**
        sau đó quay lại bước 1.

## Mô tả:
### Thư mục DB: chứa các file script thao tác với database của project:
    * CREATE_DATABASE.sql -> chứa script tạo database diagram, script insert dữ liệu mẫu cho tất cả các bảng.
    * USP_actionName1.sql -> chứa script tạo store proceduce có tên là **actionName1**, USP là viết tắt của User Store Proceduce. 
    Cách đặt tên này áp dụng cho các store proceduce khác. Mỗi store proceduce viết ra 1 file.

    => Viết xong 1 chức năng lập tức push lên git và yêu cầu merge request để người khác còn làm.
 
### Thư mục API: chứa C# API project
    * Sử dụng các store proceduce(các file USP_actionName1.sql) đã viết ở trong thư mục DB để viết API tương ứng với từng store proceduce.
    
    => Khi 1 API được hoàn thành lập tức push lên git và yêu cầu merge request để người khác còn làm.

### Thư mục UI: chứa UI của project

    

