using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    enum Countries
    {
        INDIA=91, AUSTRALIA=61, USA=133, JAPAN=89, FRANCE=21, ENGLAND=46
    }
    internal class Question3
    {
        public void showENum()
        {
            Console.WriteLine("The Country code of India " + "is " + (int)Countries.INDIA);
            Console.WriteLine("The Country code of AUSTRALIA " + "is " + (int)Countries.AUSTRALIA);
            Console.WriteLine("The Country code of USA " + "is " + (int)Countries.USA);
            Console.WriteLine("The Country code of JAPAN " + "is " + (int)Countries.JAPAN);
            Console.WriteLine("The Country code of FRANCE " + "is " + (int)Countries.FRANCE);
            Console.WriteLine("The Country code of ENGLAND " + "is " + (int)Countries.ENGLAND);
        }
    }
}
