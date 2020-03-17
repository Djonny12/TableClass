using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableClass
{
    class TableLetter : TableIO
    {

        public string[,] Letter() 
        {
            //****************Вывод таблицы букв**************************

            string[] ArrayLetter = new string[] { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };

            int lastnumLetter = 1;
            string tempLetter;
            int b;
            var rnd = new Random();
            ArrayFinal = new string[Num, Num];

            if (ArrayLetter.Length >= Num * Num)     // проверка на Num > Array.lenght
            {
                for (int i = 0; i < Num; i++)     //Заполнение двухмерного массива рандомом
                {
                    for (int j = 0; j < Num; j++)
                    {
                        b = rnd.Next(0, ArrayLetter.Length + 1 - lastnumLetter);
                        ArrayFinal[i, j] = ArrayLetter[b];

                        if (b != ArrayLetter.Length - lastnumLetter)      //Сортировка массива
                        {
                            tempLetter = ArrayLetter[ArrayLetter.Length - lastnumLetter];
                            ArrayLetter[ArrayLetter.Length - lastnumLetter] = ArrayLetter[b];
                            ArrayLetter[b] = tempLetter;
                        }

                        lastnumLetter++;
                    }

                }

            }
            else
            {
                MessageBox.Show("Неверное значение", "Ошибка", MessageBoxButtons.OK);
                Application.Restart();
            }

            return ArrayFinal;
        }
    }
}
