using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAnimalAssociation
{
    class Program
    {
        static void Main(string[] args)
        {
            Members memberList = new Members();
            memberList.AddMember(new SupportingMember("Yves", Reward.Smartphone, 40.00F));
            memberList.AddMember(new SupportingMember("Kenneth", Reward.Travel, 80.00F));
            memberList.AddMember(new SupportingMember("Georges", Reward.Television, 45.00F));
            memberList.AddMember(new HonoraryMember("Grigor", Reward.Television, 78.00F));
            memberList.AddMember(new HonoraryMember("Tom", Reward.Travel, 70.00F));
            memberList.AddMember(new HonoraryMember("Shadi", Reward.Smartphone, 170.00F));
            memberList.AddMember(new NormalMember("Wouter", Reward.Travel, 25.00F));
            memberList.AddMember(new NormalMember("Sergei", Reward.Travel, 170.00F));
            memberList.AddMember(new NormalMember("Lennert", Reward.Smartphone, 10.00F));

            Console.WriteLine(memberList.ToString());
            memberList.SortByName();
            Console.WriteLine(memberList.ToString());
            Console.WriteLine(memberList.ToStringByReward(Reward.Smartphone));
            Console.WriteLine("LAST ADDED MEMBER:\n" + memberList.ShowLastMember().ToString() + "\n" + string.Concat(Enumerable.Repeat("-", 56)));
            Console.WriteLine("SEARCHING FOR MEMBER WITH NAME GRIGOR:\n" + memberList.SearchByName("Grigor").ToString() + "\n" + string.Concat(Enumerable.Repeat("-", 56)));
            Console.ReadKey(true);
        }
    }
}
