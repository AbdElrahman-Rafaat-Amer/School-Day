using LMS.Models.AccountModel;
using LMS.Models.FeesModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FeesController : BaseController
    {
        private readonly IFeesRepasitory<Fees> FeesRepasitory;

        public FeesController(IFeesRepasitory<Fees> feesRepasitory)
        {
            FeesRepasitory = feesRepasitory;
        }
        [HttpGet]
        [Authorize(Role.Parent, Role.Admin, Role.Student)]
        public ActionResult<IEnumerable<Fees>> Feeses()
        {
            var Fees = FeesRepasitory.Feeses();
            return Ok(Fees);
        }

        [HttpGet("{id}")]
        [Authorize(Role.Parent, Role.Admin, Role.Student)]
        public async Task<ActionResult<Fees>> Fees(int id)
        {
            var Fees = await FeesRepasitory.Fees(id);
            return Ok(Fees);
        }

        [HttpPost]
        [Authorize(Role.Admin)]
        public ActionResult Post(Fees model)
        {
            model.Account = Account;
            FeesRepasitory.CreateFees(model);
            return Ok();
        }

        [HttpPut("{id}")]
        [Authorize(Role.Admin)]
        public ActionResult Put(int id,Fees model)
        {
            if (id == model.Id)
            {
                FeesRepasitory.UpdateFees(model);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        [Authorize(Role.Admin)]
        public ActionResult Delete(int id)
        {
            if(FeesRepasitory.Fees(id) == null)
            {
                return BadRequest();
            }
            FeesRepasitory.DeleteFees(id);
            return Ok();
        }
    }
}
