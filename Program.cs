using System;
using System.Collections.Generic;
using System.Linq;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");
            Console.WriteLine();
            Console.WriteLine("Base Difficulty of Bank>");
            int bankDifficulty = int.Parse(Console.ReadLine());
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
                catch (Exception)
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
                catch (Exception)
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
            Console.WriteLine($"{Robbers.Count} Crew Member's total!");
            Console.WriteLine();

            Console.WriteLine("How many times would you like to run this?");
            int numberOfRuns = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int teamSkill = 0;
            foreach (Heister member in Robbers)
            {
                teamSkill += member.SkillLevel;
            }

            Report heistReport = new Report();

            for (int i = 0; i < numberOfRuns; i++)
            {
                Random luckRating = new Random();
                bankDifficulty += luckRating.Next(-10, 11);

                Console.WriteLine();
                Console.WriteLine($"Team Skill> {teamSkill}");
                Console.WriteLine($"Bank Skill> {bankDifficulty}");
                Console.WriteLine();

                if (teamSkill >= bankDifficulty)
                {
                    Console.WriteLine("Atta Boy!");
                    heistReport.SuccessCount++;
                }
                else
                {
                    Console.WriteLine("Going to jail now Boy!");
                    heistReport.FailureCount++;
                }
            }

            heistReport.ShowReport();

            // Console.WriteLine(" <Crew Members> ");
            // Console.WriteLine();
            // foreach (Heister member in Robbers)
            // {
            //     Console.WriteLine($"{member.Name}");
            //     Console.WriteLine($"Skill Level: {member.SkillLevel}");
            //     Console.WriteLine($"Courage Factor: {member.CourageFactor}");
            //     Console.WriteLine();
            // }

            //First way i did it, but cleaned it up

            // List<int> robbersSkillLevels = new List<int>();
            // foreach (var robber in Robbers)
            // {
            //     robbersSkillLevels.Add(robber.SkillLevel);
            // }

            // int totalRobberSkillLevel = robbersSkillLevels.Sum();
            // Console.WriteLine(totalRobberSkillLevel);

        }
    }
}