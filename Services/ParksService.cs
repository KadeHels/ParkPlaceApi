namespace ParkPlaceApi.Services
{
    public class ParksService : IParksService
    {

        public ParksService() { }

        public IList<Park> GetParks()
        {
            return Enumerable.Range(1, 5).Select(index => new Park
            {
                Name = "Test Park Name",
                Description = "This is a park discription",
                Hours = "9AM - 10PM",
                Location = "123 main st Minneapolis MN"
            })
            .ToArray();
        }
    }
}
