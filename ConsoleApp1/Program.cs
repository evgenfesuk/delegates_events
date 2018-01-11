using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ClassCounter Counter = new ClassCounter();
             Handler_I Handler1 = new Handler_I();
             Handler_II Handler2 = new Handler_II();

             //Подписались на событие
             Counter.onCount += Handler1.Message;
             Counter.onCount += Handler2.Message;

             Counter.Count();*/

            TestClass t = new TestClass();

            var result = t.Select(s => s.ToString()).Where(s=>s.Length < 2).Select(s=>"0"+s);
            foreach(var r in result)
            {
                Console.WriteLine(r);
            }

            ArrayList l = new ArrayList() { "boy", "girl", "lesby", "gey" };
            var res = l.Cast<string>().OrderBy(s => s).Select(s => s);
            foreach (var r in res) Console.WriteLine(r);

            var r1 = t.Select(s=>s);
            foreach (var r in r1)
            {
                string temp;
                temp = r.ToString().Length < 2 ? '0' + r.ToString() : r.ToString();
            }

            var r2 = t.Select(s => s.ToString()).Concat(res);
            foreach (var r in r2)
            {
                Console.WriteLine(r);
            }
            Console.ReadKey();
        }
    }

    class TestClass : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            for (int i=1; i<=100; i++)
            {
                yield return i;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class ClassCounter  //Это класс - в котором производится счет.
    {
        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 71) onCount();
            }
        }

        public delegate void MethodContainer();

        public event MethodContainer onCount;
    }

    class Handler_I //Это класс, реагирующий на событие (счет равен 71) записью строки в консоли.
    {
        public void Message()
        {
            //Не забудьте using System 
            //для вывода в консольном приложении
            Console.WriteLine("Пора действовать, ведь уже 71!");
        }
    }

    class Handler_II
    {
        public void Message()
        {
            Console.WriteLine("Точно, уже 71!");
        }
    }
}
