namespace StateCity.Models
{
    public class StateDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int NumberOfCity
        {
            get
            {
                return Cities.Count;
            }
        }

        public ICollection<CityDto> Cities { get; set; }
            = new List<CityDto>();
    }
}
