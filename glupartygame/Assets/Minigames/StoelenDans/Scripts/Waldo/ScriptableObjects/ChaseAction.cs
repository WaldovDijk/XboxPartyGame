﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StoelenDans
{
    [CreateAssetMenu(menuName = "PluggableAI/Actions/Chase")]
    public class ChaseAction : Action
    {
        public override void Act(StateController controller)
        {
            Chase(controller);
        }

        private void Chase(StateController controller)
        {
            
        }
    }

}
