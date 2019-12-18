using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
namespace explosiveApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class MumblingController : ControllerBase
  {
    [HttpGet]
    public ActionResult FunctionTwo(string s)
    {
      var newStr = "";
      char[] charArray = s.ToCharArray();
      for (var i = 0; i < charArray.Length; i++)
      {
        newStr += (i > 0 ? "-" : "") + Char.ToUpper(charArray[i]) + new string(Char.ToLower(charArray[i]), i);
      }
      return Ok(new { FunctionTwo = newStr });
    }
  }





}