using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Attack : MonoBehaviour {

    private Monster monster = null;
    public int clickDamage = 1;



    // Update is called once per frame
    void Update() {
        if(monster == null)
        {
            monster = GameObject.FindGameObjectWithTag("Monster").GetComponent<Monster>();
        }
    }

    public void MonsterHit(){

        monster.Health -= clickDamage;
        if (monster.Health == 0)
        {
            monster = null;
        }

    }
}
