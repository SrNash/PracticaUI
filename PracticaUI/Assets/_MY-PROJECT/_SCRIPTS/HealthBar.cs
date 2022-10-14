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
        healthBar.maxValue = 100f;
        healthBar.value = healthBar.maxValue;
    }

    void Update()
    {
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
        healthBar.value += health;
    }
    public void TakeDamage()
    {
        //img.fillAmount -= .1f;
        healthBar.value -= dmg;
        dmgAmount.text = dmg.ToString();
    }
}
