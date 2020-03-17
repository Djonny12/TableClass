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
    public partial class TableOut : Form
    {
        public TableOut()
        {
            InitializeComponent();


            
        }
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
        }
        
        
    }
}
