using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StoelenDans
{
    public class PauseManager : MonoBehaviour
    {
        public static PauseManager Instance;

        private List<Rigidbody> m_Rigidbodies;
        private List<ParticleSystem> m_ParticleSystems;

        private List<RigidbodyData> m_Data;

        public bool IsPaused;

        private void Awake()
        {
            Instance = this;
            m_Rigidbodies = new List<Rigidbody>();
            m_Data = new List<RigidbodyData>();
        }

        public void Add(Rigidbody _rigidbody)
        {
            m_Rigidbodies.Add(_rigidbody);
        }

        public void Add(ParticleSystem _ps)
        {
            m_ParticleSystems.Add(_ps);
        }

        public void Update()
        {
            if (Input.GetKey(KeyCode.P))
            {
                Pause();
            }

            if (Input.GetKey(KeyCode.O))
            {
                Resume();
            }
        }

        public void Pause()
        {
            m_Data.Clear();

            for (int i = 0; i < m_Rigidbodies.Count; i++)
            {
                m_Data.Add(new RigidbodyData()
                {
                    InstanceID = m_Rigidbodies[i].GetInstanceID(),
                    Velocity = m_Rigidbodies[i].velocity,
                    Drag = m_Rigidbodies[i].drag,
                    Gravity = m_Rigidbodies[i].useGravity,
                    Kinematic = m_Rigidbodies[i].isKinematic
                });

                m_Rigidbodies[i].isKinematic = true;
                m_Rigidbodies[i].useGravity = false;

                m_Rigidbodies[i].velocity = Vector3.zero;
                m_Rigidbodies[i].drag = 0;

                m_Rigidbodies[i].Sleep();
            }

            IsPaused = true;
        }

        public void Resume()
        {
            for (int i = 0; i < m_Rigidbodies.Count; i++)
            {
                RigidbodyData _data = m_Data.Find(j => j.InstanceID == m_Rigidbodies[i].GetInstanceID());

                m_Rigidbodies[i].isKinematic = _data.Kinematic;
                m_Rigidbodies[i].useGravity = _data.Gravity;

                m_Rigidbodies[i].velocity = _data.Velocity;
                m_Rigidbodies[i].drag = _data.Drag;

                m_Rigidbodies[i].WakeUp();
            }

            IsPaused = false;
        }

        private struct RigidbodyData
        {
            public int InstanceID;

            public bool Kinematic;
            public float Drag;
            public bool Gravity;
            public Vector3 Velocity;
        }
    }
}
