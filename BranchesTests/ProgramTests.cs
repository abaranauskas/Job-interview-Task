using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Branches.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetDeepestBranchWhenBranchIsNull()
        {   
            //Arrage        
            var levelCount = new LevelCount();
            Branch branch = null;
            //expected NullReferenceException

            //Actual
            Program.GetDeepestBranch(branch, levelCount);            
        }

        [TestMethod()]        
        public void GetDeepestBranchWithoutAnyListOfBranches()
        {
            //Arrage        
            var levelCount = new LevelCount();
            Branch branch = new Branch();
            var expectedLevel = 1;

            //Actual
            var actualLevel = Program.GetDeepestBranch(branch, levelCount).LevelList.Max();

            //Assert
            Assert.AreEqual(expectedLevel, actualLevel);
        }

        [TestMethod()]
        public void GetDeepestBranchWithMoreThanOneLevel()
        {
            //Arrage        
            var levelCount = new LevelCount();
            Branch branch = new Branch()
            {
                #region
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
                #endregion
            };
            var expectedLevel = 4;

            //Actual
            var actualLevel = Program.GetDeepestBranch(branch, levelCount).LevelList.Max();

            //Assert
            Assert.AreEqual(expectedLevel, actualLevel);
        }
    }
}