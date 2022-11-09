using CMSWebApi.Models;
using CMSWebApi.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMSWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyCors")]
    public class MemberPlanController : ControllerBase
    {
        private readonly IRepo<int, MemberPlan> _repo;

        public MemberPlanController(IRepo<int, MemberPlan> repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public ActionResult AddMemberPlan(MemberPlan memberplan)
        {
            var result = _repo.Add(memberplan);
            if (result != null)
                return Ok(result);
            return BadRequest("Invalid username or password");
        }
    }
}