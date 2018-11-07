using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StoelenDans
{
    [CreateAssetMenu(menuName = "PluggableAI/Decisions/Look")]
    public class LookDecision : Decision
    {

        public override bool Decide(StateController controller)
        {
            bool _TargetVisible = Look(controller);
            return _TargetVisible;
        }

        private bool Look(StateController controller)
        {
            if (controller.Coll)
            {

                return true;
            }
            else
            {
                return false;
            }

        }

    }
}

