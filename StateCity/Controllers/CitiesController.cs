using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StateCity.Models;

namespace StateCity.Controllers
{
    [Route("api/states/{stateid}/cities")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        /// <summary>
        /// Get All City
        /// </summary>
        /// <param name="stateId"></param>
        /// <returns>IEnumerable<CityDto></returns>
        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities(int stateId)
        {
            var state = StatesDataStore.Current.States.FirstOrDefault(x => x.Id == stateId);
            if(state == null)
            {
                return NotFound();
            }

            return Ok(state.Cities);

        }
        /// <summary>
        /// Get City of State
        /// </summary>
        /// <param name="stateId"></param>
        /// <param name="cityId"></param>
        /// <returns>CityDto</returns>
        [HttpGet("{cityId}")]
        public ActionResult<CityDto> GetCity(int stateId, int cityId)
        {
            var state = StatesDataStore.Current.States.FirstOrDefault(x => x.Id == stateId);
            if (state == null)
            {
                return NotFound();
            }

            // find city of state
            var city = state.Cities.FirstOrDefault(x => x.Id == cityId); 
            
            if(city == null)
            {
                return NotFound();
            }    

            return Ok(city);

        }
    }
}
