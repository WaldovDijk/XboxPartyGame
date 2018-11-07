using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StoelenDans
{
    public class TempPlayer : MonoBehaviour
    {

        private Rigidbody m_rbody;

        public float m_Speed;

        void Start()
        {
            m_rbody = gameObject.GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {

        }
        void FixedUpdate()
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(m_Speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(-m_Speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(0, 0, m_Speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(0, 0, -m_Speed * Time.deltaTime);
            }


        }
    }

}
