using System;

// вариант 5
// Создать класс Book: id, Название, Автор (ы),
//Издательство, Год издания, Количество страниц, Цена,
//Тип переплета. Свойства и конструкторы должны
//обеспечивать проверку корректности.

namespace laba3
{
    partial class Abiturient
    {
        private readonly int id; 
        private string surname;
        private string name;
        private string otchestvo;
        private uint adress;
        private uint phone;
        private uint mark1;
        private uint mark2;
        private uint mark3;



        static int counterObj = 0;

        static void classInfo()
        {
            Console.WriteLine(counterObj);
        }

        public Abiturient(string surname, string name, string otchestvo, uint adress, uint phone, uint mark1, uint mark2, uint mark3)
        {
            this.surname = surname;
            this.name = name;
            this.otchestvo = otchestvo;
            this.adress = adress;
            this.phone = phone;
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;


            counterObj++;
        }

        public Abiturient()
        {
        }

        public int Id
        {
            get
            {
                if (id > 0) return id;
                else return 0;
            }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Otchestvo
        {
            get { return otchestvo; }
            set { otchestvo = value; }
        }
        public uint Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public uint Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public uint Mark1
        {
            get { return mark1; }
            set { mark1 = value; }
        }
        public uint Mark2
        {
            get { return mark2; }
            set { mark2 = value; }
        }
        public uint Mark3
        {
            get { return mark3; }
            set { mark3 = value; }
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество учеников ");
            sbyte counter = sbyte.Parse(Console.ReadLine());
            Console.WriteLine();
            Abiturient[] spisok = new Abiturient[counter];
            for (int i = 0; i < counter; i++)
            {
                spisok[i] = new Abiturient();
                Console.WriteLine("Ученик №{0}:", i + 1);
                Console.WriteLine("Введите Фамилию ");
                spisok[i].Surname = Console.ReadLine();

                Console.WriteLine("Введите имя ученика ");
                spisok[i].Name = (Console.ReadLine());

                Console.WriteLine("Введите отчество ");
                spisok[i].Otchestvo = Console.ReadLine();

                Console.WriteLine("Введите адрес ");
                spisok[i].Adress = uint.Parse(Console.ReadLine());

                Console.WriteLine("Введите номер телефона ");
                spisok[i].Phone = uint.Parse(Console.ReadLine());

                Console.WriteLine("Введите оценку ученика по ООП ");
                spisok[i].Mark1 = uint.Parse(Console.ReadLine());

                Console.WriteLine("Введите оценку ученика по Дизайну ");
                spisok[i].Mark2 = uint.Parse(Console.ReadLine());

                Console.WriteLine("Введите оценку ученика по КС ");
                spisok[i].Mark3 = uint.Parse(Console.ReadLine());


                Console.WriteLine();

            }

            

            for (int i = 0; i < counter; i++)
            {
                if ((spisok[i].Mark1 + spisok[i].Mark2 + spisok[i].Mark3) < 12)
                {
                    Console.Write("Данный(е) ученик(и) имеют оценки ниже 4:");
                    Console.Write(" Фамилия: {0}", spisok[i].Surname);
                    Console.Write(" Оценка по ООП : {0}", spisok[i].Mark1);
                    Console.Write(" Оценка по Дизайну : {0}", spisok[i].Mark2);
                    Console.Write(" Оценка по КС : {0}", spisok[i].Mark3);
                    Console.WriteLine();

                }
            }


            Console.WriteLine("Введите заданное число");
            uint chislo = uint.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                if ((spisok[i].Mark1 + spisok[i].Mark2 + spisok[i].Mark3) >  chislo)
                {
                    Console.Write("Данный(е) ученик(и) имеют ср балл выше заданного числа:");
                    Console.Write(" Фамилия: {0}", spisok[i].Surname);
                    Console.Write(" Оценка по ООП : {0}", spisok[i].Mark1);
                    Console.Write(" Оценка по Дизайну : {0}", spisok[i].Mark2);
                    Console.Write(" Оценка по КС : {0}", spisok[i].Mark3);
                    Console.WriteLine();

                }
            }
        }




    }
}