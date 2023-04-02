using DesignPatternshw1.Abstracts;
using DesignPatternshw1.Concretes;

//var kargo=new KamilKargo();
//kargo.Dialogs.Add(new WindowsDialog());
//kargo.Dialogs.Add(new HtmlDialog());
//var transport = kargo.Dialogs[1].CreateButton();
//transport.Delivery();
//BadDialog bd = new() { State="s" };
//ITransport transport = null;
//if (bd.State=="Windows")
//{
//    transport=new Windows();
//}
//else if (bd.State=="Html")
//{
//    transport=new Html();
//}
//else
//{
//    throw new Exception("\"Input in wrong,please write correctly\"");
  
//}
//transport.Delivery();

Dialog dialog = new CssDialog();   
var  transport = dialog.CreateButton();
transport.Delivery();