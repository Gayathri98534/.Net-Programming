using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    public class TestClass<T>
    {
        // define an Array of Generic type with length 5  
        T[] obj = new T[5];
        int count = 0;
  
        public void Add(T item)
        {
            if (count + 1 < 6)
            {
                obj[count] = item;

            }
            count++;
        }
        public T this[int index]
        {
            get { return obj[index]; }
            set { obj[index] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {  
            TestClass<int> intObj = new TestClass<int>();
  
            intObj.Add(12);
            intObj.Add(13);
            intObj.Add(14);    
            intObj.Add(15);
            intObj.Add(16);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intObj[i]); 
            }
            Console.ReadKey();
        }
    }
}