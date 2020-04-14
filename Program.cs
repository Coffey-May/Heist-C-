using System;
using System.Collections.Generic;

namespace HeistV2
{
    class Program
    {
        static void Main(string[] args)
        {

            Bank bank1 = new Bank(12, 32, 49, 22);
            Bank bank2 = new Bank(2, 3, 4, 2);

            Hacker hacker1 = new Hacker("Coffey", 50, 50);
            Hacker hacker3 = new Hacker("Me", 50, 50);
            Hacker hacker4 = new Hacker("You", 1, 1);
            Hacker hacker2 = new Hacker("Yo Mama too.", 1, 1);

            // List<HackerList> hackers = new List<HackerList> ();

            Muscle muscle1 = new Muscle("Obama", 25, 44);
            Muscle muscle2 = new Muscle("Putin", 20, 22);
            Muscle muscle3 = new Muscle("jesus", 2, 34);
            Muscle muscle4 = new Muscle("santa", 50, 49);

            LockSpecialist LS1 = new LockSpecialist("Mr pink", 33, 40);
            LockSpecialist LS2 = new LockSpecialist("Mr yello", 3, 4);
            LockSpecialist LS3 = new LockSpecialist("Mr green", 44, 44);
            LockSpecialist LS4 = new LockSpecialist("Mr blue", 13, 14);

            List<IRobber> crew = new List<IRobber>();

            crew.Add(hacker1);
            crew.Add(muscle1);
            crew.Add(LS1);
            crew.Add(muscle2);
            crew.Add(LS4);

            Console.WriteLine($"Your bank heist crew has {crew.Count} crew members.");
            Console.WriteLine("Enter the name of your new Bank heist crew member.");
            // while (true)
            // {
            var newCrewMemberName = Console.ReadLine();
            // if (string.IsNullOrEmpty(newCrewMemberName))
            // {
            //     break;
            // }
            // else
            // {
            Console.WriteLine($"You chose the name: {newCrewMemberName}");
            Console.WriteLine("choose which specialty your new crew member has \n Hacker\n Muscle\n Lock Specialist");
            Console.WriteLine("Enter choice here");
            var newCrewMemberSpecialty = Console.ReadLine();



            if (newCrewMemberSpecialty.ToLower() == "hacker")
            {
                Console.WriteLine("Enter skill level here, between 1-100:");
                var newCrewMemberSkillLevel = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter cut of the loot that your new crew member demands 0% - 100%");
                var newPercentageCut = int.Parse(Console.ReadLine());

                Hacker newCrewMember = new Hacker(newCrewMemberName, newCrewMemberSkillLevel, newPercentageCut);
                crew.Add(newCrewMember);
            }
            else if (newCrewMemberSpecialty.ToLower() == "muscle")
            {
                Console.WriteLine("Enter skill level here, between 1-100:");
                var newCrewMemberSkillLevel = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter cut of the loot that your new crew member demands 0% - 100%");
                var newPercentageCut = int.Parse(Console.ReadLine());

                Muscle newCrewMember = new Muscle(newCrewMemberName, newCrewMemberSkillLevel, newPercentageCut);
                crew.Add(newCrewMember);
            }
            else if (newCrewMemberSpecialty.ToLower() == "lock specialist")
            {
                Console.WriteLine("Enter skill level here, between 1-100:");
                var newCrewMemberSkillLevel = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter cut of the loot that your new crew member demands 0% - 100%");
                var newPercentageCut = int.Parse(Console.ReadLine());

                LockSpecialist newCrewMember = new LockSpecialist(newCrewMemberName, newCrewMemberSkillLevel, newPercentageCut);
                crew.Add(newCrewMember);
                //     }

                // }
            }
            // hacker2.PerformSkill (bank1);
        }
    }
}