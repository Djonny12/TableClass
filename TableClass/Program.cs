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

            //Console.WriteLine("Выберите режим работы:\n" +
            //                   "1. Цифры\n" +
            //                   "2. Слога\n" +
            //                   "3. Буквы\n");
            //int q = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //switch (q)
            //{
            //    case 1:
            //            //************************работа с цифрами***********************************

            //        TableNumber tn = new TableNumber();
            //        tn.Number();
            //        tn.Output();

            //        break;

            //    case 2:

            //         //***********************************работа со слогами*******************************
            //        TableSyllabel ts = new TableSyllabel();
            //        ts.Syllabel();
            //        ts.Output();

            //        break;

            //    case 3:
            //        //***********************************работа со слогами*******************************
            //        TableLetter tl = new TableLetter();
            //        tl.Letter();
            //        tl.Output();

            //        break;

            //    default:

            //        Console.WriteLine("Ошибка выбора!!!");

            //        break;
            //}

            //Console.ReadLine();
        }

    }
}
