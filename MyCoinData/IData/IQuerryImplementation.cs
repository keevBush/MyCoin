using MyCoinData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCoinData.IData
{
    public interface IQuerryImplementation
    {
        string NewUser(Querry querry);

        string ConnectUser(Querry querry);
    }
}
