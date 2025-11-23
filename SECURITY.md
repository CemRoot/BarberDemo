# Güvenlik Politikası

## Desteklenen Versiyonlar

Şu anda aşağıdaki proje versiyonları için güvenlik güncellemeleri sağlanmaktadır:

| Versiyon | Destekleniyor          |
| -------- | ---------------------- |
| 1.0.x    | :white_check_mark: Evet |
| < 1.0    | :x: Hayır              |

## Güvenlik Açığı Bildirme

Elite Barber projesinin güvenliğini ciddiye alıyoruz. Projede bir güvenlik açığı keşfettiyseniz,
lütfen bize sorumlu bir şekilde bildirin.

### Bildirme Süreci

**🔒 Lütfen güvenlik açıklarını herkese açık GitHub issue'ları aracılığıyla BİLDİRMEYİN.**

Bunun yerine, şu adımları izleyin:

1. **E-posta Gönderin**: Güvenlik açığını [koyluoglu.cem@lll.kpi.ua](mailto:koyluoglu.cem@lll.kpi.ua) adresine gönderin
   
2. **Açıklama Ekleyin**: E-postanızda şunları ekleyin:
   - Açığın detaylı bir açıklaması
   - Açığı nasıl tekrar edebildiğiniz (adım adım)
   - Olası etki (örn. veri sızıntısı, yetkisiz erişim, vb.)
   - Varsa, kavram kanıtı (Proof of Concept)
   - Önerilen düzeltme (varsa)

3. **Şifreleme (Opsiyonel)**: Hassas bilgiler için PGP şifrelemesi kullanabilirsiniz
   - PGP Key ID: Talep üzerine sağlanacaktır

### Ne Bekleyebilirsiniz?

- **İlk Yanıt**: Raporunuzu **48 saat** içinde alındığını teyit edeceğiz
- **Durum Güncellemesi**: **5 iş günü** içinde ilk değerlendirmeyi paylaşacağız
- **Çözüm Süreci**: Güvenlik açığının ciddiyetine bağlı olarak bir düzeltme planı oluşturacağız
- **Açıklama**: Düzeltme yayınlandıktan sonra, sizinle koordineli bir şekilde açıklama yapacağız

### Sorumluluk Bildirimi

Güvenlik araştırmacıları için yönergeler:

✅ **YAPIN:**
- Güvenlik açığını keşfettikten sonra derhal bildirin
- Bilgileri gizli tutun (düzeltme yayınlanana kadar)
- Bize açığı düzeltmek için makul bir süre verin
- Yalnızca kendi test hesaplarınızda/verilerinizde test edin

❌ **YAPMAYIN:**
- Açığı kamuya açıklamayın (düzeltme yayınlanana kadar)
- Kullanıcı verilerini silmeyin veya değiştirmeyin
- Denial of Service (DoS) saldırıları yapmayın
- Spam veya phishing e-postaları göndermeyin
- Sosyal mühendislik kullanmayın

### Güvenlik Hall of Fame

Güvenlik açıklarını sorumlu bir şekilde bildiren araştırmacıları (izinleriyle) burada listeleyeceğiz:

<!-- Güvenlik araştırmacıları buraya eklenecek -->
- Henüz yok - İlk siz olun!

### Kapsam

Aşağıdaki alanlardaki güvenlik açıkları bu politika kapsamındadır:

#### Kapsam İçi

- **Kimlik Doğrulama ve Yetkilendirme**: Bypass, privilege escalation
- **Injection**: SQL, XSS, CSRF, Command Injection
- **Sensitive Data Exposure**: Veri sızıntısı, eksik şifreleme
- **Broken Access Control**: Yetkisiz veri erişimi
- **Security Misconfiguration**: Yanlış yapılandırmalar
- **Server-Side Request Forgery (SSRF)**
- **XML External Entities (XXE)**
- **Deserialization Exploits**

#### Kapsam Dışı

- **Denial of Service (DoS/DDoS)** saldırıları
- **Spam veya Sosyal Mühendislik**
- **Fiziksel saldırılar**
- **Daha önce bildirilen açıklar**
- **Otomatik scanner çıktıları** (manuel doğrulama yapılmamış)

### Ödül Programı

Şu anda bir bug bounty programımız yok, ancak:

- ✅ Güvenlik Hall of Fame'de yer almanız
- ✅ Katkınız için teşekkür (GitHub, blog post, vb.)
- ✅ Gelecekteki beta programlarına erken erişim

### Güvenlik En İyi Uygulamalarımız

Projeyi güvenli tutmak için şu önlemleri alıyoruz:

1. **Dependency Management**
   - Düzenli bağımlılık güncellemeleri
   - Automated security scanning (GitHub Dependabot)
   - Bilinen güvenlik açıkları için izleme

2. **Code Review**
   - Tüm kod değişiklikleri için peer review
   - Security-focused code review checklist
   - Automated static code analysis

3. **Authentication & Authorization**
   - Güvenli kimlik doğrulama mekanizmaları
   - Role-based access control (RBAC)
   - JWT token güvenliği

4. **Data Protection**
   - Hassas verilerin şifrelenmesi
   - Secure password hashing (bcrypt/Argon2)
   - HTTPS zorunluluğu (production)

5. **Input Validation**
   - Client ve server-side validation
   - Parametreli SQL sorguları (SQL injection koruması)
   - Output encoding (XSS koruması)

6. **Logging & Monitoring**
   - Security event logging
   - Anomali tespiti
   - Audit trails

### Güvenlik Kaynakları

Güvenlik best practices için:

- [OWASP Top 10](https://owasp.org/www-project-top-ten/)
- [OWASP API Security Top 10](https://owasp.org/www-project-api-security/)
- [CWE Top 25](https://cwe.mitre.org/top25/)
- [.NET Security Cheat Sheet](https://cheatsheetseries.owasp.org/cheatsheets/DotNet_Security_Cheat_Sheet.html)

### İletişim

Güvenlikle ilgili sorularınız için:

- **Email**: [koyluoglu.cem@lll.kpi.ua](mailto:koyluoglu.cem@lll.kpi.ua)
- **GitHub**: [@CemRoot](https://github.com/CemRoot)

---

**Teşekkürler**: Güvenlik araştırmacılarının projenin güvenliğini artırmaya yardımcı olma
konusundaki çabalarını takdir ediyoruz. Birlikte daha güvenli bir yazılım oluşturuyoruz!

**Son Güncelleme**: 23 Ocak 2025
