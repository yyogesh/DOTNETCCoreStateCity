using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StateCity.Models;

namespace StateCity.Controllers
{
    [Route("api/states")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<StateDto>> GetStates()
        {
            return Ok(StatesDataStore.Current.States);
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<StateDto>> GetCity(int id)
        {
            var stateToReturn = StatesDataStore.Current.States.FirstOrDefault(s => s.Id == id);

            if(stateToReturn == null)
            {
                return NotFound();
            }

            return Ok(stateToReturn);
        }
    }
}
