using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StoelenDans
{
    public class PauseManager : MonoBehaviour
    {
        [SerializeField]
        public bool isPaused = false;

        void Update()
        {
            if (Input.GetButton("Player0_Start"))
            {
                if (isPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }

        void Resume()
        {
            Time.timeScale = 1f;
            isPaused = false;
        }

        void Pause()
        {
            Time.timeScale = 0f;
            isPaused = true;
        }
    }
}
