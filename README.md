# RentACar
<b>CQRS Mimarisi:</b>
Proje, CQRS prensiplerine dayanarak, komut ve sorgu sorumluluklarını ayırarak tasarlanmıştır.

<b>Modüler Servisler:</b> Uygulama, farklı işlevselliğe sahip modüler servisler içerir. Bu modüler servisler, bağımsız olarak geliştirilebilir ve sürdürülebilir bir yapı sağlar.

<b>Komut İşleme (Command Processing):</b> Komut işleme, araç kiralama taleplerini yönetir. Kullanıcılar, araç kiralamak, iade etmek gibi eylemleri gerçekleştirebilirler.

<b>Sorgu İşleme (Query Processing):</b> Sorgu işleme, araçları listeleme, kiralama geçmişini görüntüleme gibi kullanıcının bilgi almak istediği sorguları işler.

<b>Domain Olayları (Domain Events):</b> Projede, rentacar işlemleri ile ilgili önemli olaylar (events) kaydedilir. Bu olaylar, sistemin durumu hakkında bilgi sağlar.

<b>Teknolojiler</b>

<b>ASP.NET Core:</b> Uygulama, ASP.NET Core framework üzerine inşa edilmiştir.

<b>Entity Framework Core:</b> Veritabanı etkileşimleri için Entity Framework Core kullanılmıştır.

<b>MediatR:</b> MediatR kütüphanesi, CQRS prensiplerini uygulamak ve komut/sorgu işleme işlevselliğini kolaylaştırmak için kullanılmıştır.

<b>Swagger API Dökümantasyonu:</b> API'lerin anlaşılabilir ve test edilebilir olması için Swagger kullanılmıştır.
