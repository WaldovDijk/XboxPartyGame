using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StoelenDans
{
    [CreateAssetMenu(menuName = "PluggableAI/State")]
    public class State : ScriptableObject
    {

        [SerializeField] private Action[] m_Actions;
        [SerializeField] private Transition[] m_Transitions;

        public void UpdateState(StateController controller)
        {
            DoActions(controller);
            CheckTransitions(controller);
        }

        private void DoActions(StateController controller)
        {
            for (int i = 0; i < m_Actions.Length; i++)
            {
                m_Actions[i].Act(controller);
            }
        }

        private void CheckTransitions(StateController controller)
        {
            for (int i = 0; i < m_Transitions.Length; i++)
            {
                bool decisionSucceeded = m_Transitions[i].decision.Decide(controller);

                if (decisionSucceeded)
                {
                    controller.TransitionToState(m_Transitions[i].trueState);
                }
                else
                {
                    controller.TransitionToState(m_Transitions[i].falseState);
                }
            }
        }
    }
}


