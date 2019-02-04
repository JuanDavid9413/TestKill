using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCRUDClass.Interfaces
{
    public interface IDataManager
    {
        void InsertUsuario(Models.UserModel oUserModel);
        void DeleteUsuario(Models.UserModel oUserModel);
        void UpdateUsuario(Models.UserModel oUserModel);
    }
}
