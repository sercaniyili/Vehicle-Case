# Vehicle-Case

Kullanıcılar araba ekleyebilir,silebilir. Araba, otobüs, teknelerin hepsini yada renklerine göre filtreleyerek listeleyebilir. 
Ayrıca arabaların farlarını açıp kapatabilirler.

***Postman*** yada ***Swagger*** ile kullanılan *Rest API* projesinde verileri saklamak için veri tabanı olarak ***MS SQL***, .Net ile bağlantı için *orm* olarak ***EntityFramework Core*** 
kullanılmıştır. Belirli sayıda araba, tekne ve otobüs *seed data* *ef core* aracılığıyla eklenmiştir.

Veri tabanı ile rutin etkileşimler için 
*repository pattern* kullanılmıştır. Her *domain* için ayrı ayrı iş sınıları(Business)
oluşturulmuş, bu sınıflar üzerinden *controller* işlem yapılmıştır.

Projede *n tier architecture* ayrıca *global exception custom middleware* üzerinden gerçekleştirilmiştir.


___
## Kullanılan Yöntem ve Teknolojiler
* ***.NET 6.0 Web API***
 * ***Microsoft SQL***
 * ***Entity Framework***
 * ***Automapper***
 * ***Fluent Validation***
 * ***N-tier Architecture***
 * ***Repository Pattern***
 * ***SOLID Principles***
 * ******
 
___

## Projeyi Geliştirici Ortamında Çalıştırmak İçin

### Ön Gereksinimler
* Visual Studio 2020+
* Microsoft SQL Server 2019+
* .Net 6.0

### Çalıştırılması
Local klasöre projeyi klonlamak için :
```
 git clone https://github.com/sercaniyili/Vehicle-Case
```
Projeyi build ederek gerekli veritabanları aşağıdaki komut ile oluşturulabilir.
```
 update-database
```
<br/>


- API Endpoints

<img src=https://github.com/sercaniyili/Vehicle-Case/blob/main/images/api-endpoints.png />

- Bütün arabalar listeleniyor

<img src=https://github.com/sercaniyili/Vehicle-Case/blob/main/images/car.all.png />


- Renge göre filtrelenen arabalar listeleniyor

<img src=https://github.com/sercaniyili/Vehicle-Case/blob/main/images/car.bycolor.png />


- Olmayan renge göre arabalar listelenemiyor

<img src=https://github.com/sercaniyili/Vehicle-Case/blob/main/images/car.unmatch.png />


- Yeni araba ekleniyor

<img src=https://github.com/sercaniyili/Vehicle-Case/blob/main/images/car.add.png />

<img src=https://github.com/sercaniyili/Vehicle-Case/blob/main/images/car.add.db.true.png />


- Araba id'ye göre siliniyor

<img src=https://github.com/sercaniyili/Vehicle-Case/blob/main/images/car.delete.true.png />

<img src=https://github.com/sercaniyili/Vehicle-Case/blob/main/images/car.dele.db.png />


- Id'si olmayan araba silinemiyor

<img src=https://github.com/sercaniyili/Vehicle-Case/blob/main/images/car.delete.false.png />


- Id'ye göre istenen aracın farları açılıp kapanabiliyor

<img src=https://github.com/sercaniyili/Vehicle-Case/blob/main/images/car.lights.turn.png />


- Renge göre filtrelenen otobüsler listeleniyor

<img src=https://github.com/sercaniyili/Vehicle-Case/blob/main/images/buses.bycolor.png />


- Renge göre filtrelenen tekneler listeleniyor

<img src=https://github.com/sercaniyili/Vehicle-Case/blob/main/images/boats.bycolor.png />

