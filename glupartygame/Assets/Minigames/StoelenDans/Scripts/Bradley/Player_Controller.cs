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

                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 1) * -1;// new Vector3(m_AxisX0 * m_WalkingSpeed, 0, m_AxisY0 * m_WalkingSpeed);

                //transform.Translate(m_AxisX0 * Time.deltaTime * m_WalkingSpeed * -1, 0, m_AxisY0 * Time.deltaTime * m_WalkingSpeed, Space.World);

                float m_RX = Input.GetAxis("Player0_Horizontal2");
                float m_RY = Input.GetAxis("Player0_Vertical2");

                float Angle = Mathf.Atan2(m_RX * Time.deltaTime, m_RY * Time.deltaTime);

                transform.rotation = Quaternion.EulerAngles(0, Angle, 0);

            }

            if (m_Player01 == true)
            {
                //Move and Rotate Player 2
                float m_AxisX1 = Input.GetAxis("Player1_Horizontal");
                float m_AxisY1 = Input.GetAxis("Player1_Vertical");
                float m_XRight1 = Input.GetAxis("Player1_Horizontal2");

                Vector3 m_Movement1 = transform.TransformDirection(new Vector3(m_AxisX1 * -1, 0, m_AxisY1) * m_WalkingSpeed * Time.deltaTime);
                //Vector3 r1 = (new Vector3(0, m_XRight1, 0) * m_TurnSpeed) * Time.deltaTime;

                //transform.eulerAngles = transform.eulerAngles + r1;
                transform.position = transform.position + m_Movement1;
            }


            if (m_Player02 == true)
            {
                //Move and Rotate Player 3
                float m_AxisX2 = Input.GetAxis("Player2_Horizontal");
                float m_AxisY2 = Input.GetAxis("Player2_Vertical");
                float m_XRight2 = Input.GetAxis("Player2_Horizontal2");

                Vector3 m_Movement2 = transform.TransformDirection(new Vector3(m_AxisX2 * -1, 0, m_AxisY2) * m_WalkingSpeed * Time.deltaTime);
                Vector3 r2 = (new Vector3(0, m_XRight2, 0) * m_TurnSpeed) * Time.deltaTime;

                //transform.eulerAngles = transform.eulerAngles + r2;
                transform.position = transform.position + m_Movement2;
            }

            if (m_Player03 == true)
            {
                //Move and Rotate Player 4
                float m_AxisX3 = Input.GetAxis("Player3_Horizontal");
                float m_AxisY3 = Input.GetAxis("Player3_Vertical");
                float m_XRight3 = Input.GetAxis("Player3_Horizontal2");

                Vector3 m_Movement3 = transform.TransformDirection(new Vector3(m_AxisX3 * -1, 0, m_AxisY3) * m_WalkingSpeed * Time.deltaTime);
                Vector3 r3 = (new Vector3(0, m_XRight3, 0) * m_TurnSpeed) * Time.deltaTime;

                //transform.eulerAngles = transform.eulerAngles + r3;
                transform.position = transform.position + m_Movement3;
            }
        }
    }
}
