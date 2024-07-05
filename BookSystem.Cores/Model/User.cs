namespace BookSystem.Cores.Model
{
    public class User
    {
        public string Name { get; }
        public int Age { get; }
        public bool IsAdmin { get; }
        public bool IsRestriction { get; set; }

        public User(string name, int age, bool isAdmin, bool isRestriction)
        {
            Name = name;
            Age = age;
            IsAdmin = isAdmin;
            IsRestriction = isRestriction;
        }
    }
}