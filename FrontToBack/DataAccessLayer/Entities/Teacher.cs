namespace FrontToBack.DataAccessLayer.Entities
{
    public class Teacher : Entity
    {
        public string? Name { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
