# BarberDemo – Minimal .NET 8 API (working hours, bookings, e-mail reminders)

## 🚀 Run in GitHub Codespaces (Recommended for Demos)

**Zero setup required!** Perfect for live presentations:

1. Click **Code** → **Codespaces** → **Create codespace**
2. Wait for automatic setup (2-3 minutes)
3. Run: `dotnet run`
4. Access Swagger UI at the forwarded port

**✅ No .NET installation needed • ✅ Cloud-based • ✅ Perfect for demos**

---

## 🇹🇷 TÜRKÇE KULLANIM KILAVUZU

### 🎯 Proje Hakkında

**BarberDemo**, berber randevu sistemi için hazırlanmış minimal bir .NET 8 API'sidir. Bu proje şu özellikleri içerir:

- 🕒 **Çalışma saatleri yönetimi** (çakışma kontrolü ile)
- 📅 **Randevu sistemi** (zaman çakışma kontrolü)
- ✉️ **Otomatik e-posta bildirimleri** (berber ve müşteri)
- ⏰ **24 saat öncesi hatırlatma servisi** (arka plan görevi)
- 💾 **Bellek içi veritabanı** (kurulum gerektirmez)
- 📖 **Swagger UI** (test arayüzü)

### 🚀 Hızlı Başlangıç (Önerilen - GitHub Codespaces)

**HİÇBİR KURULUM GEREKMİYOR!** Sadece tarayıcınız olması yeterli:

#### Adım 1: GitHub Codespaces'te Aç
1. Bu GitHub deposuna gidin
2. **Code** butonuna tıklayın
3. **Codespaces** sekmesini seçin
4. **Create codespace** butonuna tıklayın

#### Adım 2: Otomatik Kurulumu Bekleyin
- 2-3 dakika bekleyin (otomatik .NET 8 kurulumu)
- VS Code tarayıcıda açılacak
- Tüm paketler otomatik yüklenecek

#### Adım 3: Uygulamayı Başlatın
Terminal'de şu komutu çalıştırın:
```bash
./start-demo.sh
```
veya
```bash
dotnet run
```

#### Adım 4: Swagger UI'yı Kullanın
- Port yönlendirmesi otomatik açılacak
- Swagger arayüzü tarayıcıda görünecek
- API'yi test etmeye başlayabilirsiniz!

### 💻 Yerel Bilgisayarınızda Çalıştırma

#### Gereksinimler
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Git

#### Kurulum Adımları

1. **Projeyi indirin:**
```bash
git clone https://github.com/[KULLANICI_ADI]/BarberDemo.git
cd BarberDemo
```

2. **Paketleri yükleyin:**
```bash
dotnet restore
```

3. **Uygulamayı çalıştırın:**
```bash
dotnet run
```

4. **Swagger UI'yı açın:**
- Tarayıcınızda: `http://localhost:5000/swagger`

### 📝 API Kullanımı

#### 1. Çalışma Saatleri Ekleme
**Endpoint:** `POST /api/hours`

**Örnek istek:**
```json
{
  "day": "Monday",
  "start": "10:00:00",
  "end": "18:00:00"
}
```

**Açıklama:** Berberin hangi günlerde ve saatlerde çalıştığını tanımlar.

#### 2. Randevu Alma
**Endpoint:** `POST /api/appointments`

**Örnek istek:**
```json
{
  "customer": "Ahmet Yılmaz",
  "email": "ahmet@example.com",
  "date": "2025-01-20T14:00:00Z"
}
```

**Açıklama:** Müşteri için randevu oluşturur ve e-posta bildirimi gönderir.

### 📧 E-posta Ayarları

#### Konsol Modu (Varsayılan)
- E-posta bildirimleri terminal'de görünür
- Demo ve geliştirme için idealdir
- Ek kurulum gerektirmez

#### SMTP Modu (Gerçek E-posta)
`appsettings.json` dosyasında:
```json
{
  "Mail": {
    "Mode": "smtp",
    "Smtp": {
      "Host": "smtp.gmail.com",
      "Port": 587,
      "User": "sizin@email.com",
      "Pass": "sifreniz",
      "From": "barber@orneksite.com"
    }
  }
}
```

**Çevre değişkenleri ile:**
```bash
export SMTP_USER="sizin@email.com"
export SMTP_PASS="sifreniz"
```

