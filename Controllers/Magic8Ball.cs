//Isaiah Keith Ferguson
//10/27/2022
//Magic 8 Ball
//The user will input a question and the magic 8 ball will output an fortune
//Reviewed by: Christopher Prado, the program runs very swell. I input a question and it outputs a proper response. It was also very creative & the code is effective.

using Microsoft.AspNetCore.Mvc;

namespace FergusonIMagic8BallEndPoints.Controllers;

[ApiController]
[Route("[controller]")]
public class Magic8BallController : ControllerBase
{
    [HttpGet]
    [Route("Magic/{question}")]

    public string Magic8Ball(string question)
    {

        int num = 0;
        Random randnum = new Random();
        num = randnum.Next(0, 9);
        string[] Magic8Ball = { "Doesn't look good", "Yes", "No", "We'll see", "Not likely", "More than likely", "Just give up", "Looking good", "Outlook undeterminded" };

        return $"{question} \nThe Magic 8 Ball says '{Magic8Ball[num]}'";
    }
}