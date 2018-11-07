using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StoelenDans {
    [CreateAssetMenu(menuName = "PluggableAI/Actions/Pour")]
    public class PourAction : Action
    {

        public override void Act(StateController controller)
        {
            Patrol(controller);
        }

        private void Patrol(StateController controller)
        {
            
             if(controller.PlayerGlass.level < 0.9f)
            {
                controller.Tap.level = 0.9f;
                controller.PlayerGlass.level += controller.VulSpeed;
            }
            
        }
    }
}

