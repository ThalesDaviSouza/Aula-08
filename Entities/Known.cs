namespace Aula8.Entities {
    internal sealed class Known : Person{
        public string? Email { get; private set; }
        
        public Known() : base() {
            Email = null;
        }
        public Known(string name, int age, string email) : base(name, age) {
            Email = email;
        }

        public void setEmail(string email) {
            Email = email;
        }
    }
}
