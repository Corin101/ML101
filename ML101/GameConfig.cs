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
            LegalMove = true;
            PlayerName = name;
        }
        public bool LegalMove { get; }
        public string PlayerName { get; set; }
        public int NumberOfSticks { get; set; }
        public void  AllocatePool()
        {
            for (int position = 0; position < poolSize; position++)
            {
                pool[position] = new List<int>();
                ListFill(position);
            }                      
        }

        public void PlayerTurn(int number)
        {
            if (!CheckIfLegal(number))
                return;
            if (number > NumberOfSticks)
                return;
            NumberOfSticks -= number;

        }

        private bool CheckIfLegal(int number)
        {
            return (number > 0 && number < 4);
        }

        private void ListFill(int position)
        {
            pool[position].Add(1);
            pool[position].Add(2);
            pool[position].Add(3);
        }
    }
}
