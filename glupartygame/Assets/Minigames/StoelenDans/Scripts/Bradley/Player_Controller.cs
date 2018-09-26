using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
	void Update ()
    {
        var x = Input.GetAxis("Key_Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Key_Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}
