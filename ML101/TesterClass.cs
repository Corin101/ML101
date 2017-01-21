using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML101
{
    class TesterClass
    {
        static void Main(string[] args)
        {
            GameConfig test = new GameConfig(8, "jura");
            test.AllocatePool();
            test.pool[1].Add(1);
            test.pool[8].Add(2);
            test.SaveHardMemory();
            //test.AllocatePool();
            //test.memory[3] = 3;
            //test.memory[2] = 2;
            //test.memory[4] = 1;
            //test.SaveSoftMemory("blah");
            //test.SaveHardMemory();
            //Console.ReadLine();
        }
    }
}
