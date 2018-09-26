using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pooling;

public class GameManager : MonoBehaviour {


    [SerializeField]
    private List<PoolingObject> m_PoolObjects;

    GameObject m_PoolName;
    // Use this for initialization
    void Start () {
       // m_Bullets = new List<GameObject>();

        for (int p = 0; p < m_PoolObjects.Count; p++)
        {
            m_PoolName = GameObject.Find("Pool" + " " + m_PoolObjects[p].ObjectType.name);
            if (m_PoolName == null)
            {
                m_PoolName = new GameObject("Pool" + " " + m_PoolObjects[p].ObjectType.name);
            }


            for (int i = 0; i < m_PoolObjects[p].Amount; i++)
            {
                {
                    GameObject obj = (GameObject)Instantiate(m_PoolObjects[p].ObjectType);
                    obj.transform.parent = m_PoolName.transform;
                    obj.SetActive(false);
                    //m_Bullets.Add(obj);
                }
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
