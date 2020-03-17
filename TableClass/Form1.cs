using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent ();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(sizeTable.Value);
            
            int q = 0;
            if (numberButton.Checked == true)
                q = 1;
            if (syllabelButton.Checked == true)
                q = 2;
            if (letterButton.Checked == true)
                q = 3;

            TableOut tableOut = new TableOut();

            switch (q)
            {
                case 1:
                    //************************работа с цифрами***********************************
                    this.Hide();
                    TableNumber tn = new TableNumber();
                    tn.Input(N);
                    tn.Number();
                    //tn.Output();
                    tableOut.Visible = true;
                    

                    break;

                case 2:

                    //***********************************работа со слогами*******************************
                    this.Hide();
                    TableSyllabel ts = new TableSyllabel();
                    ts.Input(N);
                    ts.Syllabel();
                    //ts.Output();
                    tableOut.Visible = true;

                    break;

                case 3:
                    //***********************************работа со слогами*******************************
                    this.Hide();
                    TableLetter tl = new TableLetter();
                    tl.Input(N);
                    tl.Letter();
                    //tl.Output();
                    tableOut.Visible = true;


                    break;
            }
        }

    }
}
