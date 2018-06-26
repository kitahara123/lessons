using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 2a
            // Дана коллекция List<T>, требуется подсчитать, сколько раз каждый элемент встречается в данной коллекции:
            List<int> l = new List<int>() { 1, 1, 2, 2, 3, 2, 4, 5, 6, 2, 3, 6, 6, 6 };
            HashSet<int> hs = new HashSet<int>(l);
            foreach (int i in hs) Console.WriteLine(i + " встречается " + l.Count(e => e == i) + " раз");
            Console.ReadKey();
            Console.WriteLine();
            #endregion

            #region 2b
            List<Creature> cr = new List<Creature>();
            Random rnd = new Random();

            Creature bd = new Creature("Buddy");
            for (int i = 0; i < rnd.Next(5); i++)
            {
                cr.Add(bd);
            }

            Creature fn = new Creature("Finn");
            for (int i = 0; i < rnd.Next(5); i++)
            {
                cr.Add(fn);
            }

            Creature kv = new Creature("Kevin");
            for (int i = 0; i < rnd.Next(5); i++)
            {
                cr.Add(kv);
            }

            HashSet<Creature> hs1 = new HashSet<Creature>(cr);
            foreach (Creature c in hs1) Console.WriteLine(c + " встречается " + cr.Count(e => e.Equals(c)) + " раз");

            Console.WriteLine();
            cr.ForEach(e => Console.WriteLine(e));

            Console.ReadKey();
            Console.WriteLine();
            #endregion

            #region 3
            Dictionary<string, int> dict = new Dictionary<string, int>(){ {"four",4 }, {"two",2 }, { "one",1 }, {"three",3 } };

            var d = dict.OrderBy(pair => pair.Value);
            foreach (var pair in d)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
            Console.ReadKey();
            #endregion
        }
    }
    class Creature
    {
        public string name;

        public Creature (string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
