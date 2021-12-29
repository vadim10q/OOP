using System;
using System.Text; //StringBuilder
using System.Linq; //Arrays

namespace lab2
{
    class Program
    {

        static void taskTypes()
        {

            int a1 = 373;
            byte a2 = 255;
            sbyte a3 = -128;
            short a4 = -3000;
            ushort a5 = 65535;
            long a6 = 9223372036854775807L;
            ulong a7 = 18446744073709551615;
            uint a8 = 25000000;
            bool a9 = true;

            float a10 = 95.23F;
            double a11 = 42.323423;
            decimal a12 = 36.4748948M;



            string a15 = "ok";
            object a16 = "fefs";





            //явные
            Console.Write("Введите значение переменной типа uint: ");
            a8 = Convert.ToUInt32(Console.ReadLine());

            Console.Write("Введите значение переменной типа short: ");
            a10 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите значение переменной типа int: ");
            a1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение переменной типа sbyte: ");
            a3 = sbyte.Parse(Console.ReadLine());




            //неявные

            a4 = a2; //short <- byte
            a6 = a1 * 100; //long <- int
            a11 = 2.45 * a10; //double <- float
            a1 = a3;//int <- sbyte
            a12 = a1; //decimal <- int





            Console.WriteLine($"bool:{a9}\tbyte: {a2}\tsbyte: {a3}");
            Console.WriteLine($"short: {a4}\tushort: {a5}\tlong: {a6}");
            Console.WriteLine($"ulong: {a7}\tuint: {a8}\tint{a1}");
            Console.WriteLine($"float: {a10}\tdouble: {a11}\tdecimal: {a12}\t");
            Console.WriteLine($"tstring: {a15}\t");



            Console.WriteLine();

            int Value = 5;
            object boxValue = Value;
            int unboxValue = (int)boxValue;

            var valueVar = 455;
            valueVar++;
            //valueVar = "c";

            dynamic valueDinamic = 0;
            valueDinamic = "c"; //можно



            //5
            Console.WriteLine("Nullable types");
            int? i = 5;
            Console.WriteLine(i.HasValue); //true
            Console.WriteLine(i ?? 100); //5
            i = null;
            Console.WriteLine(i.HasValue); //false
            Console.WriteLine(i ?? 100); //100

            Console.ReadKey();
        }

