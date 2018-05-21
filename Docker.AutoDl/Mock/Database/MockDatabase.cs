using System;
using System.Collections.Generic;
using System.Text;
using Docker.AutoDl.Shared.Database;

namespace Docker.AutoDl.Mock.Database
{
    public class MockDatabase : IDatabase
    {
        public List<BlackListShow> BlackLists { get; set; }

        public MockDatabase()
        {
            BlackLists = new List<BlackListShow>();
        }

        public void AddBlackList(BlackListShow blackListShow)
        {
            BlackLists.Add(blackListShow);
        }

        public void RemoveBlackList(BlackListShow blackListShow)
        {
            BlackLists.Remove(blackListShow);
        }

        public void ClearBlackList()
        {
            BlackLists.Clear();
        }
    }
}
