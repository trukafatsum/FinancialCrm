# **Yedekler Klasörü**

Bu klasör, **FinancialCrmDb** veritabanının yedeklerini içermektedir. Yedekler iki farklı formatta sunulmaktadır: 

1. **CreateDatabase_FinancialCrmDb.sql** - Veritabanı yapısını ve tabloları oluşturmak için kullanılan SQL sorgusudur.
2. **FinancialCrmDb202501190233.zip** - Veritabanının `.bak` uzantılı yedeği, veritabanını geri yüklemek için kullanılabilir.

## 1. **CreateDatabase_FinancialCrmDb.sql**
Bu dosya, **FinancialCrmDb** veritabanını sıfırdan oluşturmanıza olanak tanır. Veritabanı yapısı, tablolar, ilişkiler ve diğer temel yapılandırmalar bu sorgu içerisinde yer almaktadır.

**Kullanım:**
- SQL Server Management Studio (SSMS) veya benzeri bir SQL istemcisine bağlanın.
- `CreateDatabase_FinancialCrmDb.sql` dosyasını çalıştırarak veritabanınızı oluşturun.

```sql
-- Example Query Execution
-- Open SQL Server Management Studio and execute the query to create the database
```



## 2. **FinancialCrmDb202501190233.zip (.bak Yedeği)**

Bu dosya, **FinancialCrmDb** veritabanının `.bak` uzantılı yedeğini içerir. Yedeği, var olan bir SQL Server instance'ına geri yüklemek için kullanabilirsiniz.

**Kullanım:**

1. `FinancialCrmDb202501190233.zip` dosyasını çıkarın.
2. SQL Server Management Studio (SSMS) üzerinden yedekleme dosyasını geri yükleyin.

```sql
-- Yedekleme dosyasını geri yüklemek için şu komutları kullanabilirsiniz:
RESTORE DATABASE FinancialCrmDb
FROM DISK = 'C:\Users\MyPC\Desktop\FinancialCrmDb202501190233.bak'
WITH REPLACE;

```



## Yedeklerin Geri Yüklenmesi

Her iki yedek türü de **FinancialCrmDb** veritabanının kurulumunu sağlar. İhtiyacınıza göre, SQL sorgusunu çalıştırarak veritabanını sıfırdan oluşturabilir veya `.bak` yedeğini geri yükleyebilirsiniz.

## Notlar

- Yedeklerin geri yüklenmesi, veritabanının üzerine yazılmasına neden olabilir, bu yüzden dikkatli olun.
- Veritabanı yapısının ve içeriğinin her iki yedek türünde de aynı olduğundan emin olun.

```yaml
---

### **Açıklamalar:**

- **CreateDatabase_FinancialCrmDb.sql**: Bu dosya, veritabanını sıfırdan oluşturmak için kullanılan SQL komutlarını içeriyor. Genellikle, veritabanı yapısının elle oluşturulması gerektiğinde tercih edilir.
- **FinancialCrmDb202501190233.zip (bak Yedeği)**: Bu dosya, veritabanının tam yedeğini içeren bir yedekleme dosyasıdır. `.bak` uzantılı yedek, SQL Server veritabanını geri yüklerken kullanılır.

---

Bu `README.md` dosyası, proje kullanıcılarının yedekleri nasıl kullanacaklarını kolayca anlamalarına yardımcı olacaktır. Yedek dosyalarınızı **`yedekler`** klasörüne eklerken, bu **`README.md`** dosyasını da oraya eklemeyi unutmayın. 😊

```

