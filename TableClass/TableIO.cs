using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableClass
{
    class TableIO
    {
        
        public int Num;
        public string[,] ArrayFinal;

        //public TableIO()      // конструктор
        //{
        //    Console.WriteLine("Введите n");
        //    Num = int.Parse(Console.ReadLine());
        //    Console.WriteLine();

        //}

        public void Input(int N)
        {
            Num = N;
        }

        public void Output()
        {

            //TableOut tableOut = new TableOut();


            //for (int i = 0; i < Num; i++)     //Вывод двухмерного массива
            //{
            //    for (int j = 0; j < Num; j++)
            //    {
            //        Console.Write(ArrayFinal[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //int[,] Array = { { 1, 2, 3, 4, 5 },
            //                  { 6, 7, 8, 9, 10 },
            //                   { 11,12,13,14,15},
            //                  {16,17,18,19,20},
            //                  { 21,22,23,24,25} };
            //TableOut.dataGridView1.ColumnCount = 5;
            //dataGridView1.RowCount = 5;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int y = 0; y < 5; y++)
            //    {
            //        dataGridView1[i, y].Value = Array[y, i];
            //    }

            //}
        }


    }
}
