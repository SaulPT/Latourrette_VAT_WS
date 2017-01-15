using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latourrette_VAT_WS.VAT_Number_SOAP_WS
{
    public partial class checkVatCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        //MESSAGE GENERATOR FROM REQUEST RESULT
        public string result_message()
        {
            if (!Cancelled)
            {
                if (Error != null)
                {
                    return "Operation failed." + Environment.NewLine + "Server says: " + Error.Message;
                }
                else
                {
                    string message;
                    if (!valid)
                    {
                        if (name == "" && address == "")
                        {
                            message = "Unable to get information about personal VAT Numbers";
                        }
                        else if (name == "---" && address == "---")
                        {
                            message = "Invalid VAT Number";
                        }
                        else
                        {
                            message = "Uknown error";
                        }
                    }
                    else
                    {
                        message = name + "\n" + address;
                    }

                    return (countryCode + vatNumber + "\n\n" + message).Replace("\n", Environment.NewLine);
                }
            }
            else
            {
                return null;
            }
        }

    }
    
}
