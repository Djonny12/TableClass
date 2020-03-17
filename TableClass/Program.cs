using System;
using System.Collections;
using System.Threading;
using TableClass;
using System.Windows.Forms;

namespace tableclass
{
    class Program
    {
        [STAThread]

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
        }

    }
}
