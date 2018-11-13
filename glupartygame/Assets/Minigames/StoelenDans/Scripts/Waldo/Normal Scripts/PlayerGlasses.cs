using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace StoelenDans
{

    public class PlayerGlasses : MonoBehaviour
    {

        [SerializeField] private Slider m_Slider1, m_Slider2, m_Slider3, m_Slider4;
        [SerializeField] private PlayerGlass m_Player1, m_Player2, m_Player3, m_Player4;

        void Update()
        {
            m_Slider1.value = m_Player1.GlassVolume.level;

            m_Slider2.value = m_Player2.GlassVolume.level;

            m_Slider3.value = m_Player3.GlassVolume.level;

            m_Slider4.value = m_Player4.GlassVolume.level;

        }


    }
}

