using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAnimalAssociation
{
    abstract class Member : IExtra, IComparable
    {
        public int MembershipID { get; set; }
        public string Name { get; set; }
        public Reward Reward { get; set; }
        public float Donation { get; set; }
        public Member(string name)
        {
            Name = name;
        }
        public virtual Reward ChooseReward(Reward reward)
        {
            return Reward.Smartphone;
        }

        public virtual float Donate(float donation)
        {
            return donation;
        }

        public int CompareTo(object obj)
        {
            if (obj != null)
            {
                return Name.CompareTo((obj as Member).Name);
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return string.Format("{0,-4}Name: {1,-10}Reward: {2,-12},Donation: {3}", MembershipID, Name, Reward, Donation);
        }
    }
}
