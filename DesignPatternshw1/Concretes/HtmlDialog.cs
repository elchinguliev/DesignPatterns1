using DesignPatternshw1.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternshw1.Concretes
{
    internal class HtmlDialog : Dialog
    {
        public override void Render() => Console.WriteLine("Html Dialog");

        public override ITransport CreateButton() => new Html();

    }
}
