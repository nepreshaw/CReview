using System;
using System.Collections.Generic;

namespace CReview {
    class Program {
        static void Main(string[] args) {

            //int sum = 0;
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //foreach(int i in numbers) {
            //    sum += i;
            //    Console.WriteLine(sum);
            //}

            //int price = 1;
            //decimal discountPercent = price > 50 ? .10m : .05m;
            //Console.WriteLine(discountPercent);

            //int[] numbers = new int[10];
            //for(int i = 0; i < numbers.Length; i++) {
            //    Console.WriteLine(i);
            //}

            List<string> names = new List<string>();
            names.Add("qwe");
            names.Add("asd");

            foreach(string name in names) {
                Console.WriteLine(name);
            }
            
        }
    }
}
