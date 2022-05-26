using System;
using System.Collections.Generic;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            void Task1()
            {
                Console.WriteLine("Завдання 1: ");
                Bird S = new Sitter("Ряба");
                S.Fly();
                S.Sing();
                S.Eggs();
                S.Child();
                Console.WriteLine(S.GetHashCode());
                Console.WriteLine(S.ToString());

                Bird s = new Sitter("Ряба");
                Console.WriteLine(S.Equals(s));
                Console.WriteLine(s.GetHashCode());
                Console.WriteLine(s.ToString());

                Bird s2 = new Sitter("Ряба2");
                Console.WriteLine(S.Equals(s2));
                Console.WriteLine(s2.GetHashCode());
                Console.WriteLine(s2.ToString());

                Bird k = new Cuckoo("Ряба");
                Console.WriteLine(S.Equals(k));
                Console.WriteLine(k.GetHashCode());
                Console.WriteLine(k.ToString());

                int n = 5;
                Console.WriteLine(S.Equals(n));
                Console.WriteLine(n.GetHashCode());
                Console.WriteLine(n.ToString());


                Console.WriteLine("Список птахів: ");
                var B_l = new List<Bird>
                    { S, s, s2, k };
                Birds B = new Birds(B_l);
                B.Print_birds();
            }


            void Task2() 
            {
                List<Smartphone> Phones_list = new List<Smartphone> 
                { 
                    new Smartphone("Gallaxy A51", "Samsung", 6.5, 10000),
                    new Smartphone("iPhone 13", "Apple", 6.1, 29999),
                    new Smartphone("Redmi Note 11", "Xiaomi", 6.43, 8499),
                    new Smartphone("iPhone 11", "Apple", 6.1, 19999),
                    new Smartphone("Gellaxy S22", "Samsung", 6.1, 13999),
                    new Smartphone("Redmi 9A", "Xiaomi", 6.53, 4149)
                };

                Shop S = new Shop (Phones_list);
                Console.WriteLine("Кiлькiсть телефонiв на складi: " + S.Number_of_phones());
                Shop S1 = new Shop(S.Sort_by_model("iPhone 13"));
                S1.Print_phones("Телефони, вiдсортованi по моделi: ");
                Shop S2 = new Shop(S.Sort_by_produser("Samsung"));
                S2.Print_phones("Телефони, вiдсортованi по виробнику: ");
                Shop S3 = new Shop(S.Sort_by_size(6.1));
                S3.Print_phones("Телефони, вiдсортованi по розмiру дiагоналi: ");
                Shop S4 = new Shop(S.Sort_by_price(5000, 10000));
                S4.Print_phones("Телефони у вказаному цiновому дiапазонi: ");
                Shop S5 = new Shop(S.Find_by_parameters("Gallaxy A51", "Samsung", 6.5));
                S5.Print_phones("Телефон, що вiдповiдає вказаним параметрам: ");
                Shop S6 = new Shop(S.Find_by_parameters(p_to_f: "Apple", s_to_f: 6.1));
                S6.Print_phones("Телефон, що вiдповiдає вказаним параметрам2: ");

            }
            Console.WriteLine("Оберiть завдання 1 або 2:");
            var answer = Console.ReadLine();
            if (answer == "1") Task1();
            if (answer == "2") Task2();
        }
    }
}
