﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyCoinServerData.IData
{
    public interface IDataStore<T> where T:class
    {
        void NewItem(T item);

        List<T> AllItems();

        void UpdateItem(T item);

        void DeleteItem(T item);
    }
}
