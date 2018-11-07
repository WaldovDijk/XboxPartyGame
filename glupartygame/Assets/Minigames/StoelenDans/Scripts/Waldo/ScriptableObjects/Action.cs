using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StoelenDans
{
    public abstract class Action : ScriptableObject
    {
        public abstract void Act(StateController controller);
    }
}

