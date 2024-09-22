namespace FrontToBack.DataAccessLayer.Entities
{
    public class Student : Entity
    {
        public string? Name { get; set; }
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
    }
}
