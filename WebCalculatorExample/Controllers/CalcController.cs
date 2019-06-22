using System.Net;
using System.Web.Http;


namespace WebCalculatorExample.Controllers

{
    using WebCalculatorExample.CalculatorManager;

    [RoutePrefix("calc")]

public class CalcController : ApiController
    {
        private readonly ICalcManager _calcManager;

        public CalcController(ICalcManager calcManager)
        {
           _calcManager = calcManager;
        }

        // controllerName/acctionName/number1/number2
        [HttpGet]
        [Route("add/{firstValue}/{secondValue}")]
        public IHttpActionResult Add(int firstValue, int secondValue)
        {
            _calcManager.Addition(firstValue, secondValue);
            return Content(HttpStatusCode.Accepted, "Added");
        }

        // controllerName/actionName/number1?number2=2
        [HttpPost]
        [Route("sub/{firstValue:int}")]
        public IHttpActionResult Substract(int firstValue, int secondValue)
        {
            _calcManager.Substraction(firstValue, secondValue);
            return Content(HttpStatusCode.Accepted, "Substracted");
        }

        // {number1: 2, number2:4}
        [HttpPut]
        [Route("mul")]
        public IHttpActionResult Put(int firstValue, int secondValue)
        {
            _calcManager.Multiplying(firstValue, secondValue);
            return Content(HttpStatusCode.OK, "Multiplyed");

        }

        // <request><Number1 value="3"><Number2 value="3"></request>	
        [HttpDelete]
        [Route("div")]
        public IHttpActionResult Divide(int firstValue, int secondValue)
        {
            _calcManager.Dividing(firstValue, secondValue);
            return Content(HttpStatusCode.Created, "Divided");

        }
    }
}