### ⏰ Arka Plan Servisleri

**Hatırlatma Servisi:**
- Her dakika çalışır
- 24 saat öncesinde hatırlatma gönderir
- Otomatik olarak başlar
- Console'da log mesajları görünür

### 🛠️ Geliştirme İpuçları

#### Veritabanı
- Bellek içi SQLite kullanır
- Uygulama her başlatıldığında sıfırlanır
- Örnek veri otomatik yüklenir (Pazartesi-Salı, 10:00-18:00)

#### Hata Ayıklama
```bash
# Detaylı loglar için
export ASPNETCORE_ENVIRONMENT=Development
dotnet run
```

#### Testler Ekleme
```bash
# Test projesi oluşturma
dotnet new xunit -n BarberDemo.Tests
cd BarberDemo.Tests
dotnet add reference ../BarberDemo.csproj
```

### 🎬 Demo Senaryosu (15 dakika)

1. **Giriş (2 dk):**
   - Proje tanıtımı
   - GitHub Codespaces açılımı

2. **Çalışma Saatleri (3 dk):**
   - Swagger UI'da POST /api/hours
   - Çakışma durumu gösterimi
   - Geçersiz saat aralığı testi

3. **Randevu Sistemi (5 dk):**
   - POST /api/appointments ile randevu alma
   - E-posta bildirimlerini console'da gösterme
   - Çakışan randevu testi
   - Çalışma saatleri dışı randevu testi

4. **Arka Plan Servisi (3 dk):**
   - Hatırlatma sisteminin açıklanması
   - Console loglarında servis çalışmasını gösterme

5. **Kapanış (2 dk):**
   - Özet ve sorular

### 🚀 Deployment Seçenekleri

#### GitHub Actions (Otomatik)
- `.github/workflows/dotnet.yml` mevcut
- Her push'ta otomatik build ve test

#### Azure'a Deploy
```bash
# Azure CLI ile
az containerapp up --source . --resource-group myRG --environment myEnv
```

#### Docker
```bash
# Dockerfile oluşturmak için
dotnet publish -c Release
docker build -t barberdemo .
docker run -p 5000:5000 barberdemo
```

### ❓ Sık Sorulan Sorular

**S: .NET 8 yüklü değil, ne yapmalıyım?**
C: GitHub Codespaces kullanın! Hiçbir kurulum gerektirmez.

**S: E-postalar gönderilmiyor?**
C: Konsol modunda çalışıyor. Terminal'de log mesajlarını kontrol edin.

**S: Randevu alınamıyor?**
C: Önce çalışma saatleri tanımladığınızdan emin olun.

**S: Veritabanı verilerimi nasıl koruyabilirim?**
C: Bu demo sürümü için in-memory kullanılıyor. Production için SQL Server eklenebilir.

### 📞 Destek

- GitHub Issues: Sorunları bildirin
- Email: [iletişim@orneksite.com]
- Wiki: Detaylı dokümantasyon

---

## 💻 Local Development (English)

```bash
dotnet restore
dotnet run
# Swagger UI → http://localhost:5000/swagger
```

## 📝 API Endpoints

| Verb | Path | Body example (JSON) | Purpose |
|------|------|---------------------|---------|
| POST | `/api/hours` | `{ "day":"Monday","start":"10:00:00","end":"18:00:00" }` | Add working hours |
| POST | `/api/appointments` | `{ "customer":"John","email":"john@x.com","date":"2025-07-09T14:00:00Z" }` | Book an appointment |

## 📧 Email Configuration

- **Console mode** (default) — emails appear as log lines in terminal
- **SMTP mode** — set `Mail:Mode=smtp` and provide `SMTP_USER`, `SMTP_PASS` environment variables

## ⏰ Background Reminder Service

A background service runs every minute and sends reminder emails 24 hours before appointments.

## 🎯 Demo Features

- ✅ **Working hours management** with overlap validation
- ✅ **Appointment booking** with clash detection  
- ✅ **Immediate email notifications** (barber + customer)
- ✅ **24-hour reminder system** (background service)
- ✅ **In-memory database** (zero external dependencies)
- ✅ **Swagger UI** as demo frontend
- ✅ **Pre-seeded data** (Monday-Tuesday, 10 AM - 6 PM)

---

Built for live demos – **zero external infrastructure required**!