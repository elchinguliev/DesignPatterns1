using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternshw1.Abstracts
{
    internal abstract class Dialog
    {
        public virtual void Render() => Console.WriteLine("Dialog");
        public abstract ITransport CreateButton();
    }
}
