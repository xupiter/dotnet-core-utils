﻿using System;
using System.Collections.Generic;

namespace Benday.EfCore.SqlServer
{
    public interface IRepository<T> where T : IInt32Identity
    {
        IList<T> GetAll();
        IList<T> GetAll(int maxNumberOfRows);
        T GetById(int id);
        void Save(T saveThis);
        void Delete(T deleteThis);
    }
}
