using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using Pooling;

namespace StoelenDans
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        private List<AudioClip> m_Songs;

        private AudioSource m_AudioSource;

        [SerializeField]
        private List<Player_Controller> m_PlayerControllers;

        [SerializeField]
        private List<PoolingObject> m_PoolObjects;

        [SerializeField]
        private List<GameObject> m_Stoelen;

        [SerializeField]
        private float m_Timer;

        [SerializeField]
        private List<Transform> m_ChairSpawns;

        private bool m_MusicPlaying;

        GameObject m_PoolName;
        // Use this for initialization
        void Start()
        {

            m_Stoelen = new List<GameObject>();

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
                        m_Stoelen.Add(obj);
                    }
                }
            }

            m_AudioSource = gameObject.GetComponent<AudioSource>();


            m_AudioSource.clip = m_Songs[UnityEngine.Random.Range(0, m_Songs.Count)];
            m_AudioSource.Play();
            m_MusicPlaying = true;

            m_Timer = UnityEngine.Random.Range(10, 30);
        }

        // Update is called once per frame
        void Update()
        {
            m_Timer -= Time.deltaTime;
            if (m_Timer > 0f && m_MusicPlaying == true )
            {
                
                m_MusicPlaying = false;
            } 
            
            if(m_Timer <= 0)
            {
                m_AudioSource.Stop();
                ChairSpawn();
                m_Timer = UnityEngine.Random.Range(10, 30);
            }
                

            ChairUpdate();
        }

        void ChairSpawn()
        {
            foreach (GameObject Chair in m_Stoelen)
            {
                int _Random = UnityEngine.Random.Range(0, m_ChairSpawns.Count);
                Chair.transform.position = m_ChairSpawns[_Random].transform.position;
                Destroy(m_ChairSpawns[_Random]);
                m_ChairSpawns.Remove(m_ChairSpawns[_Random]);
                Chair.SetActive(true);
            }
        }

        void ChairUpdate()
        {
            if( m_Stoelen.All(m_Stoelen => m_Stoelen.gameObject.transform.GetChild(0).GetComponent<Stoel>().PlayerOnChair))
            {
                Restart();
                Debug.Log("Restart");
            }

        }
        void Restart()
        {
            if(m_Stoelen.Count > 0)
            {
                Destroy(m_Stoelen[0].gameObject);
                m_Stoelen.Remove(m_Stoelen[0]);
                foreach (GameObject Stoel in m_Stoelen)
                {
                    Stoel.gameObject.transform.GetChild(0).GetComponent<Stoel>().PlayerOnChair = false;
                    Stoel.SetActive(false);
                }
                if(m_PlayerControllers.Any(m_PlayerControllers => !m_PlayerControllers.Sit))
                {
                    ResetPlayers();
                }
                m_AudioSource.clip = m_Songs[UnityEngine.Random.Range(0, m_Songs.Count)];
                m_AudioSource.Play();
                m_MusicPlaying = true;
            }
        }
        void ResetPlayers()
        {
            foreach(Player_Controller Speler in m_PlayerControllers)
            {
                if(Speler.Sit == false)
                {
                    Destroy(Speler.gameObject);
                    m_PlayerControllers.Remove(Speler);
                }
                else
                {
                    Speler.Sit = false;
                }
            }
        }
    }
}

