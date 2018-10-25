using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);

        Console.WriteLine(intList[0]);
        Console.ReadLine();

        intList.Remove(10);

        ////When an array is created, the length of the array MUST be defined.
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //Console.WriteLine(numArray[3]);
        //Console.ReadLine();

        ////Arrays can be created and data input at the time of initialization. 
        ////The length cannot be changed from the initilization length.
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //Console.WriteLine(numArray1[3]);
        //Console.ReadLine();

        ////An EVEN FASTER WAY TO SET ARRAYS
        //int[] numArray2 = { 5, 2, 10, 200, 5000 };

        //Console.WriteLine(numArray2[3]);
        //Console.ReadLine();

        ////exact parts of the array can be targeted and changed
        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();


    }
}
