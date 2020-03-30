using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableClass
{
    public partial class TableOut : Form
    {
        public TableOut()
        {
            InitializeComponent();

        }

        // текст для печати
        private string result = "";


        public void DrawTable(int Num, string[,] ArrayFinal)
        {
            dataGridView1.ColumnCount = Num;
            dataGridView1.RowCount = Num;

            for (int i = 0; i < Num; i++)
            {
                for (int j = 0; j < Num; j++)
                {
                    dataGridView1[i, j].Value = ArrayFinal[i, j];

                }

            }


            // задаем текст для печати
            for (int i = 0; i < Num; i++)
            {
                for (int j = 0; j < Num; j++)
                {
                    result += ArrayFinal[i, j] + " ";

                }
                result += "\n";

            }
        }

        private void TableOut_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ = new Form1
            {
                Visible = true
            };
        }

        
        // обработчик события печати
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

       
        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            
            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog
            {

                // установка объекта печати для его настройки
                Document = printDocument
            };

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }
    }
}
