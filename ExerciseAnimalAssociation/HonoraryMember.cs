using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAnimalAssociation
{
    class HonoraryMember : Member
    {
        /*
        public int MembershipID { get; private set; }
        public string Name { get; private set; }
        public Reward Reward { get; private set; }
        public float Donation { get; private set; }*/
        public HonoraryMember(string name, Reward reward, float donation) : base(name)
        {
            Donation = donation;
            Reward = ChooseReward(reward);
        }
        public override Reward ChooseReward(Reward reward)
        {
            switch (reward)
            {
                case Reward.Travel:
                    return Reward.Travel;
                case Reward.Television:
                    return Reward.Television;
                case Reward.Smartphone:
                    return Reward.Smartphone;
                default:
                    return Reward.Smartphone;
            }
        }

        public override float Donate(float donation)
        {
            if (donation >= 70 || donation <= 80)
            {
                return donation;
            }
            else
            {
                return 70;
            }
        }
    }
}
