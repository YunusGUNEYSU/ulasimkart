using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izmirkart
{
    public class Bakiye
    {
        public bool control = true;
        private double _tutar;
        public double Tutar
        {
            get { return _tutar; }
            set {

                if (value >= 0)
                {
                    _tutar = value;
                }
                else
                    MessageBox.Show("Yetersiz Bakiye");
            }


           
        }
    }
}
