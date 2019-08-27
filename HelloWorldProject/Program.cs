using System;

namespace HelloWorldProject {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("At MAX Techinical Training");
            Console.WriteLine("Hello C# Boot Camp World!");
            int daysInBootcamp = 6;
            if (daysInBootcamp == 6) {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            string Instructor = "";
            Instructor = "Greg";
            Console.WriteLine(Instructor);
            string LastName = "Doud";
            Console.WriteLine(Instructor + " " + LastName);

            //looping with while
             var ints = new int[] { 1, 2, 3, 4, 5 };
             var total = 0;
             var index = 0;
            while (index < 5) {
                total = total + (ints[index] * ints[index]);
                index = index + 1;
            }
            //looping with for
               total = 0;
            for (var idx = 0; idx < 5; idx = idx + 1) {

                total = total + (ints[idx] * ints[idx]);

            }
            Console.WriteLine("Total is " + total);
            //assignment compute the avg
            var scores = new int[] { 738, 609, 307, 959, 805, 689, 402, 972, 359, 140 };
            //looping with for each
            var grandTotal = 0;
            foreach(var score in scores) {
                grandTotal += score;
            }

            /*var avg = 0;
            var nbrs = 0; 
            while (nbrs < scores.Length) {
                avg = avg + (scores[nbrs]);
                nbrs ++;
            */


            // }
            //Console.WriteLine("avg is " + avg/scores.Length);
            Console.WriteLine(grandTotal);
        }
    }
}
