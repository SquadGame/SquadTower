using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Monster : MonoBehaviour {

    private Text healthDisplayText;
    public int startingHealth = 100;
    private Image healthDisplay;
    public float currentHealth;
    public int gold = 10;

    void Start() {
        
        healthDisplay = GameObject.FindGameObjectWithTag("Health").GetComponent<Image>();
        healthDisplayText = healthDisplay.GetComponentInChildren<Text>();
        currentHealth = startingHealth;
    }
	
	// Update is called once per frame
	void Update () {
        healthDisplayText.text = currentHealth.ToString();

        healthDisplay.fillAmount = (currentHealth / startingHealth);

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
	}

}
