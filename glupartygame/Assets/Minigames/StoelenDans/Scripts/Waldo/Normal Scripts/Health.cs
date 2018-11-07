using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    [SerializeField]
    private int m_Health;

    private GameObject m_HealthBar;

    void FixedUpdate()
    {
        m_HealthBar = transform.GetChild(0).transform.GetChild(0).gameObject;
        m_HealthBar.GetComponent<Slider>().value = m_Health;

        if (m_Health <= 0)
        {
            m_Health = 100;
            gameObject.SetActive(false);
        }

    }

    public void ReceiveDamage(int damage)
    {
        m_Health -= damage;
    }
}
