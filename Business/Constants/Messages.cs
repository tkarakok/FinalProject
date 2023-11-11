using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım Saati";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductsCountOfCategoryCheck = "Kategorideki ürün sayısı maksimum 10 olabilir";
        public static string ProductNameExists = "Aynı isimli 1'den fazla ürün olamaz";
        public static string CategoryLimitExceded = "Kategori limit aşıldı ";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı eklendi";
        public static string UserNotFound = "Kullanıcı mevcut değil";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "token oluşturuldu";
    }
}
