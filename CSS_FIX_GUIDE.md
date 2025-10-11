# CSS ISOLATION FIX - BLAZOR

## ❌ Vấn Đề Ban Đầu

CSS không được apply vào components vì:
1. Sử dụng `@import` trong CSS files (Blazor không hỗ trợ tốt)
2. Inline `<link>` tags trong components (bị Blazor isolation chặn)
3. Inline `<style>` tags trong components (scope isolation)

## ✅ Giải Pháp

### 1. App.razor - Central CSS Loading

**Thay đổi**: Load TẤT CẢ CSS files trong `<head>` của `App.razor`

```html
<head>
    <!-- Google Fonts -->
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Inter:wght@400;500;600;700;800&display=swap" rel="stylesheet">
    
    <!-- Bootstrap & Icons -->
    <link rel="stylesheet" href="bootstrap/bootstrap.min.css"/>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.1/font/bootstrap-icons.css"/>
    
    <!-- App Styles -->
    <link rel="stylesheet" href="app.css"/>
    <link rel="stylesheet" href="layout.css"/>
    <link rel="stylesheet" href="home.css"/>
    <link rel="stylesheet" href="calendar.css"/>
    <link rel="stylesheet" href="HiuAgent.Web.styles.css"/>
</head>
```

**Lợi ích**:
- CSS được load globally
- Tránh Blazor CSS isolation
- Thứ tự loading rõ ràng
- Dễ maintain

### 2. app.css - Bỏ @import

**TRƯỚC:**
```css
@import url('https://fonts.googleapis.com/css2?family=Inter...');
@import url('layout.css');
```

**SAU:**
```css
/* Direct styles, no imports */
html, body {
    font-family: 'Inter', ...;
}
```

**Lý do**: Blazor không xử lý tốt `@import` trong CSS files.

### 3. Component Files - Bỏ Inline CSS

**Home.razor - TRƯỚC:**
```html
<style>
    @import url('/home.css');
</style>
```

**Home.razor - SAU:**
```html
<!-- No style tags needed -->
```

**Calendar.razor - TRƯỚC:**
```html
<link rel="stylesheet" href="calendar.css" />
```

**Calendar.razor - SAU:**
```html
<!-- No link tags needed -->
```

## 📁 File Structure

```
HiuAgent.Web/
├── Components/
│   ├── App.razor              ← Load ALL CSS here
│   ├── Layout/
│   │   └── MainLayout.razor   ← Clean, no CSS
│   └── Pages/
│       ├── Home.razor         ← Clean, no CSS
│       └── Calendar.razor     ← Clean, no CSS
└── wwwroot/
    ├── app.css                ← Base styles
    ├── layout.css             ← Layout styles
    ├── home.css               ← Home page styles
    └── calendar.css           ← Calendar styles
```

## 🎯 CSS Loading Order

1. **Google Fonts** - Font families
2. **Bootstrap CSS** - Framework styles
3. **Bootstrap Icons** - Icon fonts
4. **app.css** - Base application styles
5. **layout.css** - Header/Footer layout
6. **home.css** - Home page specific
7. **calendar.css** - Calendar page specific
8. **HiuAgent.Web.styles.css** - Blazor scoped styles (auto-generated)

## ✅ Checklist

- [x] Moved all `<link>` tags to App.razor
- [x] Removed `@import` from CSS files
- [x] Removed inline `<style>` tags from components
- [x] Removed inline `<link>` tags from components
- [x] Added Google Fonts to App.razor
- [x] Added Bootstrap Icons CDN
- [x] Verified build success
- [x] CSS files in wwwroot/

## 🚀 Testing

```bash
cd HiuAgent.Web
dotnet run
```

Open browser:
- http://localhost:5000 - Home page
- http://localhost:5000/calendar - Calendar

**Note**: If styles don't appear, hard refresh with `Ctrl+F5` (clear cache).

## 💡 Best Practices for Blazor CSS

### ✅ DO:
- Load CSS in App.razor `<head>`
- Keep CSS files in wwwroot/
- Use direct CSS, avoid @import
- Use specific class names to avoid conflicts
- Hard refresh after CSS changes

### ❌ DON'T:
- Use `<link>` tags in components
- Use `<style>` tags in components
- Use `@import` in CSS files
- Rely on CSS isolation for global styles
- Expect instant CSS updates (cache exists)

## 🔧 Troubleshooting

### CSS not applying?
1. Check browser DevTools → Network → See if CSS loaded
2. Hard refresh: `Ctrl+F5` or `Cmd+Shift+R`
3. Check file exists in wwwroot/
4. Verify link in App.razor
5. Check CSS selector specificity

### Build errors?
1. Ensure all CSS files exist in wwwroot/
2. Check no syntax errors in CSS
3. Verify App.razor syntax
4. Clean and rebuild: `dotnet clean && dotnet build`

### Styles conflict?
1. Use more specific selectors
2. Check CSS loading order
3. Use BEM naming convention
4. Avoid `!important`

## 📚 References

- [Blazor CSS Isolation](https://learn.microsoft.com/en-us/aspnet/core/blazor/components/css-isolation)
- [Blazor Static Files](https://learn.microsoft.com/en-us/aspnet/core/blazor/fundamentals/static-files)
- [CSS Best Practices](https://developer.mozilla.org/en-US/docs/Learn/CSS)

## 📝 Summary

**Problem**: CSS not applying due to Blazor isolation  
**Solution**: Load all CSS globally from App.razor  
**Result**: ✅ All styles working correctly  
**Build**: ✅ Success  
**Status**: Ready to use!
