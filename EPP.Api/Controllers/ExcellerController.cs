using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPP.Application.Contracts.Logics;
using Microsoft.AspNetCore.Mvc;

namespace EPP.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExcellerController : Controller
    {
        private readonly IExcellerLogic _excellerLogic;
        public ExcellerController(IExcellerLogic excellerLogic)
        {
            _excellerLogic = excellerLogic;
        }
        [HttpGet]
        [Route("all-excellers")]
        public IActionResult GetExcellers()
        {
            return Ok(_excellerLogic.GetAll());
        }
    }
}