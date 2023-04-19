namespace iOrder.Models
    // custom Owner model for Owner page to show for admin!
{
    public class Owner
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public int RestaurantId { get; set; }
    }
}
