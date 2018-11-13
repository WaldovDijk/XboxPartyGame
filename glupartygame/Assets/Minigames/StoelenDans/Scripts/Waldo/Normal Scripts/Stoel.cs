using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StoelenDans
{
    public class Stoel : MonoBehaviour
    {
        [SerializeField]
        private GameObject m_Player1, m_Player2, m_Player3, m_Player4;

        [SerializeField]
        private bool m_PlayerOnChair = false;
        public bool PlayerOnChair
        {
            get { return m_PlayerOnChair; }
            set { m_PlayerOnChair = value; }
        }
        // Use this for initialization
        void Start()
        {
            m_Player1 = GameObject.FindGameObjectWithTag("Tag 0");
            m_Player2 = GameObject.FindGameObjectWithTag("Tag 1");
            m_Player3 = GameObject.FindGameObjectWithTag("Tag 2");
            m_Player4 = GameObject.FindGameObjectWithTag("Tag 3");
        }

        private void OnDrawGizmos()
        {
                Gizmos.color = Color.green;
                Gizmos.DrawWireSphere(gameObject.transform.position, 5f);
            
        }

        private void Update()
        {


            if (m_Player1 != null && !m_PlayerOnChair && Vector3.Distance(gameObject.transform.position, m_Player1.transform.position) < 5f)
            { 
                if (Input.GetButtonDown("Player0_Y") && m_Player1.gameObject.GetComponent<PlayerGlass>().GlassVolume.level >= 0.7f)
                {
                    m_Player1.transform.position = transform.position;
                    m_Player1.transform.rotation = transform.rotation;
                    m_Player1.gameObject.GetComponent<Player_Controller>().Sit = true;
                    m_PlayerOnChair = true;
                }



            }
            if (m_Player2 != null && !m_PlayerOnChair && Vector3.Distance(gameObject.transform.position, m_Player2.transform.position) < 5f)
            {

                {
                    m_Player2.transform.position = transform.position;
                    m_Player2.transform.rotation = transform.rotation;
                    m_Player2.gameObject.GetComponent<Player_Controller>().Sit = true;
                    m_PlayerOnChair = true;
                }
            }
            if (m_Player3 != null && !m_PlayerOnChair && Vector3.Distance(gameObject.transform.position, m_Player3.transform.position) < 5f)
            {
                if (Input.GetButtonDown("Player2_Y") && m_Player3.gameObject.GetComponent<PlayerGlass>().GlassVolume.level >= 0.7f)
                {
                    m_Player3.transform.position = transform.position;
                    m_Player3.transform.rotation = transform.rotation;
                    m_Player3.gameObject.GetComponent<Player_Controller>().Sit = true;
                    m_PlayerOnChair = true;

                }
            }
            if (m_Player4 != null && !m_PlayerOnChair && Vector3.Distance(gameObject.transform.position, m_Player4.transform.position) < 5f)
            {

                if (Input.GetButtonDown("Player3_Y") && m_Player4.gameObject.GetComponent<PlayerGlass>().GlassVolume.level >= 0.7f)
                {
                    m_Player4.transform.position = transform.position;
                    m_Player4.transform.rotation = transform.rotation;
                    m_Player4.gameObject.GetComponent<Player_Controller>().Sit = true;
                    m_PlayerOnChair = true;
                }
            }
        }

        void OnTriggerStay(Collider Player)
        {
            if (Player.gameObject.GetComponent<Rigidbody>())
            {
                Debug.Log("LOL");
                Player.gameObject.transform.position = this.gameObject.transform.position;
            }
        }
    }
}

