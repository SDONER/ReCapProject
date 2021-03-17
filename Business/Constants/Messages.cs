using Core.Entities.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        
        public static string CarAdded ="Ürün eklendi";
        public static string CarDeleted ="Ürün silindi";
        public static string CarUpdated ="Ürün güncellendi";
        public static string CarNameInvalid ="Ürün ismi geçersiz";
        public static string MaintenanceTime ="Sistem bakımda!!!";
        public static string CarsListed ="Araçlar listelendi";

        public static string CustomerAdded = "Yeni Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri veitabanından silindi";
        public static string CustomerUpdated = "Müşteri bilgileri güncellendi";

        public static string RentalAdded = "Yeni kiralama işlemi tamamlandı";
        public static string RentalDetailListed= "Kiralanabilecek araç detayları listelendi";
        public static string RentalListed = "Kiralık araçlar listelendi";
        public static string RentalDeleted = "Araç kaydı silindi";
        public static string RentalCancelled = "Kiralama kaydı iptal edildi";
        public static string RentalUpdated= "Kiralama bilgileri güncellendi";

        public static string CategoryAdded = "Kategori eklendi";
        public static string CategoryUpdated = "Kategori güncellendi";
        public static string CategoryDeleted = "Kategori silindi";

        public static string CarImageAdded = "Araç resmi eklendi";
        public static string CarImageCountOfImageError = "Bir araç için en fazla 5 adet resim eklenebilir!";
        public static string CarImageDeleted = "Araç resmi silindi";
        public static string CarImagesListed = "Araçlar listelendi";
        public static string CarImageCountIsNotMoreThanFive = "Bir araç için en fazla 5 adet resim eklenebilir!";
        public static string AuthorizationDenied = "Yetkiniz yok";


        public static string UserRegistered = "Kayıt başarılı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string UserAlreadyExists = "Kullanıcı zaten tanımlı";
    }
}
