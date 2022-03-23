using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izmirkart
{
    public class Ogrenci:Bakiye
    {
        private int _idogrenci;
       public int Idogrenci
        {
            get { return _idogrenci; }
            set { _idogrenci = value; }
           
        }
        
    }
}
