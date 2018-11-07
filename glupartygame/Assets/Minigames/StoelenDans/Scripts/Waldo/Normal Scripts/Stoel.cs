using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StoelenDans
{
    public class Stoel : MonoBehaviour
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
            if (Player.gameObject.GetComponent<Rigidbody>())
            {
                Debug.Log("LOL");
                Player.gameObject.transform.position = this.gameObject.transform.position;
            }
        }
    }
}

