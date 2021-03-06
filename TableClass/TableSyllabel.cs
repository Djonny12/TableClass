﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableClass
{
    class TableSyllabel : TableIO
    {



        public string[,] Syllabel()
        {

            //***********************************Вывод таблицы слогов*******************************************

            
            string[] Array = new string[]{"ца","ка","на","га","ша","ща","за","ха","фа","ва","па","ра","ла","да","жа","ча","са","ма","та","ба",
                                          "цо","ко","но","го","шо","що","зо","хо","фо","во","по","ро","ло","до","жо","чо","со","мо","то","бо",
                                          "це","ке","не","ге","ше","ще","зе","хе","фе","ве","пе","ре","ле","де","же","че","се","ме","те","бе",
                                          "цу","ку","ну","гу","шу","щу","зу","ху","фу","ву","пу","ру","лу","ду","жу","чу","су","му","ту","бу",
                                          "цэ","кэ","нэ","гэ","шэ","щэ","зэ","хэ","фэ","вэ","пэ","рэ","лэ","дэ","жэ","чэ","сэ","мэ","тэ","бэ",
                                          "ця","кя","ня","гя","шя","щя","зя","хя","фя","вя","пя","ря","ля","дя","ся","мя","тя","бя",
                                          "ци","ки","ни","ги","ши","щи","зи","хи","фи","ви","пи","ри","ли","ди","жи","чи","си","ми","ти","би",
                                          "цю","кю","ню","гю","шю","щю","зю","хю","фю","вю","пю","рю","лю","дю","жю","чю","сю","мю","тю","бю",};

            var rnd = new Random();
            ArrayFinal = new string[Num, Num];
            int b;
            int lastnum = 1;
            string temp;


            if (Array.Length >= Num * Num)     // проверка на Num > Array.lenght
            {
                for (int i = 0; i < Num; i++)     //Заполнение двухмерного массива рандомом
                {
                    for (int j = 0; j < Num; j++)
                    {
                        b = rnd.Next(0, Array.Length + 2 - lastnum);
                        ArrayFinal[i, j] = Array[b];

                        if (b != Array.Length - lastnum)      //Сортировка массива
                        {
                            temp = Array[Array.Length - lastnum];
                            Array[Array.Length - lastnum] = Array[b];
                            Array[b] = temp;
                        }

                        lastnum++;
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
