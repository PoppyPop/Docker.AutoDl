using System;
using System.Collections.Generic;
using System.Text;

namespace Docker.AutoDl.Shared.Database
{
    public interface IDatabase
    {
        List<BlackListShow> BlackLists { get; }

        void AddBlackList(BlackListShow blackListShow);

        void RemoveBlackList(BlackListShow blackListShow);

        void ClearBlackList();
    }
}
