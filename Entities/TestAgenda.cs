using System;

namespace Aula8.Entities {
    public static class TestAgenda {
        public static void Run() {
            Console.WriteLine("Quantas pessoas você deseja cadastrar na agenda?");
            Agenda agenda = new Agenda(int.Parse(Console.ReadLine()));

            Console.WriteLine("Agenda criado com sucesso!");
            Console.WriteLine($"Amigos: {agenda.QuantityOfFriends}");
            Console.WriteLine($"Conhecidos: {agenda.QuantituOfKnowns}");
            Console.ReadKey();

            Console.WriteLine("Vamos começar a cadastrar as informações.");
            agenda.SetInformations();

            agenda.PrintBirths();
            agenda.PrintEmails();

        }
    }
}
