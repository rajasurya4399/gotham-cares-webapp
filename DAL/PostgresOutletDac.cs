
using GothamCares.DAL.Contracts;
using GothamCares.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GothamCares.DAL
{
    public class PostgresOutletDac : IOutletDac
    {
        public async Task<List<Outlet>> GetAllOutlets()
        {
            // change this to get from DB using EF.

            List<Outlet> outlets = new List<Outlet>()
            {
                new Outlet{Id="1", Name="Surya"},
                new Outlet{Id="2", Name="Nikitha"},
                new Outlet{Id="3", Name="Maju"}
            };

            return await Task.FromResult(outlets);
        }
    }

    public class MongoOutletDac : IOutletDac
    {
        public async Task<List<Outlet>> GetAllOutlets()
        {
            // change this to get from DB using EF.

            List<Outlet> outlets = new List<Outlet>()
            {
                new Outlet{Id="1", Name="Surya"},
                new Outlet{Id="2", Name="Nikitha"},
                new Outlet{Id="3", Name="Maju"}
            };

            return await Task.FromResult(outlets);
        }
    }


}