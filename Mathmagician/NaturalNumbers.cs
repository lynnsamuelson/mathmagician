using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class NaturalNumbers //must be public for  the tests to recognize the class in the test file
    {
        protected int first; //set to zero by default unless given a value
        //protected gives access to children
        protected int increment;

        public NaturalNumbers()
        {
            first = 1;
            increment = 1;
        }

        public virtual int GetNext(int x)
        {
            return x+increment;
        }

   
        public int GetFirst()
        {
            return first;
        }

        public int[] GetSequence()//to overload means to provide a similar sequence
                                  //easiest way to overload a method is to change the arguements
        {
            return GetSequence(10);
        }
                    
        public int[] GetSequence(int length)
        {
            //int[] output = new int[length];
            List<int> output = new List<int>();
            output.Add(GetFirst());
            while (output.Count < length)
            {
                output.Add(GetNext(output.Last()));
            }
            return output.ToArray();
        }

        public string ToString(int[] array)
        {
            string output = String.Join(" ", array);
            return output;

           /* for (int i = 0; i < array.Length; i++)
            {
                /* if (array[i] == array.Last())
                 {
                     output += array[i].ToString();
                 } else
                 {
                 output += array[i].ToString() + " ";
                 }
                 then return output;
                
                //output += array[i].ToString() + " "; 
                //the return output.TrimEnd();
            }*/
        }
           

        }     
        
        }
  

