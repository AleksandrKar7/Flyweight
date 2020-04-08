using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_1_ChessBoard.Flyweights
{
    class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

        public FlyweightFactory(params Cell[] args)
        {
            foreach (var elem in args)
            {
                flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), this.GetKey(elem)));
            }
        }

        // Возвращает хеш строки Легковеса для данного состояния.
        public string GetKey(Cell key)
        {
            return key.Color.ToString();
        }

        // Возвращает существующий Легковес с заданным состоянием или создает
        // новый.
        public Flyweight GetFlyweight(Cell sharedState)
        {
            string key = this.GetKey(sharedState);

            if (flyweights.Where(t => t.Item2 == key).Count() == 0)
            {
                //Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                this.flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
            }
            else
            {
                //Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }
            return this.flyweights.Where(t => t.Item2 == key).FirstOrDefault().Item1;
        }

        //public void listFlyweights()
        //{
        //    var count = flyweights.Count;
        //    //Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
        //    foreach (var flyweight in flyweights)
        //    {
        //        Console.WriteLine(flyweight.Item2);
        //    }
        //}
    }
}
