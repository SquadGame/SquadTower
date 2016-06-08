using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Attack : MonoBehaviour {

    private Monster monster = null;
    public int clickDamage = 1;
    private Gold gold;

    void Start()
    {
        gold = GameObject.FindGameObjectWithTag("Gold").GetComponent<Gold>();
    }

    // Update is called once per frame
    void Update() {
        if(monster == null)
        {
            monster = GameObject.FindGameObjectWithTag("Monster").GetComponent<Monster>();
        }
    }

    public void MonsterHit(){

        monster.currentHealth -= clickDamage;
        if (monster.currentHealth == 0)
        {
            gold.AddGold(monster.gold);

            monster = null;
        }

    }
}
