using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using konsola;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public void help_method(Problem p)
        {
            p.generateSeedValues();
            p.items.Sort(delegate (Item x, Item y)
            {
                return (y.w * y.val).CompareTo(x.w * x.val);
            });
            p.solveProblem();
        }
        [TestMethod]
        public void test_many_seed_values_for_empty_capacity()
        {
            for (int seed = 0; seed < 100; seed++)
            {
                Problem p = new Problem(12, seed, 0);
                help_method(p);
                Assert.AreEqual(12, p.items.Count);
                Assert.AreEqual(0, p.plecak.Count);
            }
        }

        [TestMethod]
        public void test_string_repr_of_item()
        {
            Item p = new Item(1, 12, 12);
            Assert.AreEqual("1-> Value: 12 | Weight: 12 | v*w: 144", p.ToString());
        }

        [TestMethod]
        public void test_backpack_not_empty()
        {
            for (int seed = 0; seed < 100; seed++)
            {
                Problem p = new Problem(12, seed, 100);
                help_method(p);
                Assert.AreNotEqual(0, p.plecak.Count);
            }
        }

        [TestMethod]
        public void test_all_items_in_backpack()
        {
            for (int seed = 0; seed < 100; seed++)
            {
                Problem p = new Problem(4, seed, 100);
                help_method(p);
                Assert.AreEqual(4, p.plecak.Count);
            }
        }

        [TestMethod]
        public void test_string_repr_of_problem()
        {
            Problem p = new Problem(4, 12, 10);
            help_method(p);
            string s = "";
            foreach (Item item in p.items)
            {
                s += item.ToString();
                s += "\r\n";
            }
            Assert.AreEqual(s, p.ToString());
        }

        [TestMethod]
        public void test_algorithm_doesnt_cheat()
        {
            Problem p = new Problem(100, 12, 200);
            help_method(p);
            foreach(Item item in p.items)
            {
                if(!(p.plecak.Contains(item)))
                {
                    Assert.IsTrue(p.c < item.w);
                }
            }
        }
    }
}
