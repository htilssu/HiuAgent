# Giao Diện Quản Lý Lịch Agent

## Tổng Quan
Hệ thống quản lý lịch Agent với giao diện hiện đại, thân thiện và chuyên nghiệp.

## Tính Năng Chính

### 1. **Giao Diện Chính (Calendar View)**
- ✅ Lịch tháng với lưới 7x6 (7 ngày x 6 tuần)
- ✅ Hiển thị các ngày trong tháng với màu sắc phân biệt
- ✅ Đánh dấu ngày hôm nay với gradient màu tím
- ✅ Hiển thị sự kiện ngay trên mỗi ngày
- ✅ Phân loại sự kiện theo màu sắc (Meeting, Training, Work, Personal)

### 2. **Điều Hướng Lịch**
- ✅ Nút "Tháng trước" / "Tháng sau" để chuyển tháng
- ✅ Nút "Hôm nay" để quay về ngày hiện tại
- ✅ Hiển thị tên tháng và năm bằng tiếng Việt

### 3. **Quản Lý Sự Kiện**
- ✅ Tạo sự kiện mới với nút "Tạo sự kiện"
- ✅ Xem chi tiết sự kiện khi click vào ngày
- ✅ Sidebar hiển thị chi tiết các sự kiện trong ngày
- ✅ Phân loại sự kiện:
  - 🔵 **Meeting** (Họp): Màu xanh dương
  - 🟣 **Training** (Đào tạo): Màu tím
  - 🟠 **Work** (Công việc): Màu cam
  - 🔴 **Personal** (Cá nhân): Màu hồng

### 4. **Chi Tiết Sự Kiện**
Mỗi sự kiện hiển thị:
- ⏰ Thời gian
- 📝 Tiêu đề
- 📄 Mô tả chi tiết
- ✏️ Nút "Sửa"
- 🗑️ Nút "Xóa"

## Thiết Kế Giao Diện

### Màu Sắc Chủ Đạo
- **Primary Gradient**: `#667eea` → `#764ba2` (Tím gradient)
- **Background**: Trắng sáng
- **Border**: `#e0e0e0` (Xám nhạt)

### Typography
- **Font**: Helvetica Neue, Helvetica, Arial, sans-serif
- **Tiêu đề chính**: 2rem, bold, gradient
- **Tiêu đề phụ**: 0.95rem, regular

### Hiệu Ứng
- ✨ Hover effects với transform và shadow
- 🎨 Gradient backgrounds
- 🔄 Smooth transitions (0.3s ease)
- 📱 Responsive design cho mobile

## Cấu Trúc File

```
HiuAgent.Web/
├── Components/
│   ├── Pages/
│   │   └── Calendar.razor          # Component chính
│   └── Layout/
│       └── NavMenu.razor            # Menu điều hướng (đã cập nhật)
└── wwwroot/
    └── calendar.css                 # Styles cho calendar
```

## Responsive Design

### Desktop (> 1200px)
- Hiển thị đầy đủ tất cả tính năng
- Sidebar rộng 400px
- Lưới lịch tối ưu

### Tablet (768px - 1200px)
- Sidebar rộng 350px
- Thu gọn một số khoảng cách

### Mobile (< 768px)
- Sidebar toàn màn hình
- Header chuyển sang dạng cột
- Thu nhỏ kích thước cell
- Tối ưu font size

## Hướng Dẫn Sử Dụng

### Xem Lịch
1. Truy cập menu "Lịch Agent"
2. Xem các sự kiện được hiển thị trên lịch
3. Click vào ngày để xem chi tiết

### Điều Hướng
1. Sử dụng nút `<` và `>` để chuyển tháng
2. Click "Hôm nay" để về ngày hiện tại

### Xem Chi Tiết Sự Kiện
1. Click vào một ngày trên lịch
2. Sidebar sẽ hiện ra bên phải
3. Xem danh sách sự kiện trong ngày
4. Click nút X để đóng sidebar

### Tạo/Sửa/Xóa Sự Kiện
1. Click nút "Tạo sự kiện" (chức năng sẽ được hoàn thiện)
2. Click "Sửa" trên event card để chỉnh sửa
3. Click "Xóa" để xóa sự kiện

## Tính Năng Sắp Tới

- [ ] Modal tạo/sửa sự kiện
- [ ] Kéo thả sự kiện
- [ ] Đồng bộ với calendar API (Google Calendar, Outlook)
- [ ] Nhắc nhở tự động
- [ ] Lọc theo loại sự kiện
- [ ] Tìm kiếm sự kiện
- [ ] Export lịch (PDF, iCal)
- [ ] Recurring events (sự kiện lặp lại)
- [ ] Chia sẻ lịch với team

## Technical Stack

- **Framework**: Blazor Server (ASP.NET Core 8.0)
- **Language**: C# 12
- **Styling**: Custom CSS3 với Flexbox/Grid
- **Icons**: Bootstrap Icons
- **Localization**: Vietnamese (vi-VN)

## Performance

- ⚡ Render tối ưu với Blazor component lifecycle
- 🎯 Chỉ re-render khi state thay đổi
- 💾 Caching cho calendar grid
- 🚀 Lazy loading cho events

---

**Phiên bản**: 1.0.0  
**Ngày tạo**: 2024  
**Tác giả**: HiuAgent Team
