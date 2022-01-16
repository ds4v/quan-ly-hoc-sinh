# Phần mềm Quản lý học sinh THPT

<p align="center"><img src='https://github.com/18520339/quan-ly-hoc-sinh/blob/main/image/demo.png?raw=true' /></p>

## Giới thiệu

Sản phẩm được xây dựng lại từ [Phần mềm quản lý điểm học sinh](https://github.com/18520339/quan-ly-hoc-sinh/tree/main/Original) của anh [Nguyễn Hoàng Tùng](mailto:hoangtung@inbox.com) với các cải tiến mới:

-   Kiến trúc:
    -   Xây dựng theo mô hình 3 layers: **BUS**, **DAO**, **DTO**.
    -   Sử dụng đối tượng **Data Provider** để tạo các kết nối, tương tác với CSDL bằng `ADO.NET`.
    -   Thiết kế các đối tượng trong **BUS** và **DAO** theo Design Pattern `Singleton`.
-   Cơ sở dữ liệu:
    -   Xây dựng CSDL trên Cloud với [Azure SQL Database](https://docs.microsoft.com/vi-vn/azure/azure-sql/database/sql-database-paas-overview).
    -   Sử dụng **Procedure** cho các tác vụ phức tạp lên CSDL, đồng thời hạn chế lỗi **SQL Injection**.
-   Thêm các chức năng:
    -   Mã hóa mật khẩu người dùng.
    -   Đóng gói và cập nhật phần mềm tự động với [Squirrel.Windows](https://github.com/Squirrel/Squirrel.Windows).
-   Sửa các lỗi:
    -   Vẫn có thể sử dụng tab đang bật dù đã đăng xuất.
    -   **ReportViewer** không hiển thị giá trị.

## Cách sử dụng

### Lưu ý:

-   Nếu không muốn sử dụng Cloud mà chỉ muốn tạo Database local với [SQL Server Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms) thì có thể bắt đầu xem từ bước 4.
-   [Bản cập nhật mới nhất](https://github.com/18520339/quan-ly-hoc-sinh/releases/latest) ở đây sẽ không hoạt động được do **connectionString** trong file [DataProvider.cs](https://github.com/18520339/quan-ly-hoc-sinh/blob/main/DAO/DataProvider.cs) chỉ dành riêng cho bản đóng gói này.
-   **Azure SQL Database** có tính phí.

### Các bước thiết lập:

1.  Tạo tài khoản [Microsoft Azure](https://azure.microsoft.com/en-us/). Nếu có tài khoản [Student](https://azure.microsoft.com/en-us/free/students) thì có thể sử dụng để được free.
2.  Tiến hành tạo **Azure SQL Database** theo [hướng dẫn](https://docs.microsoft.com/vi-vn/azure/azure-sql/database/single-database-create-quickstart).
3.  Vào mục **Query editor (preview)** để chuẩn bị tiến hành tạo dữ liệu. Ngoài ra, có thể thực hiện trên [SQL Server Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms) với tên và tài khoản Server đã tạo:

    <p align="center"><img src='https://github.com/18520339/quan-ly-hoc-sinh/blob/main/image/ssms.png?raw=true' /></p>

4.  Sau khi tạo Database, copy nội dung và chạy lần lượt các file: [Tables.sql](https://github.com/18520339/quan-ly-hoc-sinh/blob/main/DATABASE/Tables.sql) -> [Users.sql](https://github.com/18520339/quan-ly-hoc-sinh/blob/main/DATABASE/Users.sql) -> [Procedures.sql](https://github.com/18520339/quan-ly-hoc-sinh/blob/main/DATABASE/Procedures.sql).

5.  Copy **Connection Strings** của `ADO.NET (SQL authentication)` tại mục **Settings** của **Azure SQL Database** và gán giá trị này cho biến **connectionString** trong file [DataProvider.cs](https://github.com/18520339/quan-ly-hoc-sinh/blob/main/DAO/DataProvider.cs). Nếu chỉ sử dụng Database local thì **connectionString** sẽ là:

    ```csharp
    private string connectionString = "Data Source=(local); Initial Catalog=QuanLyHocSinh; Integrated Security=True";
    ```

6.  Đăng nhập phần mềm với 1 trong các tài khoản trong file [Users.sql](https://github.com/18520339/quan-ly-hoc-sinh/blob/main/DATABASE/Users.sql), ví dụ:

    -   Tên đăng nhập: admin
    -   Mật khẩu: 123456

7.  Nếu muốn đóng gói phần mềm như trong repository này thì có thể tham khảo [Squirrel.Windows](https://github.com/Squirrel/Squirrel.Windows). Sau khi đã đóng gói thì có thể chạy file **Setup.exe** để tiến hành cài đặt.

## Tham khảo

-   [Lập trình phần mềm Quản lý quán cafe với C# Winform](https://www.howkteam.vn/course/lap-trinh-phan-mem-quan-ly-quan-cafe-voi-c-winform-24)
-   [Quickstart: Create an Azure SQL Database single database](https://docs.microsoft.com/en-us/azure/azure-sql/database/single-database-create-quickstart)
-   [Microsoft ADO.NET for SQL Server](https://docs.microsoft.com/en-us/sql/connect/ado-net/microsoft-ado-net-sql-server?view=sql-server-ver15)
-   [Tutorial: Design a relational database in Azure SQL Database using SSMS](https://docs.microsoft.com/en-us/azure/azure-sql/database/design-first-database-tutorial)
