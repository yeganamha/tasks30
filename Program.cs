using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ConsoleApp1123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Task1---------");
            List<int> Numberlist = new List<int>() { 45, 89, 20, 14, 52, 36, 47, 89 };
            SelectMethod(Numberlist);
            Console.WriteLine("-------Task2--------");
            List<int> list = new List<int> { 45, 10, 26, 8, 7, 2, 0, 9, 78 };
            Mymethod(list);
            Console.WriteLine("----------Task3---------");
            List<int> Squarelist = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            SquaremMethod(Squarelist);
            Console.WriteLine("------------Task4-------------");
            int[] arr = new int[] { 5, 5, 8, 9, 1, 6, 7, 5, 2, 1, 6, 9 };
            FrequencyMethod(arr);

            Console.WriteLine("--------Task6-------");
            List<string> DaysOfWeek = new List<string>() { "Sun", "Mon", "Tue", "Wen", "Thu", "Fri", "Sat" };
            DaysWeekMethod(DaysOfWeek);
            Console.WriteLine("-----------Task-8--------");
            List<string> CityList = new List<string>() { "AMSTERDAM", "AZERBAIJAN", "AHDYEEBDM" };
            CityMethod(CityList);
            Console.WriteLine("-------Task-9--------");
            List<int> ints = new List<int>() { 55, 200, 740, 76, 230, 482, 95, 80 };
            Greaterthan80Method(ints);
            Console.WriteLine("--------Task-17-----------");
            List<string> CharList = new List<string>() { "d", "e", "q", "r" };
            CharList.Remove("q");
            foreach (var item in CharList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------Task20--------");
            List<string> CharList1 = new List<string>() { "d", "e", "q", "r" };
            CharList1.RemoveAt(0);
            var res = CharList1.ToList();
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------Task21--------");
            List<string> CharList2 = new List<string>() { "d", "e", "q", "r" };
            CharList2.RemoveRange(1, 3);
            var res1 = CharList2.ToList();
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------Task30--------");
            List<string> CharList3 = new List<string>() { "bisciut", "apple", "honey", "blue" };
            CharList3.Distinct().OrderBy(x => x).ToList();

            var res3 = CharList3.ToList();
            foreach (var item in res3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(  "-----------------------");
            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };
            var result = cities.OrderBy(x=> x.Length).ThenBy(x=>x.Length).ToList();
            foreach(var item in result) 
            {
                Console.WriteLine(  item);
            }

            static void Greaterthan80Method(List<int> list) //9
            {
                var result = list.Where(x => x > 80).ToList();
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            static void CityMethod(List<string> list) //8
            {
                var result = list.Where(x => x.StartsWith("A") && x.EndsWith("M")).ToList();
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            static void SelectMethod(List<int> list) //1
            {
                var result = list.Where(x => x % 2 == 0).ToList();
                foreach (var numbers in result)
                {
                    Console.WriteLine(numbers);
                }

            }
            static void Mymethod(List<int> list) //2
            {
                var result = list.Where(x => x >= 0 && x <= 11);

                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }

            static void SquaremMethod(List<int> mylist) //3
            {
                foreach (int i in mylist)
                {
                    var result = i * i;
                    mylist.ToList();
                    Console.WriteLine("Number:  " + i + "SqrNo:  " + result);
                }
            }
            static void DaysWeekMethod(List<string> list) //6
            {
                var weekdays = list.OrderBy(x => x).ToList();
                foreach (var days in weekdays)
                {
                    Console.WriteLine(days);
                }
            }
            static void FrequencyMethod(int[] arr) //4
            {
                var n = from x in arr
                        group x by x into y
                        select y;
                foreach (var arrNo in arr)
                {
                    Console.WriteLine("number" + arrNo + "appears  ");
                }
            }
        }

    }   }
    
        
 
 

    
    