        static void taskStrings()
        {


            /*object a100 = 7;
            object b0 = 7;
            Console.WriteLine(a100 == b0) //false;
            object H = "noo";
            object F = "noo";
            Console.WriteLine(H == F); //true */


            string string1 = "Hello World";
            string string2 = "Goodbye World";
            Console.WriteLine(string1.Equals("Hello World")); //true
            Console.WriteLine(String.Equals(string1, string2)); //false
            Console.WriteLine(string1.StartsWith("Hello")); //true
            Console.WriteLine(string1.EndsWith("Hello")); //false
            string copyStr = string1;



            string string3 = "The World";
            Console.WriteLine(string1 + " " + string2 + " " + string3);

            //// подстрока
            string sentence = "Find New string";
            int startPos = 5;
            string newSentence = sentence.Substring(startPos); //New string
            Console.WriteLine(newSentence);
            int endPos = newSentence.IndexOf(" ");
            newSentence = sentence.Substring(startPos, endPos); //New
            Console.WriteLine(newSentence);

            string littleStr = sentence.Remove(startPos, newSentence.Length + 1);
            //Find string
            //string littleStr = sentence.Remove(startPos, endPos);
            Console.WriteLine(littleStr);

            string[] split = sentence.Split(" ");
            Console.WriteLine(split[2] + " " + split[0] + " " + split[1]);//stringFindNew


            sentence = sentence.Insert(startPos, split[1]); //Find NewNew string
            Console.WriteLine(sentence);
            //интерполировние — ($" ")
            ///

            string strNull = null; //значение отсутсвует
            string strVoid = ""; //значение нулевое
            if (string.IsNullOrEmpty(strNull) && string.IsNullOrEmpty(strVoid))
            {
                Console.WriteLine("There are Null or Empty");
            }
            //в базе данных хранится адрес
            //если например неизвестен, лучше адрес будет отсутствовать чем быть ничем
            //больше подходит для примера с числами (возраст не 0,а просто отсутсвует)


            var sb = new StringBuilder();
            string app = "Hello!";
            string app2 = "My name is TOTONTOTOKYO ";
            int num = 15;
            sb.Append('—', num);//Добавляет строковое представление указанного объекта к данному экземпляру
            sb.AppendLine(app);//Добавляет знак завершения строки по умолчанию или копию указанной строки и
                               //знак завершения строки по умолчанию в конце этого экземпляра.
            sb.AppendLine(app2);
            sb.Remove(15,
            app.Length);//Возвращает новую строку, в которой
                        //было удалено указанное число символов в указанной позиции.
            sb.Insert(app2.Length + num + 1, app);//Возвращает новую строку, в которой
                                                  //указанная строка вставляется в указанной позиции индекса в данном экземпляре.


            string s = sb.ToString();
            Console.WriteLine(s);
            //намного производительнее строк при работе с большими объемами памяти
            Console.ReadKey();
        }
        static void taskArray()
        {

            Console.WriteLine("Введите размер для двумерного квадратного массива:");
            int size = Int32.Parse(Console.ReadLine());


            var arraySquare = new int[size, size];
            Random rand = new Random();

            for (int a = 0; a < size; a++) //
            {
                for (int b = 0; b < size; b++)
                {
                    arraySquare[a, b] = rand.Next(20);
                    Console.Write(arraySquare[a, b] + "\t");
                }
                Console.WriteLine();
            }






            string[] arrayString = { "Sunday", "Monday", "Tuersday",
"Wednesday", "Thirsday", "Friday", "Saturday" };

            foreach (string item in arrayString)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Size of arraySrting is {0}", arrayString.Length);




            var arrayStepwise = new int[3][];

            arrayStepwise[0] = new int[2];
            arrayStepwise[1] = new int[3];
            arrayStepwise[2] = new int[4];

            Console.WriteLine("Enter :");

            for (int i = 0; i < arrayStepwise.Length; i++)
            {
                for (int j = 0; j < arrayStepwise[i].Length; j++)
                {
                    arrayStepwise[i][j] = Int32.Parse(Console.ReadLine());//Преобразует строковое представление числа в
                                                                          //эквивалентное ему 32-битовое целое число со знаком.

                }

            }

            Console.WriteLine();

            for (int i = 0; i < arrayStepwise.Length; i++)
            {
                for (int j = 0; j < arrayStepwise[i].Length; j++)
                {
                    Console.Write(arrayStepwise[i][j] + " ");

                }
                Console.WriteLine();
            }

            Console.ReadKey();


        }

        static void taskTuple()
        {
            (int, string, char, string, ulong) tuple = (666, "Yatoro", '!', "Miposhka", 2048);
            Console.WriteLine(tuple);
            Console.WriteLine(tuple.Item2 + "\t" + tuple.Item4);

            var (age, name, symbol, surname, number) = tuple; //распаковка 1
            Console.WriteLine($"age: {age}; symbol: {symbol}; number: {number}");
            (age, name) = (10, "Антон"); //распаковка 2

            //сравнение
            var tuple2 = (0, code: "code033", sex: 'M', mute: "yes", Convert.ToUInt64(6666));
            Console.WriteLine($"{tuple} == {tuple2} {tuple == tuple2}");

            Console.ReadKey();

        }

        static void taskCheck()
        {
            void check(int a)
            {
                try
                {
                    checked
                    {
                        Console.WriteLine((byte)a);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            void uncheck(int a)
            {
                unchecked
                {
                    Console.WriteLine((byte)a);
                }
            }

            int a = 300;

            check(a);
            uncheck(a);

            Console.ReadKey();

        }

        static void Main(string[] args)
        {

            void taskTuple2()
            {
                (int, int, int, char) foo(int[] arr, string str)
                {
                    return (arr.Max(), arr.Min(), arr.Sum(), str[0]);
                }
                var arr = new int[10];
                var rand = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(30);
                    Console.Write(arr[i] + " ");
                }
                string str = "Team Spirit";
                var res = foo(arr, str);
                Console.WriteLine("\n" + res);

                Console.ReadKey();
            }





            Console.WriteLine("Enter num of task; ");
            int choice = Int32.Parse(Console.ReadLine());

            while (choice != 0)
            {

                switch (choice)
                {
                    case 1:
                        taskTypes();
                        break;
                    case 2:
                        taskStrings();
                        break;
                    case 3:
                        taskArray();
                        break;

                    case 4:
                        taskTuple();
                        break;

                    case 5:
                        taskCheck();
                        break;

                    case 6:
                        taskTuple2();
                        break;



                }
                Console.Clear();
                Console.WriteLine("Enter num of task; ");
                choice = Int32.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}