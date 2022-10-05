using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string BrandAdded = "Marka eklendi";
        public static string ColorAdded = "Renk eklendi";
        public static string CarsListed = "Arabalar listelendi";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string UserRegistered = "Kayıt oluşturuldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
    }
}
