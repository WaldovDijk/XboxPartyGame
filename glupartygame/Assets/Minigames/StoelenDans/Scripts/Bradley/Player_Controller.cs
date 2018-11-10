using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StoelenDans
{
    public class Player_Controller : MonoBehaviour
    {
        [SerializeField]
        private bool m_Player00, m_Player01, m_Player02, m_Player03;

        [SerializeField]
        public Transform m_Player;

        public float m_WalkingSpeed = 10.0f;
        public float m_TurnSpeed = 10;

        private void FixedUpdate()
        {
            if (m_Player00 == true) 
            {
                float m_AxisX0 = Input.GetAxis("Player0_Vertical");
                float m_AxisY0 = Input.GetAxis("Player0_Horizontal");

                transform.Translate(m_AxisX0 * Time.deltaTime * m_WalkingSpeed * -1, 0, m_AxisY0 * Time.deltaTime * m_WalkingSpeed * -1, Space.World);

                float m_RX0 = Input.GetAxis("Player0_Horizontal2");

                m_Player.Rotate(0, m_RX0 * m_TurnSpeed, 0);

                bool m_PushA = Input.GetButton("Player0_A");
                bool m_SitY = Input.GetButton("Player0_Y");
            }

            if (m_Player01 == true)
            {
                float m_AxisX1 = Input.GetAxis("Player1_Vertical");
                float m_AxisY1 = Input.GetAxis("Player1_Horizontal");

                transform.Translate(m_AxisX1 * Time.deltaTime * m_WalkingSpeed * -1, 0, m_AxisY1 * Time.deltaTime * m_WalkingSpeed * -1, Space.World);

                float m_RX1 = Input.GetAxis("Player1_Horizontal2"); ;

                m_Player.Rotate(0, m_RX1 * m_TurnSpeed, 0);

                bool m_PushA = Input.GetButton("Player1_A");
                bool m_SitY = Input.GetButton("Player1_Y");
            }


            if (m_Player02 == true)
            {
                float m_AxisX2 = Input.GetAxis("Player2_Vertical");
                float m_AxisY2 = Input.GetAxis("Player2_Horizontal");

                transform.Translate(m_AxisX2 * Time.deltaTime * m_WalkingSpeed * -1, 0, m_AxisY2 * Time.deltaTime * m_WalkingSpeed * -1, Space.World);

                float m_RX2 = Input.GetAxis("Player2_Horizontal2");

                m_Player.Rotate(0, m_RX2 * m_TurnSpeed, 0);

                bool m_PushA = Input.GetButton("Player2_A");
                bool m_SitY = Input.GetButton("Player2_Y");
            }

            if (m_Player03 == true)
            {
                float m_AxisX3 = Input.GetAxis("Player3_Vertical");
                float m_AxisY3 = Input.GetAxis("Player3_Horizontal");

                transform.Translate(m_AxisX3 * Time.deltaTime * m_WalkingSpeed * -1, 0, m_AxisY3 * Time.deltaTime * m_WalkingSpeed * -1, Space.World);

                float m_RX3 = Input.GetAxis("Player3_Horizontal2");

                m_Player.Rotate(0, m_RX3 * m_TurnSpeed, 0);

                bool m_PushA = Input.GetButton("Player3_A");
                bool m_SitY = Input.GetButton("Player3_Y");
            }
        }
    }
}
