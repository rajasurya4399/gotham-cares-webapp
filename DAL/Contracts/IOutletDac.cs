
using GothamCares.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GothamCares.DAL.Contracts
{
    public interface IOutletDac
    {
        Task<List<Outlet>> GetAllOutlets();
    }
}