namespace user_info_mvc.Models
{
    public class Details
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Details()
        {
            Name = "Yuki";
            Surname = "H.";
        }

        public Details(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}