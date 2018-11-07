using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Pooling;

/// <summary>
/// Shows the spill point on the glass when it's rotated.
/// </summary>
namespace LiquidVolumeFX
{
    public class SpillController : MonoBehaviour
    {

        [SerializeField]
        private List<PoolingObject> m_PoolObjects;

        [SerializeField]
        private List< GameObject> m_Spill;

        LiquidVolume lv;

        private GameObject m_PoolName;

        Vector3 spillPos;

        void Start()
        {
            lv = GetComponent<LiquidVolume>();

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
                        m_Spill.Add(obj);
                    }
                }
            }
        }

        void Update()
        {
            const float rotationSpeed = 10f;
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(-Vector3.forward * Time.deltaTime * rotationSpeed);
            }
        }


        void FixedUpdate()
        {

            
            float spillAmount;
            if (lv.GetSpillPoint(out spillPos, out spillAmount))
            {
                const int drops = 15;
                for (int k = 0; k < drops; k++)
                {
                    for (int i = 0; i < m_Spill.Count; i++)
                    {
                        if (!m_Spill[i].activeInHierarchy)
                        {
                            StartCoroutine(SpawnSpill(m_Spill[i]));
                            StartCoroutine(DestroySpill(m_Spill[i]));
                            break;

                        }

                    }
                   
                }
                lv.level -= spillAmount / 10f + 0.001f;
            }
        }

        IEnumerator SpawnSpill(GameObject m_Spill)
        {
            yield return new WaitForSeconds(0.001f);
            
            m_Spill.SetActive(true);
            m_Spill.transform.position = spillPos + Random.insideUnitSphere * 0.01f;
            //m_Spill[i].transform.localScale *= Random.Range(0.45f, 0.65f);
            m_Spill.GetComponent<Renderer>().material.color = Color.Lerp(lv.liquidColor1, lv.liquidColor2, Random.value);
            Vector3 force = new Vector3(Random.value - 0.5f, Random.value * 0.1f - 0.2f, Random.value - 0.5f);
            m_Spill.GetComponent<Rigidbody>().AddForce(force);
        }

        IEnumerator DestroySpill(GameObject spill)
        {
            yield return new WaitForSeconds(1f);
            spill.SetActive(false) ;
        }
    }
}
