namespace BookSystem.Cores.Model
{
    public class User
    {
        public string Name { get; }
        public int Age { get; }
        public bool IsAdmin { get; }

        public User(string name, int age, bool isAdmin)
        {
            Name = name;
            Age = age;
            IsAdmin = isAdmin;
        }
    }
}
