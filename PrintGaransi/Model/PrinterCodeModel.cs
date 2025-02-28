using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPackingLabel.Model
{
    public class PrinterCodeModel
    {
        public void SaveData(string data)
        {
            Properties.Settings.Default.PrinterCode = data;
            Properties.Settings.Default.Save();
        }

        public string GetMode()
        {
            return Properties.Settings.Default.PrinterCode;
        }
    }
}
