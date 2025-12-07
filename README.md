# STOK TAKİP VE SATIŞ SİSTEMİ

**Form1.cs:**  
  Burada ilk önce kullanacak kişinin yönetici mi yoksa kullanıcı mı olduğuna göre tabControl kullanarak farklı girişler açtım. Kişi kullanıcıysa kullanıcı girişine giriyor. Daha önceden kaydı varsa direkt e-mail ve şifresine göre girebilir ama eğer daha önce kayıt yaptırmadıysa ‘Kayıtlı Kullanıcı Değilim’ butonuna basarak yeni kayıt oluşturması gerekiyor. Yeni kayıt için kişiden isim, soyisim, şehir, e mail ve dört haneli şifresi isteniyor bu veriler kod kısmında MSSQL’deki kullanıcı tablosuna gönderiliyor. Daha sonra kişi tekrar giriş ekranına geliyor ve girişini sağlıyor kayıt alma kısmında girdiği veriler giriş kısmında kontrol edilir ve girdiği bilgiler doğru ise ‘kullaniciEkrani’ isimli yeni forma gelir.  

  Yönetici girişinde ise kişiden ismi ve şifresi istenir. Yönetici kısmına her insan girmemesi için bir kayıt oluştur alanı yoktur. Sadece 2 kişi girebilir bunların isim ve şifreleri ise; agah,1221 ve emine, 1234’tür. Yine aynı şekilde girilen bilgiler doğru ise ‘yoneticiEkrani’ isimli yeni forma gelir. 
