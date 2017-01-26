using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAnimalAssociation
{
    interface IExtra
    {
        Reward ChooseReward(Reward reward);
        float Donate(float donation);
    }
}
