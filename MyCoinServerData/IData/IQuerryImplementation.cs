﻿using MyCoinServerData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCoinServerData.IData
{
    public interface IQuerryImplementation
    {
        string NewUser(Querry querry);

        string ConnectUser(Querry querry);
    }
}
