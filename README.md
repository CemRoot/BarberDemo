# 🔥 Berber Demo - Modern Randevu Sistemi

![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![License](https://img.shields.io/badge/license-MIT-green)
![Status](https://img.shields.io/badge/status-active-brightgreen)
![Live Demo](https://img.shields.io/badge/demo-live-success)

**🚀 [Canlı Demo](https://barber-f934.onrender.com) | 📅 [Calendly](https://calendly.com/isgelistirme41/30min) | 🔧 [API Docs](https://barber-f934.onrender.com/swagger)**

## 🌐 Language / Dil Seçimi

**🇹🇷 [Türkçe](#türkçe-dokümantasyon) | 🇺🇸 [English](#english-documentation)**

---

## 🇹🇷 Türkçe Dokümantasyon

Modern, responsive ve kullanıcı dostu berber randevu sistemi. ASP.NET Core 8 ile geliştirilmiş, Calendly entegrasyonu ile güçlendirilmiş profesyonel web uygulaması.

## ✨ Özellikler

### 🎯 **Randevu Sistemleri**
- **Calendly Entegrasyonu**: Profesyonel randevu yönetimi
- **Hızlı Randevu Formu**: Anlık randevu alma
- **Çifte Seçenek**: Hem Calendly hem de kendi formumuz
- **Responsive Tasarım**: Tüm cihazlarda mükemmel görünüm

### 🏪 **Berber Özellikleri**
- **Hizmet Paketleri**: Saç kesimi, sakal düzenleme, saç bakımı
- **Çalışma Saatleri**: Otomatik saat kontrolü
- **Fiyat Listesi**: Şeffaf fiyatlandırma
- **İletişim Bilgileri**: Kolay erişim

### 🔧 **Teknik Özellikler**
- **ASP.NET Core 8**: Modern web framework
- **Entity Framework Core**: In-memory database
- **Bootstrap 5**: Responsive UI framework
- **Font Awesome**: İkon kütüphanesi
- **Calendly API**: Profesyonel randevu sistemi

## 🚀 Canlı Demo

- **Demo Site**: [https://barber-f934.onrender.com](https://barber-f934.onrender.com)
- **Calendly**: [Randevu al](https://calendly.com/isgelistirme41/30min)
- **API Docs**: [Swagger UI](https://barber-f934.onrender.com/swagger)

## 📦 Hızlı Başlangıç

### Gereksinimler
- .NET 8.0 SDK
- Git

### Kurulum
```bash
git clone https://github.com/KULLANICI_ADINIZ/BarberDemo.git
cd BarberDemo
dotnet restore
dotnet run
```

Tarayıcınızda `http://localhost:5000` adresine gidin.

## 🌐 Deploy Seçenekleri

### 1. Railway (Önerilen)
1. [Railway.app](https://railway.app) hesabı oluşturun
2. GitHub repo'nuzu bağlayın
3. Otomatik deploy başlar

### 2. Render
1. [Render.com](https://render.com) hesabı oluşturun
2. GitHub repo'nuzu bağlayın
3. Web service olarak deploy edin

### 3. Azure
1. Azure App Service oluşturun
2. GitHub Actions ile deploy edin

## 📁 Proje Yapısı

```
BarberDemo/
├── wwwroot/                 # Static files
│   ├── css/style.css       # Custom CSS
│   ├── js/app.js           # JavaScript
│   └── index.html          # Ana sayfa
├── Program.cs              # Ana uygulama
├── appsettings.json        # Konfigürasyon
├── Dockerfile              # Docker build
├── railway.json            # Railway config
└── README.md              # Bu dosya
```

## 🛠️ Geliştirme

### API Endpoints
- `GET /` - Ana sayfa
- `GET /api/status` - Sistem durumu
- `POST /api/appointments` - Randevu oluşturma
- `POST /api/hours` - Çalışma saatleri
- `GET /swagger` - API dokümantasyonu

### Özellik Ekleme
1. Fork edin
2. Feature branch oluşturun
3. Değişiklikleri commit edin
4. Pull request gönderin

## 🎨 Customization

### Renk Teması
`wwwroot/css/style.css` dosyasında CSS variables:
```css
:root {
    --primary-color: #2c3e50;
    --secondary-color: #e74c3c;
    --accent-color: #f39c12;
}
```

### Calendly Linki
`wwwroot/js/app.js` dosyasında URL'yi güncelleyin:
```javascript
url: 'https://calendly.com/YOUR-LINK/30min'
```

## 📞 İletişim

- **Geliştirici**: [GitHub Profile](https://github.com/CemRoot)
- **Demo**: [Canlı Site](https://barber-f934.onrender.com)
- **Issues**: [GitHub Issues](https://github.com/CemRoot/BarberDemo/issues)

## 📄 Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakın.

## 🙏 Teşekkürler

- [ASP.NET Core Team](https://github.com/dotnet/aspnetcore)
- [Bootstrap Team](https://getbootstrap.com)
- [Calendly](https://calendly.com)
- [Font Awesome](https://fontawesome.com)

---

⭐ **Beğendiyseniz yıldız vermeyi unutmayın!**

---

## 🇺🇸 English Documentation

Modern, responsive and user-friendly barber appointment system. Professional web application developed with ASP.NET Core 8 and enhanced with Calendly integration.

## ✨ Features

### 🎯 **Appointment Systems**
- **Calendly Integration**: Professional appointment management
- **Quick Appointment Form**: Instant appointment booking
- **Dual Options**: Both Calendly and custom form
- **Responsive Design**: Perfect view on all devices

### 🏪 **Barber Features**
- **Service Packages**: Haircut, beard trimming, hair care
- **Working Hours**: Automatic time control
- **Price List**: Transparent pricing
- **Contact Information**: Easy access

### 🔧 **Technical Features**
- **ASP.NET Core 8**: Modern web framework
- **Entity Framework Core**: In-memory database
- **Bootstrap 5**: Responsive UI framework
- **Font Awesome**: Icon library
- **Calendly API**: Professional appointment system

## 🚀 Live Demo

- **Demo Site**: [https://barber-f934.onrender.com](https://barber-f934.onrender.com)
- **Calendly**: [Book appointment](https://calendly.com/isgelistirme41/30min)
- **API Docs**: [Swagger UI](https://barber-f934.onrender.com/swagger)

## 📦 Quick Start

### Requirements
- .NET 8.0 SDK
- Git

### Installation
```bash
git clone https://github.com/CemRoot/BarberDemo.git
cd BarberDemo
dotnet restore
dotnet run
```

Visit `http://localhost:5000` in your browser.

## 🌐 Deployment Options

### 1. Railway (Recommended)
1. Create account at [Railway.app](https://railway.app)
2. Connect your GitHub repo
3. Automatic deployment starts

### 2. Render
1. Create account at [Render.com](https://render.com)
2. Connect your GitHub repo
3. Deploy as web service

### 3. Azure
1. Create Azure App Service
2. Deploy with GitHub Actions

## 📁 Project Structure

```
BarberDemo/
├── wwwroot/                 # Static files
│   ├── css/style.css       # Custom CSS
│   ├── js/app.js           # JavaScript
│   └── index.html          # Main page
├── Program.cs              # Main application
├── appsettings.json        # Configuration
├── Dockerfile              # Docker build
├── railway.json            # Railway config
└── README.md              # This file
```

## 🛠️ Development

### API Endpoints
- `GET /` - Home page
- `GET /api/status` - System status
- `POST /api/appointments` - Create appointment
- `POST /api/hours` - Working hours
- `GET /swagger` - API documentation

### Contributing
1. Fork the repository
2. Create feature branch
3. Commit changes
4. Submit pull request

## 🎨 Customization

### Color Theme
Update CSS variables in `wwwroot/css/style.css`:
```css
:root {
    --primary-color: #2c3e50;
    --secondary-color: #e74c3c;
    --accent-color: #f39c12;
}
```

### Calendly Link
Update URL in `wwwroot/js/app.js`:
```javascript
url: 'https://calendly.com/YOUR-LINK/30min'
```

## 📞 Contact

- **Developer**: [GitHub Profile](https://github.com/CemRoot)
- **Demo**: [Live Site](https://barber-f934.onrender.com)
- **Issues**: [GitHub Issues](https://github.com/CemRoot/BarberDemo/issues)

## 📄 License

This project is licensed under the MIT License. See [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- [ASP.NET Core Team](https://github.com/dotnet/aspnetcore)
- [Bootstrap Team](https://getbootstrap.com)
- [Calendly](https://calendly.com)
- [Font Awesome](https://fontawesome.com)

---

⭐ **If you like this project, don't forget to give it a star!**
