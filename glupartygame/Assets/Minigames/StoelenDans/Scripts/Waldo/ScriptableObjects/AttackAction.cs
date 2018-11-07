using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StoelenDans
{
    [CreateAssetMenu(menuName = "PluggableAI/Actions/Attack")]
    public class AttackAction : Action
    {
        public override void Act(StateController controller)
        {
            Attack(controller);
        }

        private void Attack(StateController controller)
        {

        }
    }
}

