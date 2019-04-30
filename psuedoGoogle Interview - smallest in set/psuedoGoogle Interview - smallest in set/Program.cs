using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psuedoGoogle_Interview___smallest_in_set
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of values in set: ");
            string numberofvaluess = Console.ReadLine();
            int numberofvalues = Int32.Parse(numberofvaluess);

            ArrayList values = new ArrayList();
            for(int i = 0; i< numberofvalues; i++)
            {
                Console.Write("Enter number: ");
                string vals = Console.ReadLine();
                int val = Int32.Parse(vals);
                values.Add(val);
            }

            Boolean done = false;
            int smallestnum = 0;
            int n = 0; 
            do
            {
                smallestnum = min(values, n);
                Console.WriteLine("nth smallest number for n = {0} is {1}", n+1, smallestnum);
                n++;
                if (n == (values.Count))
                {
                    done = true;
                }
            } while (!done);
            
            Console.ReadLine();
        }

        private static int min(ArrayList values, int n)
        {
           

            for (int i = values.Count - 1; i >= n; i--)
            {

                if((int)values[i] < (int)values[n])
                {
                    int temp = 0;
                    for(int j = 0; j < n; j++)
                    {
                        if((int)values[j] > (int)values[n])
                        {
                            temp = (int)values[j];
                            values[j] = values[i];
                            values[i] = temp;
                            break;
                        }
                    }
                }
                if((int)values[i] == (int)values[n])
                {
                    int temp = 0;
                    int largestnum = (int)values[n] ;
                    int loc = n; 
                    for(int j = 0; j < n; j++)
                    {
                        if((int)values[j] > largestnum)
                        {
                            largestnum = (int)values[j];
                            loc = j;
                        }
                    }
                    temp = (int)values[loc];
                    values[loc] = values[n];
                    values[n] = temp;
                    

                    int smallestnum = (int)values[n];
                    for(int j = n; j < values.Count; j++)
                    { 
                        if((int)values[j] < smallestnum)
                        {
                            temp = (int)values[j];
                            values[j] = values[n];
                            values[n] = temp;
                            smallestnum = temp;
                        }
                    }
                }

            }

            


            return (int)values[n]; 
        }
    }
}
