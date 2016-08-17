using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    interface ISellable
    {
        void SalesSpeech();
        void MakeSale(int number);
    }
}
