using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarTheDivision2 : MonoBehaviour
{
    [SerializeField]
    Image[] healthPoints;

    [SerializeField]
    float health, maxHealth = 100f;
    [SerializeField]
    float armour, maxArmour = 250f;

    // Start is called before the first frame update
    void Start()
    {
        armour = maxArmour;
        health = maxHealth;

        for (int i = 0; i < healthPoints.Length; i++)
        {
            healthPoints[i].enabled = !DisplayHealthPoints(health, i);
        }
    }

    // Update is called once per frame
    /*void UpdateHealthUI()
    {
        
    }*/

    bool DisplayHealthPoints(float _health, int pointsNumber)
    {
        return ((pointsNumber * 10) >= _health);
    }
}
