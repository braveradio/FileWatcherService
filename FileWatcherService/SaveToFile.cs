using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcherService
{
    public class SaveToFile : ISaveInfo
    {
        public void Save()
        {
            Console.WriteLine("Save to txt file...");
        }
    }
}
