# 🔥 Berber Demo - Modern Randevu Sistemi

![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![License](https://img.shields.io/badge/license-MIT-green)
![Status](https://img.shields.io/badge/status-active-brightgreen)
![Live Demo](https://img.shields.io/badge/demo-live-success)

**🚀 [Canlı Demo](https://barber-f934.onrender.com) | 📅 [Calendly](https://calendly.com/isgelistirme41/30min) | 🔧 [API Docs](https://barber-f934.onrender.com/swagger)**

## 🌐 Language / Dil Seçimi

**🇹🇷 [Türkçe](#türkçe-dokümantasyon) | 🇺🇸 [English](#english-documentation)**

---

## 🇹🇷 Türkçe Dokümantasyon {#türkçe-dokümantasyon}

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
- Docker (isteğe bağlı)

### Kurulum

#### 1. Proje İndirme
```bash
git clone https://github.com/CemRoot/BarberDemo.git
cd BarberDemo
```

#### 2. Environment Dosyası Hazırlama
```bash
cp .env.example .env
# .env dosyasını kendi ayarlarınıza göre düzenleyin
```

#### 3. Bağımlılıkları Yükleme ve Çalıştırma
```bash
dotnet restore
dotnet run
```

#### 4. Docker ile Çalıştırma (Alternatif)
```bash
# Tek container
docker build -t barberdemo .
docker run -p 8080:8080 barberdemo

# Docker Compose ile
docker-compose up
```

Tarayıcınızda `http://localhost:5000` adresine gidin.

## 🌐 Deploy Seçenekleri

### 1. Railway (Önerilen)
```bash
# Railway CLI ile
railway login
railway init
railway up
```

### 2. Render
1. [Render.com](https://render.com) hesabı oluşturun
2. GitHub repo'nuzu bağlayın
3. Web service olarak deploy edin
4. Environment variables'ları ayarlayın

### 3. Azure
```bash
# Azure CLI ile
az login
az webapp create --resource-group myResourceGroup --plan myAppServicePlan --name barberdemo
az webapp deployment source config --name barberdemo --resource-group myResourceGroup --repo-url https://github.com/yourusername/BarberDemo --branch main --manual-integration
```

### 4. Docker ile Deploy
```bash
# Docker Hub'a push
docker build -t yourusername/barberdemo .
docker push yourusername/barberdemo

# Herhangi bir Docker destekli platformda
docker run -p 80:8080 yourusername/barberdemo
```

## 📁 Proje Yapısı

```
BarberDemo/
├── src/                          # Kaynak kodlar
│   ├── Controllers/              # API Controllers (gelecekte)
│   ├── Data/                     # Veritabanı context
│   │   └── AppDb.cs             # Entity Framework DbContext
│   ├── Models/                   # Veri modelleri
│   │   └── AppointmentModels.cs # Randevu modelleri
│   ├── Services/                 # İş mantığı servisleri
│   │   ├── EmailService.cs      # Email servisi
│   │   └── ReminderService.cs   # Hatırlatma servisi
│   ├── Extensions/               # Extension methods
│   │   ├── ApiEndpointsExtensions.cs    # API endpoint'leri
│   │   ├── DatabaseExtensions.cs       # Veritabanı uzantıları
│   │   ├── MiddlewareExtensions.cs     # Middleware konfigürasyonu
│   │   └── ServiceExtensions.cs       # Servis konfigürasyonu
│   ├── Middleware/               # Özel middleware'ler
│   └── Configuration/            # Konfigürasyon dosyaları
├── wwwroot/                      # Statik dosyalar
│   ├── css/style.css            # Özel CSS
│   ├── js/app.js               # JavaScript
│   ├── favicon.svg             # Site ikonu
│   └── index.html              # Ana sayfa
├── tests/                        # Test dosyaları
├── scripts/                      # Deployment ve utility scriptleri
│   ├── dev-setup.sh             # Geliştirme kurulum scripti
│   ├── docker-run.sh            # Docker çalıştırma scripti
│   ├── local-deploy.sh          # Yerel deployment
│   ├── railway-deploy.sh        # Railway deployment
│   └── deploy-production.sh     # Üretim deployment
├── docs/                         # Dokümantasyon
├── bin/                          # Build çıktıları (git'te yok)
├── obj/                          # Build ara dosyaları (git'te yok)
├── Program.cs                    # Ana uygulama entry point
├── appsettings.json             # Geliştirme konfigürasyonu
├── appsettings.Production.json  # Üretim konfigürasyonu
├── .env.example                 # Örnek environment variables
├── Dockerfile                   # Docker build dosyası
├── docker-compose.yml           # Docker compose konfigürasyonu
├── .dockerignore               # Docker ignore dosyası
├── railway.json                # Railway konfigürasyonu
├── .gitignore                  # Git ignore dosyası
└── README.md                   # Bu dosya
```

## 🛠️ Geliştirme

### Hızlı Komutlar (Makefile)
```bash
make help          # Yardım menüsü
make setup         # Geliştirme ortamı kurulumu
make build         # Projeyi derle
make run           # Uygulamayı çalıştır
make test          # Testleri çalıştır
make clean         # Temizlik
make docker-build  # Docker image oluştur
make docker-run    # Docker ile çalıştır
```

### API Endpoints
- `GET /` - Ana sayfa
- `GET /api/status` - Sistem durumu
- `POST /api/appointments` - Randevu oluşturma
- `POST /api/hours` - Çalışma saatleri
- `GET /swagger` - API dokümantasyonu

### Geliştirme Scriptleri
```bash
# Geliştirme ortamı kurulumu
./scripts/dev-setup.sh

# Docker ile çalıştırma
./scripts/docker-run.sh

# Üretim deploy
./scripts/deploy-production.sh
```

### Özellik Ekleme
1. Projeyi fork edin
2. Feature branch oluşturun (`git checkout -b feature/amazing-feature`)
3. Değişiklikleri commit edin (`git commit -m 'feat: add amazing feature'`)
4. Branch'i push edin (`git push origin feature/amazing-feature`)
5. Pull Request gönderin

Detaylar için [CONTRIBUTING.md](CONTRIBUTING.md) dosyasına bakın.

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

### Environment Variables
Production ortamında `.env` dosyası oluşturun:
```bash
cp .env.example .env
# .env dosyasını düzenleyin
```

## 🔒 Güvenlik

### Önemli Notlar
- `.env` dosyası Git'e commit edilmez
- Production'da güvenli SMTP ayarları kullanın
- API key'leri environment variables ile saklayın
- Docker container'ları non-root user ile çalıştırın

### Production Checklist
- [ ] HTTPS kullanın
- [ ] Environment variables'ları ayarlayın
- [ ] Log seviyelerini ayarlayın
- [ ] Health check endpoint'ini test edin
- [ ] Firewall kurallarını ayarlayın

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

## 🇺🇸 English Documentation {#english-documentation}

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
- Docker (optional)

### Installation

#### 1. Clone Project
```bash
git clone https://github.com/CemRoot/BarberDemo.git
cd BarberDemo
```

#### 2. Setup Environment File
```bash
cp .env.example .env
# Edit .env file with your settings
```

#### 3. Install Dependencies and Run
```bash
dotnet restore
dotnet run
```

#### 4. Run with Docker (Alternative)
```bash
# Single container
docker build -t barberdemo .
docker run -p 8080:8080 barberdemo

# With Docker Compose
docker-compose up
```

Visit `http://localhost:5000` in your browser.

## 🌐 Deployment Options

### 1. Railway (Recommended)
```bash
# With Railway CLI
railway login
railway init
railway up
```

### 2. Render
1. Create account at [Render.com](https://render.com)
2. Connect your GitHub repo
3. Deploy as web service
4. Set environment variables

### 3. Azure
```bash
# With Azure CLI
az login
az webapp create --resource-group myResourceGroup --plan myAppServicePlan --name barberdemo
az webapp deployment source config --name barberdemo --resource-group myResourceGroup --repo-url https://github.com/yourusername/BarberDemo --branch main --manual-integration
```

### 4. Docker Deployment
```bash
# Push to Docker Hub
docker build -t yourusername/barberdemo .
docker push yourusername/barberdemo

# Run on any Docker-supported platform
docker run -p 80:8080 yourusername/barberdemo
```

## 📁 Project Structure

```
BarberDemo/
├── src/                          # Source code
│   ├── Controllers/              # API Controllers (future use)
│   ├── Data/                     # Database context
│   │   └── AppDb.cs             # Entity Framework DbContext
│   ├── Models/                   # Data models
│   │   └── AppointmentModels.cs # Appointment models
│   ├── Services/                 # Business logic services
│   │   ├── EmailService.cs      # Email service
│   │   └── ReminderService.cs   # Reminder service
│   ├── Extensions/               # Extension methods
│   │   ├── ApiEndpointsExtensions.cs    # API endpoints
│   │   ├── DatabaseExtensions.cs       # Database extensions
│   │   ├── MiddlewareExtensions.cs     # Middleware configuration
│   │   └── ServiceExtensions.cs       # Service configuration
│   ├── Middleware/               # Custom middlewares
│   └── Configuration/            # Configuration files
├── wwwroot/                      # Static files
│   ├── css/style.css            # Custom CSS
│   ├── js/app.js               # JavaScript
│   ├── favicon.svg             # Site icon
│   └── index.html              # Main page
├── tests/                        # Test files
├── scripts/                      # Deployment and utility scripts
│   ├── dev-setup.sh             # Development setup script
│   ├── docker-run.sh            # Docker run script
│   ├── local-deploy.sh          # Local deployment
│   ├── railway-deploy.sh        # Railway deployment
│   └── deploy-production.sh     # Production deployment
├── docs/                         # Documentation
├── bin/                          # Build outputs (not in git)
├── obj/                          # Build intermediate files (not in git)
├── Program.cs                    # Main application entry point
├── appsettings.json             # Development configuration
├── appsettings.Production.json  # Production configuration
├── .env.example                 # Example environment variables
├── Dockerfile                   # Docker build file
├── docker-compose.yml           # Docker compose configuration
├── .dockerignore               # Docker ignore file
├── railway.json                # Railway configuration
├── .gitignore                  # Git ignore file
└── README.md                   # This file
```

## 🛠️ Development

### Quick Commands (Makefile)
```bash
make help          # Show help menu
make setup         # Setup development environment
make build         # Build project
make run           # Run application
make test          # Run tests
make clean         # Clean build artifacts
make docker-build  # Build Docker image
make docker-run    # Run with Docker
```

### API Endpoints
- `GET /` - Home page
- `GET /api/status` - System status
- `POST /api/appointments` - Create appointment
- `POST /api/hours` - Working hours
- `GET /swagger` - API documentation

### Development Scripts
```bash
# Setup development environment
./scripts/dev-setup.sh

# Run with Docker
./scripts/docker-run.sh

# Production deployment
./scripts/deploy-production.sh
```

### Contributing
1. Fork the repository
2. Create feature branch (`git checkout -b feature/amazing-feature`)
3. Commit changes (`git commit -m 'feat: add amazing feature'`)
4. Push branch (`git push origin feature/amazing-feature`)
5. Submit Pull Request

See [CONTRIBUTING.md](CONTRIBUTING.md) for detailed guidelines.

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

### Environment Variables
Create `.env` file in production:
```bash
cp .env.example .env
# Edit .env file with your settings
```

## 🔒 Security

### Important Notes
- `.env` file is not committed to Git
- Use secure SMTP settings in production
- Store API keys in environment variables
- Run Docker containers with non-root user

### Production Checklist
- [ ] Use HTTPS
- [ ] Configure environment variables
- [ ] Set appropriate log levels
- [ ] Test health check endpoint
- [ ] Configure firewall rules

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
