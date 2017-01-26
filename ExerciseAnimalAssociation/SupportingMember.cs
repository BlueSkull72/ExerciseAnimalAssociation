using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAnimalAssociation
{
    class SupportingMember : Member
    {
        public SupportingMember(string name, Reward reward, float donation) : base(name)
        {
            Donation = donation;
            Reward = ChooseReward(reward);
        }
        public override Reward ChooseReward(Reward reward)
        {
            switch (reward)
            {
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
            if (donation >= 40 || donation <= 50)
            {
                return donation;
            }
            else
            {
                return 40;
            }
        }
    }
}
