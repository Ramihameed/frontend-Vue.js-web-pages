namespace Test_3.Models
{
    public class cars
    {
        // Define the primary key explicitly
        public int Id { get; set; }

        public string name { get; set; }

        public int price { get; set; }

        public ICollection<wheels> Wheels { get; set; }
    }
}