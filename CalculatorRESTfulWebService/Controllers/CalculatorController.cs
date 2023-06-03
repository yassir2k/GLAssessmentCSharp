using ISimpleCalculatorClassLibrary;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SimpleCalculatorClassLibrary;

namespace CalculatorRESTfulWebService.Controllers
{
    [ApiController]
    //This here begins the implementation of the Webservice that handles addition
    [Route("api/addnumbers/{num_1}/{num_2}")] //Service resource link templating
    public class AddController : Controller
    {
        [HttpGet(Name = "AddNumbers")]
        public int AddTwoNumbers(int num_1, int num_2)
        {
            ImplementISimpleCalculator s = new ImplementISimpleCalculator();
            int sum = s.Add(num_1, num_2);
            return sum;
        }
    }

    //This here begins the implementation of the Webservice that handles subtraction
    [Route("api/subnumbers/{num_1}/{num_2}")] //Service resource link templating
    public class SubController : Controller
    {
        [HttpGet(Name = "SubNumbers")]
        public int SubTwoNumbers(int num_1, int num_2)
        {
            ImplementISimpleCalculator s = new ImplementISimpleCalculator();
            int sum = s.Subtract(num_1, num_2);
            return sum;
        }
    }
}
