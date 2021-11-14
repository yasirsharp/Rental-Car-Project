using Entities.IDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarNameInvalid = "Araç adı geçersiz.";
        public static string CarAdded = "Araç eklendi.";
        public static string CarInvalid = "Araç bulunamadı";
        public static string CarDeleted = "Araç başarıyla silindi.";
        public static string CarUpdated = "Araç başarıyla güncellendi.";
        public static string CarListed  = "Araçlar listelendi.";
        
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandNameInvalid = "Marka adı geçersiz";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandListed = "Markalar listelendi.";
        public static string BrandUpdated = "Marka güncellendi";
        
        public static string ColorAdded = "Renk eklendi.";
        public static string ColorNameInvalid = "Renk adı geçersiz.";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorUpdated = "Renk güncellendi.";
        public static string ColorListed  = "Renkler listelendi.";


        public static string SystemOffline= "Sistem bakımda!";
        
        public static string CustomerCompanyNameInvalid = "Müşteri bireysel/kurumsal ismi geçersiz lütfen kontrol edini!";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomerListed = "Müşteriler listelendi.";
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerIdNotSpace = "Müşteri id boş bırakılamaz.";
        
        public static string UserNameInvalid = "Gereçsiz kullanıcı adı.";
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string USerListed = "Kullanıcı/lar listelendi.";
        
        public static string RentalAddFailed = "Araç kiralanamadı.";
        public static string RentalAdded = "Araç başarıyla kiralandı.";
        public static string RentalDeleteFailed = "Araç Kiralama iptal edilemedi!";
        public static string RentalDeleted = "Araç Kiralama iptal edildi.";
        public static string RentalUpdateFailed = "Araç Kiralama güncellenenedi.";
        public static string RentalUpdated = "Araç Kiralama güncellendi.";
        public static string RentalListed = "Araç Kiraları listelendi.";
        public static string CheckDates = "Lütfen tarihleri kontrol ediniz.";
    }
}
