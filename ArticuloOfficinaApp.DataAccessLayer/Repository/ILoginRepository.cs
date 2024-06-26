using ArticuloOficinaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticuloOfficinaApp.DataAccessLayer.Repository
{
    public interface ILoginRepository<TEntityModel> where TEntityModel : class
    {
        Task<Login> buscarPorEmailPass(string email, string password);
    }
}
