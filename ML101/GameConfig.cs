using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ML101
{

    public class GameConfig
    {
        public int poolSize;
        public List<int>[] pool;
        private int[] memory;
        private Random randomGenerator;
        public int[] gamescore;

        public GameConfig(int sticks, string name)
        {
            NumberOfSticks = sticks;
            poolSize = sticks;
            pool = new List<int>[poolSize+1];
            PlayerName = name;
            VictoryCondition = null;
            randomGenerator = new Random();
            SticksTaken = 0;
            memory = new int[poolSize+1];
            gamescore = new int[2];
            SetFolderPermission("save");
        }
        public string PlayerName { get; set; }
        public int NumberOfSticks { get; set; }
        public bool? VictoryCondition { get; set; }
        public int SticksTaken { get; set; }

        public void  AllocatePool()
        {
            if (!LoadHardMemory())
            for (int position = 0; position < poolSize+1; position++)
            {
                pool[position] = new List<int>();
                InitialListFill(position);
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
            if (NumberOfSticks == 1)
                SticksTaken = 1;
            else
            {
                int randomNumber = randomGenerator.Next(0, pool[NumberOfSticks].Count);
                SticksTaken = pool[NumberOfSticks].ElementAt(randomNumber);
            }
            memory[NumberOfSticks] = SticksTaken;
            NumberOfSticks -= SticksTaken;
            if (NumberOfSticks == 0)
                VictoryCondition = true;
        }

        public void SaveSoftMemory()
        {
            int i = 0;
            if (VictoryCondition == false)
            {
                foreach (int value in memory)
                {
                    if (value != 0)
                        pool[i].Add(value);
                    i++;
                }
            }
            else
            {
                foreach (int value in memory)
                {
                    int lastIndex;
                    if (value != 0)
                    {
                        lastIndex = pool[i].FindLastIndex(x => x == value);
                        if (lastIndex > 3)
                            pool[i].RemoveAt(lastIndex);
                    }
                    i++;
                }
            }
            NewMemory();
        }
        public void NewMemory()
        {
            memory = new int[poolSize + 1];
        }

        public void SaveHardMemory()
        {
            int i = 0;
            string location = Application.StartupPath;
            FileStream fs;

            if (!File.Exists(location + @"\save\mind.txt"))
            {
                fs = File.Create(location + @"\save\mind.txt");
                fs.Close();
            }

            StreamReader sreader = new StreamReader(location + @"\save\mind.txt");
            StreamWriter swriter = new StreamWriter(location + @"\save\test.txt");

            foreach (List<int> value in pool)
            {
                int j = 1;
                int count = 0;
                if (value != null)
                    count = value.Count;
                try
                {
                    foreach (int number in value)
                    {
                        if (j < count)
                            swriter.Write(number + " ");
                        else
                            swriter.Write(number);
                        j++;
                    }                   
                }
                catch (Exception)
                {
                    swriter.WriteLine("");
                    continue;
                }
                swriter.WriteLine("");       
            }

            while (true)
            {
                sreader.ReadLine();
                if (poolSize == i)
                {
                    swriter.Write(sreader.ReadToEnd());
                    break;
                }
                i++;
            }
            sreader.Close();
            swriter.Close();
            File.Delete(location + @"\save\mind.txt");
            File.Move(location + @"\save\test.txt", location + @"\save\mind.txt");
            File.Delete(location + @"\save\test.txt");
        }

        private bool LoadHardMemory()
        {
            string location = Application.StartupPath;
            string line;
            int[] numbers;
            int i = 0;
            try
            {
                StreamReader sreader  = new StreamReader(location + @"\save\mind.txt");               
                line = sreader.ReadLine();
                while (line != null && i < poolSize + 1)
                {
                    if (line != "")
                    {
                        pool[i] = new List<int>();
                        numbers = line.Split(' ').Select(str => int.Parse(str)).ToArray();
                        foreach (int number in numbers)
                        {
                            pool[i].Add(number);
                        }
                    }
                    i++;
                    line = sreader.ReadLine();
                }
                sreader.Close();
            }
            catch (FileNotFoundException)
            {
                return false;
            }
            return true;
        }

        private void InitialListFill(int position)
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
        public void SetFolderPermission(string folderPath)
        {
            bool exists = System.IO.Directory.Exists(folderPath);
            if (!exists)
            {
                DirectoryInfo di = System.IO.Directory.CreateDirectory(folderPath);
            }
            var directoryInfo = new DirectoryInfo(folderPath);
            var directorySecurity = directoryInfo.GetAccessControl();
            var currentUserIdentity = WindowsIdentity.GetCurrent();
            var fileSystemRule = new FileSystemAccessRule(currentUserIdentity.Name,
                FileSystemRights.FullControl,
                InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit,
                PropagationFlags.None, AccessControlType.Allow);
            directorySecurity.AddAccessRule(fileSystemRule);
            directoryInfo.SetAccessControl(directorySecurity); }
    }
}
