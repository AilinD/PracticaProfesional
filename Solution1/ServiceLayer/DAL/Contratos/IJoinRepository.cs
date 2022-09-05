﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DAL.Contratos
{
    internal interface IJoinRepository<T>
    {
        void Delete(T obj);

        void GetChildren(T obj);

        void Add(T obj);

    }
}
