using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
namespace explosiveApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ExplosionController : ControllerBase
  {
    [HttpGet]
    public ActionResult FunctionOne(string s)
    {
      var newStr = "";
      char[] charArr = s.ToCharArray(); //ToCharArray splits the string into single chars in charArr
      for (var i = 0; i < charArr.Length; i++)
      {
        var num = int.Parse(charArr[i].ToString()); //intParse can only parse from a string not a char in C#
        newStr += new string(charArr[i], num);
      }
      return Ok(new
      { FunctionOne = newStr });

    }
  }





}