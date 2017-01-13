using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latourrette_VAT_WS
{
    public partial class checkVatCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        public void show_vat_info()
        {
            MessageBox.Show(name+address, countryCode + vatNumber);
        }
    }
    
}
