using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_1_ChessBoard.Flyweights
{
    class FlyweightFactory
    {
        private IDictionary<string, Flyweight> flyweights = new Dictionary<string, Flyweight>();

        public FlyweightFactory(params Flyweight[] args)
        {
            foreach (var elem in args)
            {
                flyweights.Add(GetKey(elem), elem);
            }
        }

        // Возвращает хеш строки Легковеса для данного состояния.
        public string GetKey(Flyweight key)
        {
            return key.Color.ToString();
        }

        // Возвращает существующий Легковес с заданным состоянием или создает
        // новый.
        public Flyweight GetFlyweight(Flyweight sharedState)
        {
            string key = this.GetKey(sharedState);

            if (!flyweights.ContainsKey(key))
            {
                this.flyweights.Add(key, sharedState);
            }
            return flyweights[key];
        }

    }
}
