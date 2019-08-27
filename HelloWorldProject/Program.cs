using System;

namespace HelloWorldProject {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("At MAX Techinical Training");
            Console.WriteLine("Hello C# Boot Camp World!");
            int daysInBootcamp = 6;
            if (daysInBootcamp == 6) {
                Console.WriteLine("Yes");
            }
            else {
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
            foreach (var score in scores) {
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
           // Console.WriteLine(grandTotal);

            //floating point numbers
            var distances = new double[]{5.99, 3.56, 8.99, 7.47, 8.17, 6.78, 6.33};
           var tot = 0.00;
            foreach(var distance in distances) {
                tot += distance;
            }
                Console.WriteLine(tot/distances.Length);

            //arrays
            int[] students = new int[5];
            students[0] = 7;
            students[1] = 3;
            students[2] = 4;
            students[3] = 15;
            students[4] = 5;

            string[] names = new string[7];
            names[0] = "Jeremy";
            names[1] = "Alex";
        }

    }
}
