using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Contants
{
    public static class Messages
    {
        public static string ProductAdded = "Urun basariyla eklandi";
        public static string ProductDeleted = "Urun basariyla silindi";
        public static string ProductUpdated = "Urun basariyla guncellendi";
        public static string UserNotFound = "Kullanici Bulunamadi";
        public static string PasswordError="Sifre hatali";
        public static string SuccessfulLogin="Sisteme giris basarili";

        public static string UserAlreadyExists = "Bu kullanici movcut";

        public static string UserRegistered = "Kullanici basariyla Olusturuldu";

        public static string AccessTokenCreated = "Acces Token Basariyla olusturuldu";
    }
}
