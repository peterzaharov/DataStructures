using LinkedList.Model.HashTable;
using LinkedList.Model.Map;
using LinkedList.Model.Set;
using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var dict = new Dict<int, string>();
                dict.Add(new MapItem<int, string>(1, "Один"));
                dict.Add(new MapItem<int, string>(1, "Один"));
                dict.Add(new MapItem<int, string>(2, "Два"));
                dict.Add(new MapItem<int, string>(3, "Три"));
                dict.Add(new MapItem<int, string>(4, "Четыре"));
                dict.Add(new MapItem<int, string>(5, "Пять"));
                dict.Add(new MapItem<int, string>(101, "Сто один"));

                foreach (var item in dict)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine(dict.Search(7) ?? "Не найдено");
                Console.WriteLine(dict.Search(3) ?? "Не найдено");

                dict.Remove(3);
                dict.Remove(1);

                foreach (var item in dict)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();

            {
                var easyMap = new EasyMap<int, string>();
                easyMap.Add(new MapItem<int, string>(1, "Один"));
                easyMap.Add(new MapItem<int, string>(2, "Два"));
                easyMap.Add(new MapItem<int, string>(3, "Три"));
                easyMap.Add(new MapItem<int, string>(4, "Четыре"));
                easyMap.Add(new MapItem<int, string>(5, "Пять"));

                foreach (var item in easyMap)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine(easyMap.Search(7) ?? "Не найдено");
                Console.WriteLine(easyMap.Search(3) ?? "Не найдено");

                easyMap.Remove(3);
                easyMap.Remove(1);

                foreach (var item in easyMap)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();

            {
                var superHashTable = new SuperHashTable<Person>(100);
                var person = new Person() { Name = "Вася", Age = 25, Gender = 0 };
                superHashTable.Add(new Person() { Name = "Петя", Age = 35, Gender = 0 });
                superHashTable.Add(new Person() { Name = "Андрей", Age = 15, Gender = 0 });
                superHashTable.Add(new Person() { Name = "Катя", Age = 15, Gender = 1 });
                superHashTable.Add(person);

                Console.WriteLine(superHashTable.Search(new Person() { Name = "Вася", Age = 25, Gender = 0 }));
                Console.WriteLine(superHashTable.Search(person));
            }

            Console.WriteLine();

            {
                var hashTable = new HashTable<int, string>(100);
                hashTable.Add(5, "Привет");
                hashTable.Add(18, "Мир");
                hashTable.Add(777, "Здравствуй");
                hashTable.Add(7, "Программист");

                Console.WriteLine(hashTable.Search(6, "Вася"));
                Console.WriteLine(hashTable.Search(18, "Мир"));
            }

            Console.WriteLine();

            {
                var badHashTable = new BadHashTable<int>(100);
                badHashTable.Add(5);
                badHashTable.Add(18);
                badHashTable.Add(777);

                Console.WriteLine(badHashTable.Search(6));
                Console.WriteLine(badHashTable.Search(18));
            }

            Console.WriteLine();

            {
                var easySet1 = new EasySet<int>(new int[] { 1, 2, 3, 4, 5 });
                var easySet2 = new EasySet<int>(new int[] { 4, 5, 6, 7, 8 });
                var easySet3 = new EasySet<int>(new int[] {3, 4, 5 });

                Console.Write("Union: ");
                foreach(var item in easySet1.Union(easySet2))
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

                Console.Write("Intersection: ");
                foreach (var item in easySet1.Intersection(easySet2))
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

                Console.Write("Difference A \\ B: ");
                foreach (var item in easySet1.Difference(easySet2))
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

                Console.Write("Difference B \\ A: ");
                foreach (var item in easySet2.Difference(easySet1))
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

                Console.Write("A Subset C: ");
                Console.Write(easySet1.SubSet(easySet3));
                Console.WriteLine();

                Console.Write("C Subset A: ");
                Console.Write(easySet3.SubSet(easySet1));
                Console.WriteLine();

                Console.Write("C Subset B: ");
                Console.Write(easySet3.SubSet(easySet2));
                Console.WriteLine();
                
                Console.Write("SymmetricDifference: ");
                foreach (var item in easySet1.SymmetricDifference(easySet2))
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
