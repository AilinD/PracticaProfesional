﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DAL.Implementaciones
{
   
      public class DALException : Exception
        {

          public DALException(Exception ex) : base("DAL Exception", ex)
            {

            }
        }
    
}
