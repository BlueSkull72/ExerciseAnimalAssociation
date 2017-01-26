using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAnimalAssociation
{
    class Members
    {
        List<Member> allMembers = new List<Member>();
        private static int memberNumber = 100;
        bool sortedByName = false;
        public void AddMember(Member member)
        {
            member.MembershipID = memberNumber;
            allMembers.Add(member);
            memberNumber++;
        }

        public void SortByName()
        {
            allMembers.Sort();
            sortedByName = true;
        }
        public override string ToString()
        {
            string output = "";
            if (sortedByName)
            {
                output = "SORTED BY NAME";
            }
            else
            {
                output = "UNSORTED LIST OF ALL MEMBERS";
            }
            foreach (Member member in allMembers)
            {
                output += "\n" + member.ToString();
            }
            output += "\n" + string.Concat(Enumerable.Repeat("-", 56));
            return output;
        }
        public string ToStringByReward(Reward reward)
        {
            string output = "MEMBERS WHO CHOSE A " + reward.ToString().ToUpper() + ":";
            foreach (Member member in allMembers)
            {
                if (member.Reward == reward)
                {
                    output += "\n" + member.ToString();
                }
            }
            output += "\n" + string.Concat(Enumerable.Repeat("-", 56));
            return output;
        }
        public Member ShowLastMember()
        {
            int highestindex = 0;
            Member lastMember = null;
            foreach (Member member in allMembers)
            {
                if (member.MembershipID > highestindex)
                {
                    highestindex = member.MembershipID;
                    lastMember = member;
                }
            }
            return lastMember;
        }
        public Member SearchByName(string name)
        {
            foreach (Member member in allMembers)
            {
                if (member.Name.ToLower() == name.ToLower())
                {
                    return member;
                }
            }
            Console.WriteLine("{0} is not a registered member.", name.ToUpper());
            return null;
        }
    }
}
