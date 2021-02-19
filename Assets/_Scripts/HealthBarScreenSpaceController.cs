using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable] // make this class available to anywhere in the game
public class HealthBarScreenSpaceController : MonoBehaviour
{
    [Header("Health Properties")]
    [Range(0, 100)]
    public int currentHealth = 100;
    [Range(1, 100)]
    public int maximumHealth = 100;

    private Slider healthBarSlider;

    // Start is called before the first frame update
    void Start()
    {
        healthBarSlider = GetComponent<Slider>(); // find the slider automatically for us
        currentHealth = maximumHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K)) {
            TakeDamage(10);
        }

        if(Input.GetKeyDown(KeyCode.R)) {
            Reset();
        }
    }

    public void TakeDamage(int damage)
    {
        healthBarSlider.value -= damage;
        currentHealth -= damage;

        if (currentHealth < 0) {
            healthBarSlider.value = 0;
            currentHealth = 0;
        }
    }

    public void Reset() {
        healthBarSlider.value = maximumHealth;
        currentHealth = maximumHealth;
    }
}
