using System.Collections.Generic;
using Model;

namespace BLL
{
    public interface IBLL
    {
        List<T> GetItems<T>() where T : class;
        int AddOrModifyItem<T>(IModel item) where T : class;
        int DeleteItem<T>(int id) where T : class;
    }
}
