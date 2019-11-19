using System;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");
            Console.WriteLine();

            Heister teamMember;
            Console.WriteLine("What is the team members name?");
            string name = Console.ReadLine();

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

            teamMember = new Heister()
            {
                Name = name,
                SkillLevel = skillLevel,
                CourageFactor = courageFactor
            };

            Console.WriteLine($"Name: {teamMember.Name}");
            Console.WriteLine($"Skill Level: {teamMember.SkillLevel}");
            Console.WriteLine($"Courage Factor: {teamMember.CourageFactor}");
        }
    }
}