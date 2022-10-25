using Microsoft.AspNetCore.Mvc;

namespace day2ApiInput.Controllers;

[ApiController]
[Route("[controller]")]
public class InputController : ControllerBase
{
    [HttpGet]
    [Route("Hello/{name}")]
    //localHost9000/Input/Name
    public string SayHello(string name)
    {
        return$"Whats up {name}!";
    }

    [HttpGet]
    [Route("Adding/{number1}/{number2}")]
    public int Math(string number1, string number2 )
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 =  Convert.ToInt32(number2);
        return convertNum1 + convertNum2;
    }
    
    //return$"This would be my return {var} "



}