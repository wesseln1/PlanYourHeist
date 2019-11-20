using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");
            Console.WriteLine();

            List<Heister> Robbers = new List<Heister>();

            Console.WriteLine("What is the team members name?");
            string name = Console.ReadLine();

            while (name != "")
            {
                Console.WriteLine("What is the team members skill level?");
                string skillLevelString = Console.ReadLine();
                int skillLevel;

                try
                {
                    skillLevel = int.Parse(skillLevelString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{skillLevelString} is not a valid skill level. Using a default value of 10");
                    skillLevel = 10;
                }

                Console.WriteLine("Waht is your team members courage factor?");
                string courageFactorString = Console.ReadLine();
                decimal courageFactor;

                try
                {
                    courageFactor = decimal.Parse(courageFactorString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{courageFactorString} is not a valid courage factor. Using a default value of 1.0");
                    courageFactor = 1.0M;
                }

                Heister member = new Heister();
                member.Name = name;
                member.SkillLevel = skillLevel;
                member.CourageFactor = courageFactor;

                Robbers.Add(member);

                Console.WriteLine();
                Console.WriteLine("New Crew Member");
                name = Console.ReadLine();
            }

            foreach (Heister member in Robbers)
            {
                Console.WriteLine(" <Crew Members> ");
                Console.WriteLine($"Name: {member.Name}");
                Console.WriteLine($"Skill Level: {member.SkillLevel}");
                Console.WriteLine($"Courage Factor: {member.CourageFactor}");
                Console.WriteLine();
            }
        }
    }
}