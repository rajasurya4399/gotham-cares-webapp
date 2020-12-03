using GothamCares.BLL;
using GothamCares.DAL;
using entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GothamCares.Entity;

namespace GothamCares.Web.Controllers
{
    [ApiController]
    public class OutletsControler : ControllerBase
    {
        readonly IOutletBLL bll;

        public OutletsControler(IOutletBLL outletBLL)
        {
            bll = outletBLL;
        }

        [HttpGet]
        [Route("api/outlets")]
        public async Task<IActionResult> GetOutlets()
        {
            var outlets = await bll.GetAllOutlets();

            return Ok(outlets);
        }

        [HttpPost]
        [Route("api/outlets")]
        public IActionResult CreateOutlet([FromBody] Outlet outlet)
        {
            return Ok();
        }

    }
}