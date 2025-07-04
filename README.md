# Ứng dụng Nghe nhạc

Đây là một ứng dụng nghe nhạc trên máy tính để bàn được xây dựng bằng C# và Windows Forms, sử dụng Entity Framework để tương tác với cơ sở dữ liệu.

## Tính năng chính

- **Người dùng:**
  - Đăng ký và đăng nhập tài khoản.
  - Tìm kiếm bài hát, nghệ sĩ.
  - Phát nhạc.
  - Tạo và quản lý các danh sách phát (playlist) cá nhân.
- **Quản trị viên (Admin):**
  - Quản lý thư viện nhạc: thêm, sửa, xóa bài hát.
  - Quản lý bộ sưu tập (collection) và nghệ sĩ.

## Công nghệ sử dụng

- **Ngôn ngữ:** C#
- **Nền tảng:** .NET Framework 4.7.2
- **Giao diện:** Windows Forms (WinForms)
- **UI Framework:** Bunifu UI
- **Cơ sở dữ liệu:** SQL Server với Entity Framework (Database First)

## Hướng dẫn cài đặt

1.  **Clone repository:**
    ```sh
    git clone https://github.com/ngoquocanh15012004/Music-Window-Application.git
    ```
2.  **Mở dự án:**
    Mở tệp `Music Application.sln` bằng Visual Studio.

3.  **Cấu hình cơ sở dữ liệu:**
    - Mở tệp `App.config` trong dự án `Mucsic Application`.
    - Tìm đến chuỗi kết nối (connection string) trong thẻ `<connectionStrings>`.
    - Thay đổi giá trị `data source` thành tên SQL Server instance của bạn.
    - Đảm bảo cơ sở dữ liệu đã được tạo và có cấu trúc khớp với mô hình trong tệp `DatabaseEntity.edmx`.

4.  **Khôi phục Packages:**
    - Nhấp chuột phải vào Solution trong Solution Explorer và chọn "Restore NuGet Packages" để tải về các thư viện cần thiết như Entity Framework và Bunifu.

5.  **Build và Chạy:**
    - Nhấn `F5` hoặc nút "Start" trong Visual Studio để build và chạy ứng dụng.

## Cấu trúc thư mục

- `Mucsic Application/Admin/`: Chứa các form dành cho chức năng quản trị.
- `Mucsic Application/BLL/`: Lớp logic nghiệp vụ (Business Logic Layer).
- `Mucsic Application/DAL/`: Lớp truy cập dữ liệu (Data Access Layer).
- `Mucsic Application/DTO/`: Đối tượng truyền dữ liệu (Data Transfer Objects).
- `Mucsic Application/GUI/`: Các form giao diện chính cho người dùng.
