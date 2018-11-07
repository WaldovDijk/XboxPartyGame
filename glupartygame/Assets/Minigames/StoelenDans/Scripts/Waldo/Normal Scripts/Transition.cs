using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StoelenDans
{
    [System.Serializable]
    public class Transition
    {
        [SerializeField] private Decision m_Decision;
        public Decision decision
        {
            get
            {
                return m_Decision;
            }
        }
        [SerializeField] private State m_TrueState;
        public State trueState
        {
            get
            {
                return m_TrueState;
            }
        }
        [SerializeField] private State m_FalseState;
        public State falseState
        {
            get
            {
                return m_FalseState;
            }
        }
    }

}
