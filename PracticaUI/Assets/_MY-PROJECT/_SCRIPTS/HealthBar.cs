using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    float timer = 0f;

    [SerializeField]
    float dmg;
    [SerializeField]
    float health;
    [SerializeField]
    float heal;
    [SerializeField]
    float maxHealth = 100f;
    [SerializeField]
    float lerpTimer;
    [SerializeField]
    float chipSpeed = 2f;

    [SerializeField]
    Image img;
    [SerializeField]
    Slider healthBar;
    [SerializeField]
    TextMeshProUGUI healthAmount;
    [SerializeField]
    TextMeshProUGUI dmgAmount;

    // Start is called before the first frame update
    void Start()
    {
        //img = GetComponent<Image>();
        //img.fillAmount = .5f;
        health = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = healthBar.maxValue;
    }

    void Update()
    {
        health = Mathf.Clamp(health, 0, maxHealth);
        healthBar.value = health;

        healthAmount.text = healthBar.value.ToString("f0");
        
        
        timer += Time.deltaTime;

        if(timer >= 2f)
        {
            dmgAmount.text = " ";
            timer = 0f;
        }

    }

    public void DesireHealth(float amount)
    {
        //img.fillAmount += amount;
        healthBar.value += amount;
    }

    // Update is called once per frame
    public void AddHealth()
    {
        //img.fillAmount += .1f;
        healthBar.value += heal;
    }
    public void TakeDamage()
    {
        //img.fillAmount -= .1f;
        healthBar.value -= dmg;
        lerpTimer = 0f;
        dmgAmount.text = dmg.ToString();
    }
}
