using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Tüzel Müşteri
    //Miras inheritance = Tüzel Müşteri bir müşteridir demektir.
    //Müşterideki özellikler Tüzel Müşteridede vardır.

    class Corporate :Customer    
    {      
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
