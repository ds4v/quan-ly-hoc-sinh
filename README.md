# Phần mềm Quản lý học sinh THPT

## Giới thiệu

Phần mềm được xây dựng lại từ sản phẩm [Phẩn mềm quản lý điểm học điểm học sinh](https://github.com/18520339/quan-ly-hoc-sinh/blob/main/Original/QLHocSinhTHPTv3.0.zip) của anh [Nguyễn Hoàng Tùng](mailto:hoangtung@inbox.com) với các cải tiến mới:

-   Kiến trúc:
    -   Xây dựng theo mô hình 3 layers: **BUS**, **DAO**, **DTO**
    -   Sử dụng đối tượng **Data Provider** để tạo các kết nối, tương tác với CSDL sử dụng `ADO.NET`
    -   Thiết kế các đối tượng trong **BUS** và **DAO** theo Design Pattern `Singleton`
-   Cơ sở dữ liệu:
    -   Xây dựng CSDL trên Cloud với [Azure SQL Database](https://docs.microsoft.com/vi-vn/azure/azure-sql/database/sql-database-paas-overview)
    -   Sử dụng **Procedure** cho các tác vụ phức tạp lên CSDL
-   Chức năng:
    -   Mã hóa mật khẩu người dùng
    -   Đóng gói và cập nhật phần mềm tự động với [Squirrel.Windows](https://github.com/Squirrel/Squirrel.Windows)
-   Sửa lỗi:
    -   Vẫn có thể sử dụng tab đang bật dù đã đăng xuất
    -   ReportViewer không hiển thị giá trị

## Cách sử dụng

1.  Tạo tài khoản [Microsoft Azure](https://azure.microsoft.com/en-us/)
2.  Tiến hành tạo **Azure SQL Database** theo [hướng dẫn](https://docs.microsoft.com/vi-vn/azure/azure-sql/database/single-database-create-quickstart)
3.  Tạo các Table và Procedure tương ứng cho **Azure SQL Database**:
    -   Copy nội dụng file [Scripts.sql](https://github.com/18520339/quan-ly-hoc-sinh/blob/main/DATABASE/Scripts.sql) vào **Query editor (preview)** và bấm **Run**.
    -   Ngoài ra, có thể thực hiện trên [SQL Server Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms) với tên và tài khoản Server đã tạo
4.  Copy **Connection Strings** của `ADO.NET (SQL authentication)` tại mục **Settings** của **Azure SQL Database** và gán giá trị này cho biến **connectionString** trong file [DataProvider.cs](https://github.com/18520339/quan-ly-hoc-sinh/blob/main/DAO/DataProvider.cs)

## Tham khảo

-   [Lập trình phần mềm Quản lý quán cafe với C# Winform](https://www.howkteam.vn/course/lap-trinh-phan-mem-quan-ly-quan-cafe-voi-c-winform-24)
-   [Quickstart: Create an Azure SQL Database single database](https://docs.microsoft.com/en-us/azure/azure-sql/database/single-database-create-quickstart)
-   [Microsoft ADO.NET for SQL Server](https://docs.microsoft.com/en-us/sql/connect/ado-net/microsoft-ado-net-sql-server?view=sql-server-ver15)
-   [Tutorial: Design a relational database in Azure SQL Database using SSMS](https://docs.microsoft.com/en-us/azure/azure-sql/database/design-first-database-tutorial)
