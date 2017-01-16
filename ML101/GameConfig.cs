using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML101
{

    public class GameConfig
    {
        private int poolSize;
        public List<int>[] pool;

        public GameConfig(int sticks, string name)
        {
            NumberOfSticks = sticks;
            poolSize = sticks;
            pool = new List<int>[poolSize];
            PlayerName = name;
            VictoryCondition = null;
        }
        public string PlayerName { get; set; }
        public int NumberOfSticks { get; set; }
        public bool? VictoryCondition { get; set; }

        public void  AllocatePool()
        {
            for (int position = 0; position < poolSize; position++)
            {
                pool[position] = new List<int>();
                
            }                      
        }

        public void PlayerTurn(int number)
        {
            NumberOfSticks -= number;
            if (NumberOfSticks == 0)
                VictoryCondition = true;
        }

        private void ListFill(int position)
        {
            pool[position].Add(1);
            pool[position].Add(2);
            pool[position].Add(3);
        }
    }
}
