using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Gerçek Müşteri
    //Miras inheritance = Tüzel Müşteri bir müşteridir demektir.
    //Müşterideki özellikler Gerçek Müşteridede vardır.

    class Individual:Customer           
    {       
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
