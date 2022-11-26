namespace Aula8.Entities {
    internal sealed class Friend : Person{
        public string? Birthday { get; private set; }
        
        public Friend() : base() {
            Birthday = null;
        }

        public Friend(string name, int age, string birthday) : base(name, age) {
            Birthday = birthday;
        }

        public void setBirthday(string birthday) {
            Birthday = birthday;
        }
    }
}
