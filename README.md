# RentACar
CQRS Mimarisi:
Proje, CQRS prensiplerine dayanarak, komut ve sorgu sorumluluklarını ayırarak tasarlanmıştır.

Modüler Servisler: Uygulama, farklı işlevselliğe sahip modüler servisler içerir. Bu modüler servisler, bağımsız olarak geliştirilebilir ve sürdürülebilir bir yapı sağlar.

Komut İşleme (Command Processing): Komut işleme, araç kiralama taleplerini yönetir. Kullanıcılar, araç kiralamak, iade etmek gibi eylemleri gerçekleştirebilirler.

Sorgu İşleme (Query Processing): Sorgu işleme, araçları listeleme, kiralama geçmişini görüntüleme gibi kullanıcının bilgi almak istediği sorguları işler.

Domain Olayları (Domain Events): Projede, rentacar işlemleri ile ilgili önemli olaylar (events) kaydedilir. Bu olaylar, sistemin durumu hakkında bilgi sağlar.

<b>Teknolojiler</b>

ASP.NET Core: Uygulama, ASP.NET Core framework üzerine inşa edilmiştir.

Entity Framework Core: Veritabanı etkileşimleri için Entity Framework Core kullanılmıştır.

MediatR: MediatR kütüphanesi, CQRS prensiplerini uygulamak ve komut/sorgu işleme işlevselliğini kolaylaştırmak için kullanılmıştır.

Swagger API Dökümantasyonu: API'lerin anlaşılabilir ve test edilebilir olması için Swagger kullanılmıştır.
