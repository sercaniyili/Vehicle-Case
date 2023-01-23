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
 git clone https://github.com/186-Teleperformans-Net-Bootcamp/ShoppingListProject-sercan-iyili
```
Projeyi build ederek gerekli veritabanları aşağıdaki komut ile oluşturulabilir.
```
 update-database
```

