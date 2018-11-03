using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StoelenDans
{
    public class Player_Controller : MonoBehaviour
    {
        [SerializeField]
        private bool m_Player00, m_Player01, m_Player02, m_Player03;

        public float m_WalkingSpeed = 10.0f;
        public float m_TurnSpeed = 10;

        private void FixedUpdate()
        {
            if (m_Player00 == true)
            {
                float m_AxisX0 = Input.GetAxis("Player0_Horizontal");
                float m_AxisY0 = Input.GetAxis("Player0_Vertical");

                transform.Translate(m_AxisX0 * Time.deltaTime * m_WalkingSpeed * -1, 0, m_AxisY0 * Time.deltaTime * m_WalkingSpeed, Space.World);

                float m_RX = Input.GetAxis("Player0_Horizontal2");
                float m_RY = Input.GetAxis("Player0_Vertical2");

                float Angle = Mathf.Atan2(m_RX * Time.deltaTime, m_RY * Time.deltaTime);

                transform.rotation = Quaternion.EulerAngles(0, Angle, 0);
            }

            if (m_Player01 == true)
            {
                float m_AxisX1 = Input.GetAxis("Player1_Horizontal");
                float m_AxisY1 = Input.GetAxis("Player1_Vertical");

                transform.Translate(m_AxisX1 * Time.deltaTime * m_WalkingSpeed * -1, 0, m_AxisY1 * Time.deltaTime * m_WalkingSpeed, Space.World);

                float m_RX1 = Input.GetAxis("Player1_Horizontal2");
                float m_RY1 = Input.GetAxis("Player1_Vertical2");

                float Angle1 = Mathf.Atan2(m_RX1 * Time.deltaTime, m_RY1 * Time.deltaTime);

                transform.rotation = Quaternion.EulerAngles(0, Angle1, 0);
            }


            if (m_Player02 == true)
            {
                float m_AxisX2 = Input.GetAxis("Player2_Horizontal");
                float m_AxisY2 = Input.GetAxis("Player2_Vertical");

                transform.Translate(m_AxisX2 * Time.deltaTime * m_WalkingSpeed * -1, 0, m_AxisY2 * Time.deltaTime * m_WalkingSpeed, Space.World);

                float m_RX2 = Input.GetAxis("Player2_Horizontal2");
                float m_RY2 = Input.GetAxis("Player2_Vertical2");

                float Angle2 = Mathf.Atan2(m_RX2 * Time.deltaTime, m_RY2 * Time.deltaTime);

                transform.rotation = Quaternion.EulerAngles(0, Angle2, 0);
            }

            if (m_Player03 == true)
            {
                float m_AxisX3 = Input.GetAxis("Player3_Horizontal");
                float m_AxisY3 = Input.GetAxis("Player3_Vertical");

                transform.Translate(m_AxisX3 * Time.deltaTime * m_WalkingSpeed * -1, 0, m_AxisY3 * Time.deltaTime * m_WalkingSpeed, Space.World);

                float m_RX3 = Input.GetAxis("Player3_Horizontal2");
                float m_RY3 = Input.GetAxis("Player3_Vertical2");

                float Angle3 = Mathf.Atan2(m_RX3 * Time.deltaTime, m_RY3 * Time.deltaTime);

                transform.rotation = Quaternion.EulerAngles(0, Angle3, 0);
            }
        }
    }
}
