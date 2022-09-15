using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Romak.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ActionController : ControllerBase
    {
        [Route("PublicAction")]
        [HttpPost]
        public IActionResult PublicAction()
        {
            return Ok();
        }

        [Route("PrivateAction")]
        [HttpPost]
        [Authorize(Roles = "role_admin")]
        public IActionResult PrivateAction()
        {
            return Ok();
        }
    }
}
