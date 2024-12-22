using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 1, 2, 3, 5, 8, 13, 21 };
            
            string[] array2 = { "January", "February", "March", 
                                "April", "May", "June", "July", "August", 
                                "September", "October", "November", "December", };
            
            int[][] array3 = new int[3][] {
                             new int[3] { 2, 3, 4 },
                             new int[3] { 4, 9, 16 },
                             new int[3] { 8, 27, 64 } };

            double[][] array4 = new double[3][];
            array4[0] = new double[5] { 1, 2, 3, 4, 5};
            array4[1] = new double[2] { Math.E, Math.PI};
            array4[2] = new double[4] { Math.Log10(1), Math.Log10(10), 
                                        Math.Log10(100), Math.Log10(1000)};

            int[] array5 = { 1, 2, 3, 4, 5 };
            int[] array6 = { 7, 8, 9, 10, 11, 12, 13 };
            var result = Array.Copy(array5, array6, 3);


            Array.Resize(ref array5, 10);









        }




    
    
    
    
    }
}

