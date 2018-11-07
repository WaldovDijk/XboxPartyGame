using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StoelenDans
{
    [CreateAssetMenu(menuName = "PluggableAI/Decisions/ActiveState")]
    public class ActiveStatDecision : Decision
    {
        
        public override bool Decide(StateController controller)
        {
            bool chaseTargetIsActive = controller.PlayerColl;
            return chaseTargetIsActive;
        }

    }

}
