using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interface arayüz, şablon.
    //interfaceleri birbirinin alternatifi olan ama kodları farklı olan durumlarda kullanırız.
   
    interface IKrediManager   //Okunurluk için başına I yazıyoruz.
    {
        void Hesapla();
        void BiseyYap();    

    }
}
