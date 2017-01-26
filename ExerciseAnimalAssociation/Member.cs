using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAnimalAssociation
{
    abstract class Member : IExtra, IComparable
    {
        public int MembershipID { get; private set; }
        public string Name { get; private set; }
        public Reward Reward { get; private set; }
        public float Donation { get; private set; }
        public Member(string name)
        {
            Name = name;
        }
        public Reward ChooseReward(Reward reward)
        {
            throw new NotImplementedException();
        }

        public float Donate(float donation)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            return Name.CompareTo(obj);
        }
        public override string ToString()
        {
            return string.Format("{0,4}Name: {1,10}Reward: {2,12},Donation: {3}", MembershipID, Name, Reward, Donation);
        }
    }
}
