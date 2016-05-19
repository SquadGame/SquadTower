using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Monster : MonoBehaviour {

    private Text HealthDisplay;
    public int Health = 100;

    void Start() {

        HealthDisplay = GameObject.FindGameObjectWithTag("Health").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        HealthDisplay.text = "Health: " + Health;

        if (Health <= 0)
        {
            Destroy(gameObject);
        }
	}
}
