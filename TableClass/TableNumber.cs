using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableClass
{
    class TableNumber : TableIO
    {

        public string[,] Number()
        {
            //********************************Вывод числовой таблицы с помощью другого массива******************************
            
            ArrayFinal = new string[Num, Num];
            int[] Array = new int[Num*Num];
            var rnd = new Random();
            int a = 1;
            int b;
            string c;
            int lenght = Num * Num;
            int temp;

            for (int i = 0; i < lenght; i++)     //Заполнение одномерного массива
            {
                Array[i] = a;
                a++;
            }

            for (int i = 0; i < Num; i++)     //Заполнение двухмерного массива рандомом
            {
                for (int j = 0; j < Num; j++)
                {
                    b = rnd.Next(0, lenght);
                    c = Convert.ToString(Array[b]);
                    ArrayFinal[i, j] = c;

                    if (b != lenght-1)      //Сортировка массива
                    {
                        temp = Array[lenght - 1];
                        Array[lenght - 1] = Array[b];
                        Array[b] = temp;
                    }

                    lenght--;
                }
            }

            return ArrayFinal;
        }
              

    }
}
