## Kullanım

1. Proje dosyası içerisinde yer alan `.bin\release\` klasöründeki FinancialCrm.exe dosyasını çalıştırın. Dilerseniz `release`  klasörünün adını değiştirebilir, farklı bir yere taşıyabilir veya koypalayabilirsiniz.

   2. Veri Tabanı Konfigürasyonu:
      FinancialCrm ilk çalışmaya başladığında, default veritabanı konfigürasyon bilgileri ile başlayacaktır. Eğer bilgiler uyumlu değilse, sizleri veri tabanı konfigürasyonu ekranı karşılar. Buradaki metin kutuları (textbox) içerisine;

   - User Id = Sql Server kullanıcı girişi id değeri, kurulumda default 'sa',
   - Password = Sql Server kullanıcı şifresi,
   - Veri tabanı kaynağı (local için default) = .\SQLExpress
   - Veri tabanı adı `FinancialCrmDb`
     bilgilerini girerek kayıt butonuna basınız. (Kayıt işlemi için veri tabanı bağlantısı oluşturmayı dener, oluşturamaz ise ekranda sizi bilgilendirir.)
     Kayıt başarılı olduğunda, Kullanıcı giriş ekranı (Login Screen) sizleri karşılar.

   3. Giriş Ekranı: 

   İlk kullanımda veri tabanı boş olacaktır. Dolayısıyla giriş yapmak için manuel kullanıcı bilgileri girmeniz gerekir.
   Sql Server Management Studio'yu açarak query veya Users tablosu üzerinden verileri giriniz.
   	(Username, Password, FirstName, LastName, Status)
   Giriş Yap butonuna tıkladığınızda, arka planda Kullanıcı adı sorgulanır, veri tabanında kullanıcı adı bulunuyorsa, şifre bilgisinin eşleşip eşleşmediğini denetler. 

   Başarısız olduğu zaman ekranda sizi bilgilendirir.

   

   4. Ana ekran

      4.1. Dashboard ekranı:
      Hoş geldiniz, Ad Soyad! metni ve devamında sistemden aldığı saat bilgisi gösterilir.
      Sayfanın içeriğinde 3 bölümde

      a) Toplam Bakiyem, Bankalar ve Bilgileri
      b) Faturalar
      c) Son Banka Hareketi 

      gösterilir.

      

      4.2.  Kategoriler ekranı:
      Kategoriler ekranında kategori tablosu, kontrol butonları (listele, ekle, sil, güncelle) yer alır.

      Girilen kategori bilgileri, `Giderler`tablosu ile ilişkilidir. Dolayısıyla girilen kategori bilgisi aslında `Giderler` 'in kategorize edilmesi için kullanılmaktadır.

      

      4.3. Bankalar ekranı:
      Sayfa içeriğinde 3 bölümde
      a) Ziraat Bankası / Iban-Hesap no / Bakiye
      b) Vakıfbank  / Iban-Hesap no / Bakiye
      c) İş Bankası  / Iban-Hesap no / Bakiye
      bilgileri gösterilir. 

      Iban-Hesap no, üzerine tıklandığında kopyalanmaktadır.

      Devamında ise son 5 banka hareketi gösterilecektir.

      

      4.4. Faturalar ekranı:
      Faturalarınızın listesini tutan bir tablo ve veri girişi için metin kutuları (textbox) ve kontrol butonları(listele, ekle, sil, güncelle) vardır.

      (Fatura başlığı, Tutar, Periyot)

      > Silme ve Güncelleme işlemleri gerçekleştirmek için öncelikle tablodan ilgili satırı seçmeniz gerekir.
      > Seçilen satırın `ID` değeri ekranda gösterilecektir. 


      4.5. Giderler ekranı:
      Giderler ekranında harcama bilgileri ekleyebilir, silebilir, güncelleyebilirsiniz.
      Giderler tablosu yer alır, faturalar ekranında olduğu gibi silme ve güncelleme işlemleri gerçekleştireceğiniz satırı seçmeniz gerekir.
      Aynı zamanda ekranda `Chart` yer alır ve tüm harcamalarınızın kategoriye göre oranlarını ve toplam tutarlarını görebilirsiniz.

      4.6. Banka Hareketleri ekranı:
      Banka hareketlerinizi takip edebileceğiniz, sadece okunabilir bir form ekranı açılır.
      (ID, Banka adı, İşlem türü, Tutar, Açıklama, İşlem tarihi) listelenir.
      Filtreli arama yapabilmenizi sağlayan metin kutusu (textbox) yer alır.
      Filtreli arama özellikleri:
      a) Metin arama,
      b) Tarih kontrolü, örn(2025 Ocak), (01.01.2025) veya (01/01/2025) tarihindeki bilgileri listeler.
      c) Tutar aralığı, örn (500-2500) sadece 500 ve 2500 ₺ aralığındaki bilgileri listeler. 

      
      4.7. Ayarlar:
      Ayarlar ekranı dikey olarak 2'ye ayrılır, sol tarafta kullanıcı bilgileri ve kontrolleri; sağ tarafta ise, veri tabanı konfigürasyon ekranı açılır.
      Kullanıcı bilgilerini ekleyebilir, silebilir, güncelleyebilirsiniz.
      Veri tabanı bilgilerini değiştirebilirsiniz.

      > Veri tabanı bilgilerinin değiştirilmesi, uygulamanın yeniden başlatılmasına sebep olur.*

      4.8. Çıkış Yap:
      Ana ekranda 2 farklı çıkış işlemi gerçekleşir, sağ üst köşede yer alan `X` butonu uygulamanın kapatmasını sağlarken,
      Sol menüde yer alan `Çıkış Yap` butonu açılan oturumu kapatarak `Giriş Ekranına` yönlendirir.

      Ayrıca ana ekrandaki sağ üst köşedeki butonlar ile uygulamayı gizleyebilir veya tam ekran boyutuna getirebilirsiniz.
      Gizlenen uygulama simge durumunda küçültülür ve ekrana balon bilgilendirme mesajı iletir.

   