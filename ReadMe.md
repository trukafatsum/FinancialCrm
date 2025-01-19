# FinancialCrm

## **Tanım**

Bu projede, **kişisel finans yönetimi** için kapsamlı bir CRM uygulaması geliştirilmiştir.
Uygulama, kullanıcıların finansal durumlarını düzenli olarak takip etmelerini sağlar. Kullanıcılar;

- Banka bakiyelerini,
- Faturalarını,
- Harcamalarını ve
- Banka hareketlerini yönetebilir ve analiz edebilir.

---

## **Kullanılan Teknolojiler (Tech Stack)**

**Backend:**

- .NET Framework
- C# programlama dili
- SQL Server
- ADO.NET Entity Data Model
- LINQ sorguları

**Frontend:**

- WinForms (Form arayüzü ve bileşenleri)
- FontAwesome.Sharp paketi

### **Hedef Kitle**

- **Kullanıcılar:** Kişisel finans yönetimini kolaylaştırmak isteyen bireyler.
- **Geliştiriciler:** Proje açık kaynak olarak da sunulduğu için katkı sağlayabilecek geliştiriciler.

---

## Başlarken

Proje dosyalarını bilgisayarınıza indiriniz.

Proje SQL Server veri tabanı ile çalışmaktadır. Öncelikle SQL Server ve Management Studio kurulması gerekmektedir.
Ardından  `FinancialCrmDb` içerisinden query ile veya *.bak dosyası ile veri tabanını kurunuz.  Ayrıntılı bilgi için `.\FinancialCrmDb\readme.md` dosyasını inceleyebilirsiniz.

---

## **Kullanım (Usage)**

Uygulamanın kullanımına dair detaylı bilgiler, proje dökümanları `.\docs` arasında yer almaktadır.

Ana kullanım adımları şunlardır:

1. **Uygulamayı Başlatma**
   `bin\release\` klasöründeki `FinancialCrm.exe` dosyasını çalıştırarak uygulamayı başlatabilirsiniz.
2. **Veritabanı Konfigürasyonu**
   İlk başlatmada gerekli veritabanı ayarlarını yapmanız gerekebilir. Konfigürasyon ekranında gerekli bilgileri girip kaydedebilirsiniz.
3. **Kullanıcı Girişi**
   Veritabanına kullanıcı bilgilerini ekledikten sonra giriş yapabilirsiniz.
4. **Modüller ve Fonksiyonlar**
   Uygulama içinde şu modüller bulunmaktadır:
   - **Dashboard**: Genel bilgiler ve özetler.
   - **Kategoriler**: Giderlerinizi kategorilere ayırma.
   - **Bankalar**: Banka hesaplarınızın ve hareketlerinizin yönetimi.
   - **Faturalar**: Faturalarınızı takip etme.
   - **Giderler**: Harcamalarınızın detaylı yönetimi.
   - **Ayarlar**: Kullanıcı ve veritabanı ayarlarını düzenleme.

Detaylı kullanım rehberi için dökümantasyon dosyasını inceleyebilirsiniz.


---

## Ekran Görüntüleri & GIF'ler

![Dashboard Görseli](./screenshots/dashboard.png)


---

## Proje Yapısı

```tex
├── bin/
│   └── release/
│       └── FinancialCrm.exe
├── FinancialCrmDb/
│   ├── FinancialCrm.bak
│   └── readme.md
├── docs/
│   ├── kullanım.md
│   └── usage.md
└── src/
    └── MainApp.csproj
```



---

## Bilinen Sorunlar ve Geliştirme Yol Haritası

* İlk kullanım için kullanıcı bilgileri tanımlama *
* Banka verilerine ilişkin (listeleme, ekleme, silme, güncelleme) işlemleri *
* Banka hareketleri verilerine ilişkin (listeleme, ekleme, silme, güncelleme) işlemleri *
* Dashboard ekranında gösterilecek içerikleri arttırma *
  

---

## Katkıda Bulunanlar

Türkçe kaynak ve yazılım sektörüne olan katkılarından dolayı, aynı zamanda bu projenin geliştirilmesinde önemli bir rol oynayan @Murat Yücedağ hocamıza teşekkür ederim.

YouTube üzerinde ücretsiz olarak yayımladığı **C# Proje Kampı** serisinin ilerleyen bölümlerinde bu projeye başlama fırsatı buldum ve temellerini attım.

---

## Lisans

Bu proje [MIT](LICENSE) lisansı altında yayınlanmıştır.
