﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRh_BLL.Interfaces
{
    public interface IGlobalInterfaces<TKey , TEntity>
    {
        TEntity Get(TKey id);
        IEnumerable<TEntity> GetAll();
        TKey Insert(TEntity entity);
        bool Update(TEntity data);
        bool Delete(TEntity entity);
    }
}
