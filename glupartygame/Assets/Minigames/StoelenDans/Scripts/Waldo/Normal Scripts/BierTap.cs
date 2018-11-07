using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LiquidVolumeFX;

namespace StoelenDans
{
    public class BierTap : MonoBehaviour
    {

        private LiquidVolume m_Tap;

        [SerializeField]
        private float m_VulSpeed = 0.005f;

        private bool m_Glass = false;

        // Use this for initialization
        void Start()
        {
            m_Tap = gameObject.GetComponent<LiquidVolume>();
        }

        // Update is called once per frame
        void Update()
        {
            if (m_Glass == true)
            {
                m_Tap.level = 0.7f;
            }
            
        }

        void OnTriggerStay(Collider Glass)
        {
            LiquidVolume _Glass;
            _Glass = Glass.GetComponent<LiquidVolume>();

            if (_Glass != null)
            {
                if(_Glass.level < 0.9f)
                {
                    m_Glass = true;
                    _Glass.level += 0.001f;
                }
                else
                {
                    _Glass.level = 0.9f;
                    m_Glass = false;
                }
                
            }
        }
    }

}
