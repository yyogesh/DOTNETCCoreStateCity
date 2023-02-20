using StateCity.Models;

namespace StateCity
{
    public class StatesDataStore
    {
        public List<StateDto> States { get; set; }

        public static StatesDataStore Current { get; } = new StatesDataStore();

        public StatesDataStore()
        {
            States = new List<StateDto>()
            {
                 new StateDto()
                {
                    Id = 1,
                    Name = "Haryana",
                    Description = "State of India",
                    Cities = new List<CityDto> {
                      new CityDto{ Id = 101, Name = "Gurgaon", Description = "City of Dronacharya"},
                      new CityDto{ Id = 102, Name = "Faridabad", Description = "City of Industries"}
                    }
                },
                  new StateDto()
                {
                    Id = 2,
                    Name = "Delhi",
                    Description = "Capital of India",
                },
                   new StateDto()
                {
                    Id = 3,
                    Name = "Punjab",
                    Description = "State of India",
                    Cities = new List<CityDto> {
                      new CityDto{ Id = 101, Name = "AmritSar", Description = "City of Punjab"},
                      new CityDto{ Id = 102, Name = "Mohali", Description = "City of Punjab"}
                    }
                }
            };
        }
    }
}
