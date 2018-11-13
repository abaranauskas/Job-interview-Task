using System;
using System.Collections.Generic;
using System.Linq;

namespace Branches
{
    public class Program
    {
        static void Main(string[] args)
        { 


            var branch = new Branch()
            {
                #region
                branches = new List<Branch>
                {


                    new Branch()
                    {
                        branches = new List<Branch>
                        {
                            new Branch()
                        }
                    },


                    new Branch()
                    {
                        branches = new List<Branch>
                        {
                             new Branch()
                            {
                                branches = new List<Branch>
                                {

                                    new Branch(),

                                    new Branch()
                                    {
                                        branches = new List<Branch>
                                        {
                                            new Branch()
                                        }
                                    }
                                }
                            },
                            new Branch(),


                            new Branch()
                            {
                                branches = new List<Branch>
                                {
                                    new Branch()
                                }
                            }                           
                        }
                    }
                }
                #endregion
            };

            //Branch branch2 = null;


            var levelCount = new LevelCount();
            LevelCount levels;

            try
            {
                levels = GetDeepestBranch(branch, levelCount);

                //foreach (var item in levels.LevelList)
                //{
                //    Console.WriteLine(item);
                //}

                Console.WriteLine($"Deepest level: {levels.LevelList.Max()}");
            }
            catch (NullReferenceException ex)
            {

                Console.WriteLine($"Branch {ex.Message}");
            }  
        }

        public static LevelCount GetDeepestBranch(Branch branch, LevelCount levelCount)
        {
            if (branch.branches!=null)
            {
                levelCount.Level++;
                foreach (var b in branch.branches)
                {
                    GetDeepestBranch(b, levelCount);
                }
                levelCount.Level--;
            }
            else
            {
                levelCount.LevelList.Add(levelCount.Level);
            }
            return levelCount;
        }        
    }
}
