using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using XBOXParty;

namespace StoelenDans
{
    public class StoelenDans_GameManager : MonoBehaviour
    {
        private List<int> _positions;

        private void Awake()
        {
            _positions = new List<int>();

            //If we don't change this player 1 will always be first, player 2 2nd and so on...
            int playerCount = GlobalGameManager.Instance.PlayerCount;
            for (int i = 0; i < playerCount; ++i)
            {
                _positions.Add(i);
            }

            //Bind button
            InputManager.Instance.BindButton("Stoelendans_Submit", 0, ControllerButtonCode.A, ButtonState.OnPress);
            InputManager.Instance.BindButton("Stoelendans_Submit", KeyCode.A, ButtonState.OnPress);
        }

        public void Update()
        {
            if (InputManager.Instance.GetButton("Stoelendans_Submit"))
            {
                Submit();
            }
        }

        public void Submit()
        {
            GlobalGameManager.Instance.SubmitGameResults(_positions);
        }
    }
}
