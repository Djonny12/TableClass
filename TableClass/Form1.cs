using System;
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

            TableOutForm tableOut = new TableOutForm();

            switch (q)
            {
                case 1:
                    //************************работа с цифрами***********************************
                    this.Hide();
                    TableNumber tn = new TableNumber();
                    tn.Input(N);
                    tn.Number();
                    tableOut.Visible = true;
                    tableOut.DrawTable(N, tn.ArrayFinal);


                    break;

                case 2:

                    //***********************************работа со слогами*******************************
                    this.Hide();
                    TableSyllabel ts = new TableSyllabel();
                    ts.Input(N);
                    ts.Syllabel();
                    tableOut.Visible = true;
                    tableOut.DrawTable(N, ts.ArrayFinal);

                    break;

                case 3:
                    //***********************************работа со слогами*******************************
                    this.Hide();
                    TableLetter tl = new TableLetter();
                    tl.Input(N);
                    tl.Letter();
                    tableOut.Visible = true;
                    tableOut.DrawTable(N, tl.ArrayFinal);

                    break;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
