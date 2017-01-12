using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML101
{
    class GameConfig
    {
        private int poolSize;
        private int sticks;
        public List<int>[] pool;

        public GameConfig(int numberOfSticks)
        {
            sticks = numberOfSticks;
            poolSize = numberOfSticks;
            pool = new List<int>[poolSize];
        }

        public void  AllocatePool()
        {
            for (int position = 0; position < poolSize; position++)
            {
                pool[position] = new List<int>();
                ListFill(position);
            }                      
        }
        private void ListFill(int position)
        {
            pool[position].Add(1);
            pool[position].Add(2);
            pool[position].Add(3);
        }
    }
}
