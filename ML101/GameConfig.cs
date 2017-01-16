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
        private int[] memory;
        private Random randomGenerator;

        public GameConfig(int sticks, string name)
        {
            NumberOfSticks = sticks;
            poolSize = sticks;
            pool = new List<int>[poolSize+1];
            PlayerName = name;
            VictoryCondition = null;
            randomGenerator = new Random();
            SticksTaken = 0;
            memory = new int[NumberOfSticks+1]; 
        }
        public string PlayerName { get; set; }
        public int NumberOfSticks { get; set; }
        public bool? VictoryCondition { get; set; }
        public int SticksTaken { get; set; }

        public void  AllocatePool()
        {
            for (int position = 0; position < poolSize+1; position++)
            {
                pool[position] = new List<int>();
                ListFill(position);
            }                      
        }

        public void PlayerTurn(int number)
        {
            SticksTaken = number;
            NumberOfSticks -= SticksTaken;
            if (NumberOfSticks == 0)
                VictoryCondition = false;
        }

        public void ComputerTurn()
        {
            int randomNumber = randomGenerator.Next(0,pool[NumberOfSticks].Count );
            if (NumberOfSticks == 1)
                SticksTaken = 1;
            else
            SticksTaken = pool[NumberOfSticks].ElementAt(randomNumber);
            memory[NumberOfSticks] = SticksTaken;
            NumberOfSticks -= SticksTaken;
            if (NumberOfSticks == 0)
                VictoryCondition = true;
        }

        private void ListFill(int position)
        {
            if (position == 0)
                return;
            if (position == 1)
            {
                pool[position].Add(1);
                return;
            }
            if (position == 2)
            {
                pool[position].Add(1);
                pool[position].Add(2);
                return;
            }
            pool[position].Add(1);
            pool[position].Add(2);
            pool[position].Add(3);
        }
    }
}
