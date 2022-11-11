using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class  Generic<T>
    {
        private T data;

        public T value
        {
            get { return data; }
            set { data = value; }

        }
        
    }

    internal class Question6
    {
        public void Assignment_Q_6()
        {
            Generic<string> name = new Generic<string>();
            name.value = "This is Generic Example";

            Generic<float> version = new Generic<float>();
            version.value = 5.0f;

            Console.WriteLine(name.value);
            Console.WriteLine(version.value);   
        }

    }
}