using DesignPatternshw1.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternshw1.Concretes
{
    internal class Html : ITransport
    {
        public void Delivery() => Console.WriteLine("Clicked by Html button");
 
    }
}
