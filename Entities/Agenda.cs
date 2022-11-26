using System.Collections.Generic;

namespace Aula8.Entities {
    internal sealed class Agenda {
        public Person[] Persons { get; private set; }
        public int QuantityOfFriends { get; private set; }
        public int QuantituOfKnowns { get; private set; }
        const int FriendId = 1;
        const int KnownId = 2;



        public Agenda(int personsInAgenda) {
            Persons = new Person[personsInAgenda];
            Random r = new Random();
            for(int i = 0; i < personsInAgenda; i++) {
                switch(r.Next(1, 3)) {
                    case FriendId:
                        Persons[i] = new Friend();
                        QuantityOfFriends++;
                        break;

                    case KnownId:
                        Persons[i] = new Known();
                        QuantituOfKnowns++;
                        break;
                }
            }
        }


        public void SetInformations() {
            for (int i = 0; i < Persons.Length; i++) {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                if (Persons[i] is Friend) {
                    Console.Write("Birthday: ");
                    string birthday = Console.ReadLine();
                    Persons[i] = new Friend(name, age, birthday);
                }
                else {
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    Persons[i] = new Known(name, age, email);
                }
            }
        }

        public void PrintBirths() {
            Console.WriteLine($"Agenda:");
            Console.WriteLine($"Friends: {QuantityOfFriends}");
            foreach (Person person in Persons) {
                Friend? f = person as Friend;
                if (f != null) {
                    Console.WriteLine($"{f.Name} - {f.Birthday}");
                }
            }
        }
        public void PrintEmails() {
            Console.WriteLine($"Agenda:");
            Console.WriteLine($"Knowns: {QuantituOfKnowns}");
            foreach (Person person in Persons) {
                Known? k = person as Known;
                if (k != null) {
                    Console.WriteLine($"{k.Name} - {k.Email}");
                }
            }
        }

    }
}
