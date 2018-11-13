using System.Collections.Generic;

namespace Branches
{
    public class LevelCount
    {
        public LevelCount()
        {
            LevelList = new List<int>();
        }
        public int Level { get; set; } = 1;
        public List<int> LevelList;
    }
}