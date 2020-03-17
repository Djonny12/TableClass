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

        }

        public TableOut(int Num, string ArrayFinal)
        {
            InitializeComponent();


            //int[,] Array = { { 1, 2, 3, 4, 5 },
            //                  { 6, 7, 8, 9, 10 },
            //                   { 11,12,13,14,15},
            //                  {16,17,18,19,20},
            //                  { 21,22,23,24,25} };
            //dataGridView1.ColumnCount = 5;
            //dataGridView1.RowCount = 5;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int y = 0; y < 5; y++)
            //    {
            //        dataGridView1[i, y].Value = Array[y, i];
            //    }

            //}



            //int[,] Array = { { 1, 2, 3, 4, 5 },
            //                  { 6, 7, 8, 9, 10 },
            //                   { 11,12,13,14,15},
            //                  {16,17,18,19,20},
            //                  { 21,22,23,24,25} };
            dataGridView1.ColumnCount = Num;
            dataGridView1.RowCount = Num;
            

            for (int i = 0; i < Num; i++)
            {
                for (int j = 0; j < Num; j++)
                {
                    dataGridView1[i, j].Value = ArrayFinal[i, j] ;
                    
                }

            }
        }

        
    }
}
