using System;
using System.Collections.Generic;

namespace _2017
{
	public class Day3
	{
		public double CalculateDistance(int dataPoint)
		{
			if (dataPoint == 1)
				return 1;

			var square = 1d;
			do
				square += 2; while (Math.Pow(square, 2) < dataPoint);
			var side = dataPoint / square;

			Console.WriteLine("Square: " + square);
			Console.WriteLine("Modulus: " + side);
			
			return side;
		}


		/*
17 16 15 14 13
18 05 04 03 12
19 06 01 02 11
20 07 08 09_10
21 22 23 24 25
		 
37 36 35 34 33 32 31
38 17 16 15 14 13 30
39 18 05 04 03 12 29
40 19 06 01 02 11 28
41 20 07 08 09_10 27
42 21 22 23 24 25_26
43 44 45 46 47 48 49		 
		 
		  
		  
65 64 63 62 61 60 59 58 57
66 37 36 35 34 33 32 31 56
67 38 17 16 15 14 13 30 55
68 39 18 05 04 03 12 29|54
69 40 19 06 01 02 11|28 53
70 41 20 07 08 09_10 27 52
71 42 21 22 23 24 25_26 51
72 43 44 45 46 47 48 49_50
73 74 75 76 77 78 79 80 81
		 
		    var foo = Math.Sqrt(289326);
		    var i = 0;
		    do
		    {
		        i++;
		    } while ((i * i) < 289326);
		    
		    _output.WriteLine("Corner: " + i.ToString());
		    _output.WriteLine("Sqrt: " + foo.ToString());
		    
		    _output.WriteLine(289326.ToString());
		    _output.WriteLine((538*538).ToString());
   
		 */
	}
}