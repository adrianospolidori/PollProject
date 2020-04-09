using System;
using System.Collections.Generic;

namespace Data.Interfaces
{
    public interface IRepositoryBase<T> where T : Model.BaseModel
    {
        T GetById(long id);
        void Insert(T model);
        void Update(T model);
        void Delete(T model);
        void Delete(long id);
        IList<T> GetWhere(Func<T, bool> where);
        IList<T> GetAll();
        T GetWhereFirst(Func<T, bool> where);
    }
}
