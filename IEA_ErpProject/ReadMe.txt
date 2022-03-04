1. Form1 -> AnaSayfa olarak adlandırdık 
2. Anasayfanın içerisine TabControl eklendi, en üste konuşlandırıldı.
3. TabControlün Tab1 ine -> Genel yazıldı. TabPage2 -> Yonetim yazıldı.
4. Splitter usta ekledik property den ayarlarını yaptık
5. Panel ekledik ve sola yasladık.
6. Bir tane daha splitter usta ekledik ve ayarladık. Onuda panele yasladık.
7. Ortaya bir panel daha ekledik içine textbox, label ve 2 tane button ekledik ayarlarını property den yaptıktan sonra sola yaslanan      panelin içine taşıdık
8. Solda ki panelin içine splitterContainer ekledik propertylerini yaptık panel1'in içine treewiev ekledik, property den ayarlarını yaptık. Panel2 ye button ekledik.Arama fotosu eklemek için button ekledik ve backgroundimage ekleyip Layoutunu Stretch yaptık.
9. Ana sayfa property sinde isMdiContainer özelliğini True yaptık.
10. Code tarafına gecmek icin ana sayfa formuna çift tıkladık 
11. Bilgi giriş için olusuturulan button a çift tıklayarak kod tarafinda click event methodunu oluşturduk(cagırdık,implemente ettik)
12. lblMenu.text nin icine buttonun textini gönderdik.(Çift tıkladığımızda yazının gelmesini sağlamak) 
13. MenuOlustur() methodunu yazdık hata veren bu code un uzerinde sağ click yaptık ve bu methodun generate edilmesini sagladik.
14. MenuOlustur() methodunun icinde tvMenu icinde olusmasi gereken nodes lari yazdik.



SERVER 14.02.2022

1.server explorer a gelip sağ tıklayıp create new server dicez.
2. açılan sayfada ıd kısmını seçip identity specification kısmından TRUE yapıcaz.
3.server Explorer dan table ye gelip new table diyecez,Tabloda ki verileri girdikten sonra update dicez, ardından update database demediğimiz sürece tablo oluşmuş olmaz.
4.İkinci tabloyu oluşturduktan sonra hastaneler tablosuna gelip sağ tarafda ki foreign key e tıklayıp diğer tablonn ismini giricez.
5. Ardından kod kısmında CONSTRAINT [FK_tblHastaneler_tblHastaneTipleri] FOREIGN KEY ([TipId]) REFERENCES [tblHastaneTipleri]([Id]) yazmasını sağlayacaz ve Update edecez.
6.Proje dosyasına Entity adında bir klasör oluşturucaz. Ardından entity e sağ tıklayıp Add New İtem diyeceğiz. Sol taraftan Data seçip Ado.NET i oluşturucaz. Tek Tek ayarları yaptıktan sonra tablo bağlantıları eklenmiş olucak.
7. HastaneGiris i açıp ardından üst tarafa 5 tane button oluşturduk.
8.butonların backgroundimageini  tek tek yerleştirip düzenledik.
9.Hastane girişin ortasını ikiye bölmek için splitcontainer kullandık.
10.panel 2 yi horizontol yapıp alt tarafa datagridview ekliyoruz. Sonra Datagripview deki kulakcığa tıklayıp edit Columbs diyoruz.
11. Ardından üst kısma 8 tane label ekledik ve combobox , maskedbox ekleyip ayarladık. combobox in içine yazı yazılmasını engellemek için Drop down style yapmamız gerekiyor.
12.DataGridWiev de her şey display cells yapılıyor. sadece HastaneAdi Fill olarak ayarlayacaz.




15. wiev tab order diyerek tab sırasını ayarlayabilirsin.
16.Tables a gelip new query diyoruz. Sehirleri internetten alıp kopyala yapıştır yapıyoruz ve sehirler adında bir table ekleniyor. Ardından hastane dbsine (sehir id ) ekledik. ardından ssms e girip diagramı güncelledik sonra entity e gelip update model form database yapıp refresh ve add yapıp ardından ana tabloyu silip tekrar upload edip tabloyu güncel tuttuk.
17. tblHastaneler den foreign keys eklemelerini yapıyoruz.
18. Entity klasöründe ki erpProModel kısmına gelip sağ tıklayarak Update model diyoruz ,Ardından tablolara gelip update model from database diyip tables dan gerekli şeyleri seçiyoruz.
19. Hastanetipi ve sehir combobox olduğu için DropDownStyle ını DropDownList olarak değiştirdik.




15.02.2022

1.Hastaneler Listesi Splitcontainer ile ekranı bölüp yazıyı sağ tarafın içine dock dan sabitledik
2.DataGridviev koyarak dock ini fill(orta) yapıyoruz.
3.Ardından HastaneGirisin alt kısmını kopyalayıp hastane Listesine gelip yapıştırdık ve dock ayarladık.
4. Gerekli kodu alıp kopyalayıp yapıştırdık.
5. ana sayfaya public static int Aktarma = -1; ekledik.



16.02.2022(Çarşamba)

1. Yeni bir tablo oluşturduk dbo.tblDetaylar adında.
2.Set Primary Key yaptık
3. İdentity True yaptık.
4.Keys unnamed kısmını sildik.
5.CREATE TABLE kısmında ki [dbo].[tblDetaylar] olarak değiştiricez.
6.Tablo verilerini girip Update yaptık.
7.Tabloları bağlamak için Foreign key kısmına Add new key diyip ismini FK_tblDepartmanlar_tblHastaneler(ekleyeceğimiz tablo sonradan yazılır.) olarak değiştirdik.
8. Alt tarafda ki ismi CONSTRAINT [FK_tblDepartmanlar_tblHastaneler] FOREIGN KEY (GirisTipId) REFERENCES [tblHastaneler](Id) 
) yaptık.
9. Bir tablonun foreign key i ile  Primary key ini bağlamış oluyoruz.
10. Tablolara gelip sağ tıklayarak Show Table Data diyerek tablonun elemanlarını oluşturuyoruz.
11