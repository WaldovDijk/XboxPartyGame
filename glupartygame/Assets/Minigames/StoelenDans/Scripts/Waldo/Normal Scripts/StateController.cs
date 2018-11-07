using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;
using LiquidVolumeFX;

namespace StoelenDans
{
    public class StateController : MonoBehaviour
    {

        [SerializeField] private State m_CurrentState;
        [SerializeField] private State m_RemainState;
        [SerializeField] private int m_PlayerID;
        [SerializeField] private GameObject m_LiquidDispenser;

        private LiquidVolume m_PlayerGlass;
        public LiquidVolume PlayerGlass
        {
            get { return m_PlayerGlass; }
            set { m_PlayerGlass = value; }
        }

        [SerializeField]
        private float m_VulSpeed = 0.005f;
        public float VulSpeed
        {
            get { return m_VulSpeed; }
        }

        private bool m_Collision;
        public bool Coll
        {
            get
            {
                return m_Collision;
            }
        }

        private bool m_PlayerCollision;
        public bool PlayerColl
        {
            get
            {
                return m_PlayerCollision;
            }
        }

        private LiquidVolume m_Tap;
        public LiquidVolume Tap
        {
            get
            {
                return m_Tap;
            }
        }

        private float m_StateTimeElapsed;

        
        private GameObject m_Player;

        private BierTap m_Barrel;
        public BierTap Barrel
        {
            get
            {
                return m_Barrel;
            }
        }

        private bool m_AiActive = true;

        void Awake()
        {
           
            m_Tap = m_LiquidDispenser.GetComponent<LiquidVolume>();
            m_Player = GameObject.FindWithTag("Tag " + m_PlayerID);
            m_PlayerGlass = m_Player.transform.GetChild(0).GetComponent<LiquidVolume>();

        }

        void Update()
        {

            

            if (!m_AiActive)
                return;
            m_CurrentState.UpdateState(this);


        }

        public void TransitionToState(State nextState)
        {
            if (nextState != m_RemainState)
            {
                m_CurrentState = nextState;
            }
        }

        public bool CheckIfCountDownElapsed(float duration)
        {
            m_StateTimeElapsed += Time.deltaTime;
            return (m_StateTimeElapsed >= duration);
        }

        private void OnExitState()
        {
            m_StateTimeElapsed = 0;
        }

        void OnTriggerStay(Collider collision)
        {
            if(m_Player != null)
            {
                if (collision.tag == m_Player.tag)
                {
                    m_PlayerCollision = m_Player.activeSelf;

                    if (collision.GetComponent<Player_Controller>())
                        m_Collision = true;
                }
                    
            }
            
        }
        void OnTriggerExit(Collider collider)
        {
            if (m_Player != null)
            {
                if (collider.tag == m_Player.tag)    
                {
                    m_PlayerCollision = false;
                    if (collider.GetComponent<Player_Controller>())
                        m_Collision = false;
                }

                
            }
                
        }


    }
}

