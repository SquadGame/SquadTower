using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gold : MonoBehaviour {

    private float total = 0;
	
    public void AddGold(int amount)
    {
        total += amount;
        gameObject.GetComponent<Text>().text = "Gold: " + total.ToString();
    }
}
