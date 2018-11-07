using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoard : MonoBehaviour {

    private Camera m_Camera;

    // Update is called once per frame

    private void Start()
    {
        m_Camera = Camera.main;
    }
    void Update () {
        transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.back, m_Camera.transform.rotation* Vector3.up);
	}
}
