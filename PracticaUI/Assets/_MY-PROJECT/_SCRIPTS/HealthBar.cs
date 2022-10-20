using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    #region Health
    [SerializeField]
    float health;
    [SerializeField]
    float heal;
    [SerializeField]
    float MAX_HEALTH = 100f;

    #endregion
    #region Damage
    [SerializeField]
    float dmg;

    #endregion
    #region Timers
    [SerializeField]
    float timer = 0f;

    #endregion

    #region UI
    [SerializeField]
    Image img;
    [SerializeField]
    Slider healthBar;
    [SerializeField]
    TextMeshProUGUI healthAmount;
    [SerializeField]
    TextMeshProUGUI dmgAmount;

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        health = MAX_HEALTH;
        //health = maxHealth / 2f;
        healthBar.maxValue = MAX_HEALTH;
        healthBar.value = healthBar.maxValue;
    }

    void Update()
    {
        healthBar.value = health;

        healthAmount.text = healthBar.value.ToString("f0");

        if (health > MAX_HEALTH)
            health = MAX_HEALTH;

        timer += Time.deltaTime;

        if(timer >= 2f)
        {
            dmgAmount.text = " ";
            timer = 0f;
        }

        if (Input.GetKeyDown(KeyCode.A))
            AddHealth();
        if (Input.GetKeyDown(KeyCode.S))
            TakeDamage();
    }

    public void DesireHealth(float amount)
    {
        health += amount;
    }

    public void AddHealth()
    {
        health += heal;
    }
    public void TakeDamage()
    {
        Debug.Log("Pulsado");
        health -= dmg;
        dmgAmount.text = dmg.ToString();
    }
}
