using GothamCares.DAL;
using GothamCares.DAL.Contracts;
using GothamCares.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GothamCares.BLL
{
    public interface IOutletBLL
    {
        Task<List<Outlet>> GetAllOutlets();
    }

    public class OutletBLL : IOutletBLL
    {
        private readonly IOutletDac dac;

        public OutletBLL(IOutletDac dac)
        {
            this.dac = dac;
        }


        /// <summary>
        /// Gets a list of all outlets
        /// </summary>
        /// <returns>List of outlets</returns>
        public async Task<List<Outlet>> GetAllOutlets()
        {
            var outlets = await dac.GetAllOutlets();
            return outlets;
        }
    }
}