using DesignPatternshw1.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternshw1.Concretes
{
    internal class WindowsDialog : Dialog
    {
        public override void Render() => Console.WriteLine("Windows Dialog");

        public override ITransport CreateButton() => new Windows();
    
    }
}
