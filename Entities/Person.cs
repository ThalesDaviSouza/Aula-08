namespace Aula8.Entities {
    internal abstract class Person {
        public string? Name { get; private protected set; }
        public int? Age { get; private protected set; }

        public Person() {
            Name = null;
            Age = null;
        }

        public Person(string name, int age) {
            Name = name;
            Age = age;
        }

        public void setName(string name) {
            Name = name;
        }
        public void setAge(int age) {
            Age = age;
        }
    }
}
