using App.Application.Service.Interface;
using App.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Movies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IMemberService _memberService;

        public MembersController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        // GET: api/<MembersController>
        [HttpGet]
        public async Task<ActionResult<List<Member>>> GetMembers()
        {
            var list = await _memberService.GetAllMembers();
            return Ok(list);
        }

        [HttpPut]
        public async Task<ActionResult<List<Member>>> CreateMember(Member req)
        {
            var list = await _memberService.CreateMember(req);
            return Ok(list);
        }

    }
}
