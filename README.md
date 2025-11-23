<div align="center">

# ✂️ Elite Barber - Premium Randevu Sistemi

[![.NET 8.0](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](https://opensource.org/licenses/MIT)
[![Live Demo](https://img.shields.io/badge/Live-Demo-success?style=for-the-badge&logo=vercel&logoColor=white)](https://barber-f934.onrender.com)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-8.0-512BD4?style=for-the-badge&logo=.net&logoColor=white)](https://docs.microsoft.com/en-us/aspnet/core/)

**Lüks berber deneyimi için tasarlanmış modern, responsive ve kullanıcı dostu randevu yönetim platformu**

[🌐 Canlı Demo](https://barber-f934.onrender.com) • [📅 Calendly](https://calendly.com/isgelistirme41/30min) • [📚 API Docs](https://barber-f934.onrender.com/swagger) • [🐛 Issues](https://github.com/CemRoot/BarberDemo/issues)

---

</div>

## 🎯 Proje Hakkında

**Elite Barber**, modern berber salonları için geliştirilmiş, enterprise-grade bir randevu yönetim sistemidir. ASP.NET Core 8 ile inşa edilmiş bu platform, müşterilerinize sorunsuz bir randevu deneyimi sunarken, işletmenize profesyonel bir dijital varlık kazandırır.

### ✨ Temel Özellikler

#### 🎪 **Çift Katmanlı Randevu Sistemi**
- **🔥 Calendly Entegrasyonu**: Dünya standartlarında profesyonel randevu yönetimi
- **⚡ Hızlı Form Sistemi**: Anlık randevu alımı için optimize edilmiş kullanıcı deneyimi
- **🔄 Esnek Seçenekler**: Kullanıcılara hem Calendly hem de özel form ile randevu alma imkanı
- **📱 Responsive Tasarım**: Mobil, tablet ve desktop'ta kusursuz görünüm

#### 💈 **Premium Berber Özellikleri**
- **🎨 Görsel Galeri**: Profesyonel kesimlerinizi sergileyin
- **👥 Ekip Tanıtımı**: Uzman berberlerinizi müşterilerinize tanıtın
- **💎 Hizmet Kataloğu**: Detaylı hizmet açıklamaları ve şeffaf fiyatlandırma
- **⭐ Müşteri Yorumları**: Sosyal kanıt ile güven oluşturma
- **📍 Konum & İletişim**: Google Maps entegrasyonu ve hızlı iletişim

#### 🛠️ **Teknik Altyapı**
- **ASP.NET Core 8**: Microsoft'un en güncel web framework'ü
- **Entity Framework Core**: Verimli ve modern ORM çözümü
- **In-Memory Database**: Hızlı prototipleme ve geliştirme
- **Bootstrap 5.3**: Modern, mobile-first UI framework
- **Font Awesome 6**: Zengin ikon kütüphanesi
- **Calendly API**: Profesyonel randevu yönetimi
- **RESTful API**: Temiz ve dokümante edilmiş API endpoint'leri
- **Swagger/OpenAPI**: Otomatik API dokümantasyonu

---

## 🚀 Hızlı Başlangıç

### 📋 Gereksinimler

| Teknoloji | Versiyon | Açıklama |
|-----------|----------|----------|
| .NET SDK  | 8.0+     | [İndir](https://dotnet.microsoft.com/download) |
| Git       | 2.0+     | Versiyon kontrol sistemi |
| Docker    | 20.0+    | (Opsiyonel) Container desteği |

### ⚡ Kurulum

#### 1️⃣ Repoyu Klonlayın
```bash
git clone https://github.com/CemRoot/BarberDemo.git
cd BarberDemo
```

#### 2️⃣ Environment Yapılandırması
```bash
# Örnek dosyadan yeni .env oluşturun
cp .env.example .env

# .env dosyasını düzenleyin
nano .env  # veya tercih ettiğiniz editör
```

#### 3️⃣ Projeyi Çalıştırın
```bash
# Bağımlılıkları yükle
dotnet restore

# Projeyi derle
dotnet build

# Uygulamayı başlat
dotnet run
```

🌐 Tarayıcınızda `http://localhost:5000` adresine gidin ve sitenizi görün!

#### 4️⃣ Docker ile Çalıştırma (Alternatif)
```bash
# Tek container ile
docker build -t elite-barber .
docker run -p 8080:8080 elite-barber

# Docker Compose ile (önerilen)
docker-compose up -d
```

---

## 🌐 Deployment Rehberi

### 🚂 Railway (En Kolay)
```bash
# Railway CLI ile tek komutta deploy
railway login
railway init
railway up

# Environment variables otomatik tanınır
```

### 🎨 Render.com
1. [Render Dashboard](https://dashboard.render.com/) üzerinden yeni Web Service oluşturun
2. GitHub repository'nizi bağlayın
3. Build Command: `dotnet publish -c Release -o out`
4. Start Command: `dotnet out/BarberDemo.dll`
5. Environment variables ekleyin
6. Deploy! 🎉

### ☁️ Azure App Service
```bash
# Azure CLI ile deployment
az login
az group create --name BarberDemo-RG --location "West Europe"
az appservice plan create --name BarberPlan --resource-group BarberDemo-RG --sku B1
az webapp create --resource-group BarberDemo-RG --plan BarberPlan --name elite-barber

# GitHub Actions ile CI/CD
az webapp deployment source config --name elite-barber \
  --resource-group BarberDemo-RG \
  --repo-url https://github.com/YOUR-USERNAME/BarberDemo \
  --branch main --manual-integration
```

### 🐳 Docker Hub & Kubernetes
```bash
# Docker Hub'a push
docker build -t yourusername/elite-barber:latest .
docker push yourusername/elite-barber:latest

# Kubernetes deployment
kubectl apply -f k8s/deployment.yaml
kubectl apply -f k8s/service.yaml
```

---

## 📁 Proje Yapısı

```
BarberDemo/
│
├── 📂 src/                           # Kaynak kodlar
│   ├── 📂 Controllers/               # API Controllers (future)
│   ├── 📂 Data/                      # Veritabanı katmanı
│   │   └── AppDb.cs                  # EF Core DbContext
│   ├── 📂 Models/                    # Domain modelleri
│   │   └── AppointmentModels.cs      # Randevu veri modelleri
│   ├── 📂 Services/                  # Business logic
│   │   ├── EmailService.cs           # Email gönderimi
│   │   └── ReminderService.cs        # Randevu hatırlatıcıları
│   ├── 📂 Extensions/                # Extension methods
│   │   ├── ApiEndpointsExtensions.cs # Minimal API endpoints
│   │   ├── DatabaseExtensions.cs     # Database setup
│   │   ├── MiddlewareExtensions.cs   # Middleware pipeline
│   │   └── ServiceExtensions.cs      # DI container
│   ├── 📂 Middleware/                # Custom middlewares
│   └── 📂 Configuration/             # Configuration
│
├── 📂 wwwroot/                       # Statik web dosyaları
│   ├── 📂 css/
│   │   └── style.css                 # Custom styles
│   ├── 📂 js/
│   │   └── app.js                    # Frontend logic
│   ├── 📂 images/                    # Görseller
│   ├── favicon.svg                   # Site ikonu
│   └── index.html                    # Ana sayfa
│
├── 📂 tests/                         # Test projeleri
│   ├── 📂 UnitTests/                 # Birim testler
│   └── 📂 IntegrationTests/          # Entegrasyon testleri
│
├── 📂 scripts/                       # Automation scripts
│   ├── dev-setup.sh                  # Geliştirme ortamı kurulumu
│   ├── docker-run.sh                 # Docker komutları
│   ├── local-deploy.sh               # Yerel deployment
│   ├── railway-deploy.sh             # Railway deployment
│   └── deploy-production.sh          # Production deployment
│
├── 📂 docs/                          # Dokümantasyon
│   ├── API.md                        # API referansı
│   ├── DEPLOYMENT.md                 # Deployment guide
│   └── CONTRIBUTING.md               # Katkı rehberi
│
├── 📄 Program.cs                     # Application entry point
├── 📄 appsettings.json              # Development config
├── 📄 appsettings.Production.json   # Production config
├── 📄 Dockerfile                    # Docker image
├── 📄 docker-compose.yml            # Multi-container setup
├── 📄 .gitignore                    # Git ignore rules
└── 📄 README.md                     # Bu dosya

```

---

## 🔧 Geliştirme

### 🎯 Hızlı Komutlar

```bash
# Geliştirme ortamını hazırla
./scripts/dev-setup.sh

# Projeyi derle
dotnet build

# Testleri çalıştır
dotnet test

# Uygulamayı başlat (hot reload ile)
dotnet watch run

# Docker container'ı çalıştır
./scripts/docker-run.sh

# Production'a deploy
./scripts/deploy-production.sh
```

### 🛣️ API Endpoints

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| `GET` | `/` | Ana sayfa |
| `GET` | `/api/status` | Sistem health check |
| `POST` | `/api/appointments` | Randevu oluşturma |
| `GET` | `/api/appointments/{id}` | Randevu detayı |
| `GET` | `/api/hours` | Çalışma saatleri |
| `GET` | `/swagger` | API dokümantasyonu |

### 🎨 Özelleştirme

#### Renk Teması Değiştirme
`wwwroot/css/style.css` dosyasında CSS variables'ları düzenleyin:

```css
:root {
    /* Ana Renkler */
    --primary-gold: #d4af37;
    --deep-black: #1a1a1a;
    --warm-white: #f8f6f0;

    /* Vurgu Renkleri */
    --accent-bronze: #cd7f32;
    --elegant-gray: #4a4a4a;

    /* Gradients */
    --luxury-gradient: linear-gradient(135deg, var(--primary-gold) 0%, var(--accent-bronze) 100%);
}
```

#### Calendly Linki Güncelleme
`wwwroot/js/app.js` dosyasında URL'yi değiştirin:

```javascript
url: 'https://calendly.com/YOUR-USERNAME/appointment'
```

#### Hizmetleri Özelleştirme
`wwwroot/index.html` dosyasında hizmet kartlarını düzenleyin.

---

## 🔒 Güvenlik

### 🛡️ Güvenlik Önlemleri
- ✅ `.env` dosyası Git'e commit edilmez
- ✅ HTTPS zorunluluğu (production)
- ✅ CORS policy yapılandırması
- ✅ Input validation ve sanitization
- ✅ SQL injection koruması (EF Core parametreli sorgular)
- ✅ XSS koruması (input encoding)
- ✅ CSRF token'ları

### ✅ Production Checklist
- [ ] HTTPS sertifikası yapılandırıldı mı?
- [ ] Environment variables güvenli şekilde saklanıyor mu?
- [ ] Log seviyeleri production için ayarlandı mı?
- [ ] Database connection string güvenli mi?
- [ ] API rate limiting aktif mi?
- [ ] Health check endpoint'i çalışıyor mu?
- [ ] Monitoring ve alerting yapılandırıldı mı?
- [ ] Backup stratejisi belirlendi mi?
- [ ] Firewall kuralları ayarlandı mı?

---

## 🤝 Katkıda Bulunma

Projeye katkıda bulunmak isterseniz:

1. 🍴 Repository'yi fork edin
2. 🌿 Feature branch oluşturun (`git checkout -b feature/amazing-feature`)
3. 💾 Değişikliklerinizi commit edin (`git commit -m 'feat: add amazing feature'`)
4. 📤 Branch'inizi push edin (`git push origin feature/amazing-feature`)
5. 🎉 Pull Request oluşturun

Detaylı bilgi için [CONTRIBUTING.md](CONTRIBUTING.md) dosyasına göz atın.

### 📝 Commit Mesaj Standartları
```
feat: Yeni özellik ekleme
fix: Bug düzeltme
docs: Dokümantasyon değişikliği
style: Code formatı (loglama, boşluklar vb.)
refactor: Kod iyileştirme
test: Test ekleme veya düzenleme
chore: Build process veya yardımcı araçlar
```

---

## 📊 Performans

- ⚡ **Sayfa Yükleme**: < 1.5s
- 📱 **Mobile Performance Score**: 95+
- ♿ **Accessibility Score**: 100
- 🎯 **SEO Score**: 95+
- 🔋 **Lighthouse Score**: 90+

---

## 📞 İletişim & Destek

<div align="center">

### Bize Ulaşın

[![GitHub](https://img.shields.io/badge/GitHub-Profile-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/CemRoot)
[![Website](https://img.shields.io/badge/Live-Demo-00C7B7?style=for-the-badge&logo=vercel&logoColor=white)](https://barber-f934.onrender.com)
[![Issues](https://img.shields.io/badge/Report-Issue-red?style=for-the-badge&logo=github&logoColor=white)](https://github.com/CemRoot/BarberDemo/issues)

</div>

- **🐛 Bug Reports**: [GitHub Issues](https://github.com/CemRoot/BarberDemo/issues/new?template=bug_report.md)
- **💡 Feature Requests**: [GitHub Issues](https://github.com/CemRoot/BarberDemo/issues/new?template=feature_request.md)
- **📧 Email**: [isgelistirme41@gmail.com](mailto:isgelistirme41@gmail.com)

---

## 📄 Lisans

Bu proje **MIT Lisansı** altında lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakınız.

```
MIT License - Özet:
✅ Ticari kullanım
✅ Değiştirme
✅ Dağıtım
✅ Özel kullanım
```

---

## 🙏 Teşekkürler

Bu projeyi mümkün kılan harika açık kaynak projelere teşekkürler:

- [**ASP.NET Core Team**](https://github.com/dotnet/aspnetcore) - Framework
- [**Bootstrap Team**](https://getbootstrap.com) - UI Framework
- [**Calendly**](https://calendly.com) - Randevu sistemi
- [**Font Awesome**](https://fontawesome.com) - İkonlar
- [**Render**](https://render.com) - Hosting platformu

---

## 📈 Yol Haritası

### ✅ Tamamlananlar
- [x] Temel randevu sistemi
- [x] Calendly entegrasyonu
- [x] Responsive tasarım
- [x] Docker desteği
- [x] API dokümantasyonu

### 🚧 Devam Eden
- [ ] Kullanıcı authentication sistemi
- [ ] Admin paneli
- [ ] SMS bildirimleri
- [ ] Çoklu dil desteği

### 🔮 Planlananlar
- [ ] Mobil uygulama (React Native)
- [ ] Ödeme entegrasyonu (Stripe/PayPal)
- [ ] Analytics dashboard
- [ ] WhatsApp entegrasyonu
- [ ] E-posta kampanyaları

---

<div align="center">

### ⭐ Projeyi Beğendiyseniz Yıldız Vermeyi Unutmayın!

[![Star History Chart](https://api.star-history.com/svg?repos=CemRoot/BarberDemo&type=Date)](https://star-history.com/#CemRoot/BarberDemo&Date)

---

**Made with ❤️ by [CemRoot](https://github.com/CemRoot)**

**© 2025 Elite Barber. All rights reserved.**

</div>
