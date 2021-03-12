using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constantsi
{
    public class Messages
    {
       public static string CarNameValid = "Lütfen ekleyeceğiniz aracın isminin 2 harften " +
            "uzun ve günlük ücreti 0 TL'den yüksek olmalıdır";
       public static string Added = "Eklendi";
       public static string Deleted = "Silindi";
       public static  string Updated = "Güncellendi";
       public static string Listed = "Güncellendi";
       public static string ErrorBrandName = "Girdiğiniz marka bilgisi en az iki harften oluşmalıdır.";
        public static string ReturnDateIsNull = "Kiralamak istediğiniz araç şu anda teslim edilmemiştir.";
    }
}
