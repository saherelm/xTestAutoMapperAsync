using Microsoft.AspNetCore.Mvc;
using xTestAutoMapper.Interfaces;
using xTestAutoMapper.Models.Dtos;
using xTestAutoMapper.Models.Entities;

namespace xTestAutoMapper.Controllers
{
    [Route("")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        //
        private readonly ITestService testService;

        //
        #region Constructor ...
        public TestsController(
            ITestService testService
        )
        {
            this.testService = testService;
        }
        #endregion

        //
        #region Actions ...
        [HttpGet("")]
        public ActionResult<string> Hi()
        {
            //
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var result = $"Action: {actionName} Called from Controller: {controllerName} successfully.";
            return Ok(result);
        }

        [HttpGet("/GetPerson")]
        public ActionResult<Person> GetPerson()
        {
            //
            var result = testService.GeneratePerson();

            //
            return Ok(result);
        }

        [HttpGet("/GetPersonDto")]
        public ActionResult<PersonDto> GetPersonDto()
        {
            //
            var result = testService.GeneratePersonDto();

            //
            return Ok(result);
        }

        [HttpGet("/MapPerson")]
        public ActionResult<PersonDto> MapPerson()
        {
            //
            var person = testService.GeneratePerson();
            var result = testService.ToPersonDto(person);

            //
            return Ok(result);
        }

        [HttpGet("/MapPersonDto")]
        public ActionResult<Person> MapPersonDto()
        {
            //
            var personDto = testService.GeneratePersonDto();
            var result = testService.ToPerson(personDto);

            //
            return Ok(result);
        }        
        #endregion
    }
}