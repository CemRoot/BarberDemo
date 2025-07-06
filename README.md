# 🔥 Berber Demo - Modern Randevu Sistemi

![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![License](https://img.shields.io/badge/license-MIT-green)
![Status](https://img.shields.io/badge/status-active-brightgreen)

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

- **Demo Site**: [Buradan erişin](https://your-railway-app.up.railway.app)
- **Calendly**: [Randevu al](https://calendly.com/isgelistirme41/30min)
- **API Docs**: [Swagger UI](https://your-railway-app.up.railway.app/swagger)

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

- **Geliştirici**: [GitHub Profile](https://github.com/KULLANICI_ADINIZ)
- **Demo**: [Canlı Site](https://your-railway-app.up.railway.app)
- **Issues**: [GitHub Issues](https://github.com/KULLANICI_ADINIZ/BarberDemo/issues)

## 📄 Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakın.

## 🙏 Teşekkürler

- [ASP.NET Core Team](https://github.com/dotnet/aspnetcore)
- [Bootstrap Team](https://getbootstrap.com)
- [Calendly](https://calendly.com)
- [Font Awesome](https://fontawesome.com)

---

⭐ **Beğendiyseniz yıldız vermeyi unutmayın!**
