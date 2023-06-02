using ISimpleCalculatorClassLibrary;
using Microsoft.AspNetCore.Mvc;
using SimpleCalculatorClassLibrary;

namespace CalculatorRESTfulWebService.Controllers
{
    [ApiController]
    [Route("api/addnumbers/{num_1}/{num_2}")]
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

    [Route("api/subnumbers/{num_1}/{num_2}")]
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
