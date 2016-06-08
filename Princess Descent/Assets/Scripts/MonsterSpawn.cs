using UnityEngine;
using System.Collections;

[System.Serializable]
public class FloorMonsters
{
    public GameObject[] monster;
    public float maxMonsterCount;
}

public class MonsterSpawn : MonoBehaviour {

    public FloorMonsters floorMonsters;
    private int monstersSpawned;
    public bool floorCleared = false;
    private bool monsterDead = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(floorCleared == false)
        {
            if (monsterDead == true)
            {
                if (monstersSpawned < floorMonsters.maxMonsterCount)
                {
                    Instantiate(floorMonsters.monster[Random.Range(0, floorMonsters.monster.Length/* + 1*/)]);
                    monsterDead = false;
                    monstersSpawned += 1;
                }

                if (monstersSpawned == floorMonsters.maxMonsterCount)
                {
                    monstersSpawned = 0;
                    floorCleared = true;
                }
            }
            else
            {
                if(GameObject.FindGameObjectWithTag("Monster") == null)
                {
                    monsterDead = true;
                }
            }

        }
    }
}
