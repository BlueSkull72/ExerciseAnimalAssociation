using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAnimalAssociation
{
    class NormalMember : Member
    {
        public NormalMember(string name, Reward reward, float donation) : base(name)
        {
            Donation = donation;
            Reward = ChooseReward(reward);
        }
        public override Reward ChooseReward(Reward reward)
        {
            switch (reward)
            {
                case Reward.Smartphone:
                    return Reward.Smartphone;
                default:
                    return Reward.Smartphone;
            }
        }

        public override float Donate(float donation)
        {
            if (donation >= 20 || donation <= 30)
            {
                return donation;
            }
            else
            {
                return 20;
            }
        }
    }
}
