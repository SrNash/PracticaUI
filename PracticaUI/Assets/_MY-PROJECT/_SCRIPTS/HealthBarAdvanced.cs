using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarAdvanced : MonoBehaviour
{
    [SerializeField]
    float health;
    [SerializeField]
    float lerpTimer;
    [SerializeField]
    float maxHealth = 100f;
    [SerializeField]
    float chipSpeed = 2f;
    [SerializeField]
    Image frontHealthBar, backHealthBar;

    [SerializeField]
    float dmg;
    [SerializeField]
    float heals;

    float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health > maxHealth)
            health = maxHealth;
        else if (health <= 0f)
            health = 0f;

        health = Mathf.Clamp(health, 0, maxHealth);
        UpdateHealthUI();

        if (Input.GetKeyDown(KeyCode.A))
            TakeDamage(dmg);

        if (Input.GetKeyDown(KeyCode.D))
            AddHealth(heals);
    }


    private void UpdateHealthUI()
    {
        float fillA = frontHealthBar.fillAmount;
        float fillB = backHealthBar.fillAmount;
        float hFraction = health / maxHealth;

        if(fillB > hFraction)
        {
            frontHealthBar.fillAmount = hFraction;
            backHealthBar.color = Color.red;
            lerpTimer += Time.deltaTime;
            float percentComplete = lerpTimer / chipSpeed;
            backHealthBar.fillAmount = Mathf.Lerp(fillB, hFraction, percentComplete);
        }

        if(fillA < hFraction)
        {
            backHealthBar.color = Color.green;
            backHealthBar.fillAmount = hFraction;
            lerpTimer += Time.deltaTime;
            float percentComplete = lerpTimer / chipSpeed;
            percentComplete = percentComplete * percentComplete;
            frontHealthBar.fillAmount = Mathf.Lerp(fillA, backHealthBar.fillAmount, percentComplete);
        }
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        lerpTimer = 0f;
    }
    public void AddHealth(float amount)
    {
        health += amount;
        lerpTimer = 0f;
    }
}
