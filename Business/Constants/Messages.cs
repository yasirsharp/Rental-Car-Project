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
    }
}
