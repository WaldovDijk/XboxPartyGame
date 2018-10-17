using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StoelenDans
{
    public class TapPad : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        void OnTriggerStay(Collider Player)
        {
            PlayerGlass _Glass = Player.GetComponent<PlayerGlass>();

            if(_Glass != null)
            {
                Player.gameObject.transform.position = this.gameObject.transform.position;
            }
        }
    }
}

