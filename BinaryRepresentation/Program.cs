using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryRepresentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Binary Gap");
            clBinaryRepresentation obj = new clBinaryRepresentation();
            var binary = obj.GetBinary(1376796946);
            Console.WriteLine(binary);
            Console.WriteLine(obj.CalculateGap(binary));
        }

    }
    public class clBinaryRepresentation
    {
        public string GetBinary(int number)
        {
            string binary=Convert.ToString(number,2);
            return binary;
        }
        public int CalculateGap(string binary)
        {
            int counter = 0;
            Char[] values=binary.ToCharArray();
            var gaps = new List<int>();
            for(int i=0;i<values.Length;i++)
            {
                if (values[i] == '1' && (i + 1) < values.Length && binary[i + 1] == '0')
                {
                    counter+=1;
                    i++;
                    while (values.Length > (i + 1) && values[i+1] == '0')
                    {
                        counter += 1;
                        i++;
                        if ((i + 1) < values.Length && values[i + 1] == '1')
                        {
                            break;
                        }
                    }
                    if (values.Length > (i + 1) && values[i + 1] == '1')
                    {
                        gaps.Add(counter);
                        counter = 0;
                    }
                }
            }
            if (gaps.Count == 0)
                return 0;
            else
                return gaps.Max(v => v);
        }
    }
}