![Ekran görüntüsü 2024-12-20 001011](https://github.com/user-attachments/assets/ab34ae43-faed-4736-9a54-a72dddd68f0c)
![Ekran görüntüsü 2024-12-20 001046](https://github.com/user-attachments/assets/d94f1fc4-f77d-4299-b397-29c89ef5e26e)
![Ekran görüntüsü 2024-12-20 001101](https://github.com/user-attachments/assets/c95229a1-9bc8-4b77-baa1-66195a2be007)

**YoneticiEkrani.cs:**
  Bu formda sadece yöneticinin isteklerine göre ilerlemesi için gerekli butonlar bulunmaktadır. Yeni ürün ekleme, ürün silme, ürün düzenleme, kullanıcı listesi, kullanıcı ayarları(silme,düzenleme,ekleme) ve son olarak giriş ekranına(form1.cs) geri dönüşü sağlayan geri butonu bulunmaktadır. 
![Ekran görüntüsü 2024-12-20 001145](https://github.com/user-attachments/assets/c1f68255-353c-43a0-ad65-c54c99ec186e)
 
**urunEkle.cs:**
  Yönetici bu kısımda daha sonra kullaniciEkrani.cs de sergilenmesi için gereken ürünleri yükleyebilir. Ürün yüklemek için üreticinin ürünün rengine, kategorisine, markasına, fiyatına, stokta kaç tane bulunduğuna ve ürünün fotoğrafına ihtiyacı vardır. Tüm bu alanlar doldurulduktan sonra ‘ürünü yükleyin’ tuşuna basılır ve ürün SQL deki ' urunlerTablosu ' adlı tabloya yüklenir. Alanlardan bir tanesi boş kalırsa tüm alanları doldurunuz diye bir uyarı mesajı gelir. 
![Ekran görüntüsü 2024-12-20 001158](https://github.com/user-attachments/assets/5109786b-9b14-4452-bb30-824c34fdc30f)

**urunSil.cs:**  
  Yöneticinin ürünün ID’sine göre ürünü sildiği form alanı. DataGridView’de hücrelerden birine tıkladığımızda o hücrenin sahip olduğu ID numarasını yukarıda bulunan ürün ID textbox’a aktarır. Daha sonra textbox’ın yanında bulunan ‘ürünü sil’ adlı tuşa bastığımızda ürün silinir. 
![Ekran görüntüsü 2024-12-20 001216](https://github.com/user-attachments/assets/6c1241ba-8996-4258-ac76-20f6b1aba5e0)

**urunDuzenle.cs:** 
  Yöneticinin ürünleri kaydettikten sonra düzenleyebileceği form. En altta bulunan datagridview da seçilen bir ürünün tüm özellikleri yukarıdaki textboxlara aktarılır. O kısımda yönetici ürünü istediği gibi düzenleyebilir. 
![Ekran görüntüsü 2024-12-20 001235](https://github.com/user-attachments/assets/e9e5a2a0-a624-4254-b209-1f0d158e95f4)

**KullaniciListesi.cs:** 
  Yöneticinin kayıtlı kullanıcıları görmesini sağlayan form. 
 
**KullaniciAyarlari.cs:**  
  Tüm kullanıcıları buradaki dataGridView’a gelmektedir. Yöneticinin kullanıcı tablosunda yapmak istediği herhangi bir işlem (veri silme, veri yükleme, veri düzenleme) yapılabilmektedir. Silme işlemi için kullanıcının ID’si kullanılmaktadır. DataGridView üzerindeki herhangi bir hücreye basıldığında form içerisindeki textBox’a o hücrenin sahip olduğu kullanıcı ID’si gelmektedir. Kullanıcı Sil tuşuna bastıktan sonra bu kullanıcı silinmektedir. Benzer şekilde DataGridView üzerinde yapılan bir işlem sonrası Kaydet butonuna basıldıktan sonra bu değişiklikler kaydedilip SQL Server’daki kullaniciTablosu adlı tabloya iletilir orada da değişiklikler aynı şekilde olmaktadır. 
 
**KayitAlma.cs:** 
  Kullanıcı daha önce kayıt oluşturmadıysa bu alana gelip gerekli bilgileri doldurduktan sonra kayıt işlemini tamamlar ve kullanıcı ekranına gidebilir. Bu alanda gerekli bilgiler ise kullanıcının ismi, soy ismi, şehri, e-maili ve 4 haneli şifresidir. Bu bilgiler alındıktan sonra MSSQLde ‘kullaniciTablosu’na kaydedilir ve giriş yapmaya çalıştığında bilgiler yine aynı şekilde ‘kullaniciTablosu’nda çekilir ve doğruluğu kabul edilir. 
 ![Ekran görüntüsü 2024-12-20 001116](https://github.com/user-attachments/assets/3192c2d0-83d9-4451-9c8c-62008cfcfc44)

**KullaniciEkrani.cs:**
  Kullanıcı giriş yaptıktan sonra buraya yani alışverişi yapacağı forma geliyor. Alttaki DataGridView de ürünler bulunuyor buradaki herhangi bir hücreye bastığında sol üst köşedeki picturebox’a ürünün fotoğrafı geliyor. Kullanıcı beğendiyse ‘sepete yükle’ tuşuna basarak ürünü sepete yani richtextbox’a yüklüyor. En fazla stok sayısı kadar olmak şartıyla istediği kadar aynı ürünü yükleyebilir. Eğer kullanıcı ürünleri almak istemezse ‘sepeti boşalt’ adlı tuşa basıp richtextbox’ı temizleyebilir. Eğer kullanıcı ürünleri almak isterse ‘alışverişi tamamla’ adlı tuşa basıp ürünleri alabilir. Bu tuşa bastıktan sonra aldığı ürünlerin stok sayısında aldığı miktar kadar bir azalma oluyor ve bu azalma DataGridView’e yansıyor. 
![Ekran görüntüsü 2024-12-20 001538](https://github.com/user-attachments/assets/7dbca3c3-7706-409c-89c8-7c6e5042d7db)

# GEREKLİ SQL KODLARI
--veritabanı oluşturuyoruz
create database gorselProg
use gorselProg
--kullanacağımız tabloları oluşturuyoruz
create table urunlerTablosu(
urun_id int primary key identity(1,1),
renk varchar(50),
kategori varchar(50),
marka varchar(50),
fiyat int,
stok int,
resim nvarchar(MAX)
);
create table kullaniciTablosu(
kullanici_id int primary key identity(1,1),
isim varchar(50),
soyisim varchar(50),
sehir varchar(50),
email varchar(50),
sifre int,
);
create table yoneticiTablo(
yonetici_id int primary key identity(1,1),
isim varchar(50),
soyisim varchar(50),
email varchar(50),
sifre int,
);
insert into yoneticiTablo(isim ,soyisim,email,sifre)
values('emine','gunes','emine@gmail.com',1234);
insert into yoneticiTablo(isim ,soyisim,email,sifre)
values('agah','agah','agah@gmail.com',1221);

insert into kullaniciTablosu(isim,soyisim,sehir,email,sifre)
values('agah','agah','istanbul','agah@gmail.com',1234);
