using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] FieldObjectSpawner fieldObjectSpawner;
    [SerializeField] Player player;

    float monsterSpawnTime = 4f;
    float monsterSpawnTimer = 0f;
    float ammoSpawnTime = 4f;
    float ammoSpawnTimer = 0;
    float speedItemSpawnTime = 10f;
    float speedItemSpawnTimer = 0;

    private void Update()
    {
        monsterSpawnTimer += Time.deltaTime;
        ammoSpawnTimer += Time.deltaTime;
        speedItemSpawnTimer += Time.deltaTime;

        if (monsterSpawnTime < monsterSpawnTimer)
        {
            monsterSpawnTimer -= monsterSpawnTime;
            GameObject monsterCapsule = fieldObjectSpawner.SpawnMonster();
            monsterCapsule.GetComponent<MonsterCapsule>().Init(player.transform);
        }
        else if (ammoSpawnTime < ammoSpawnTimer)
        {
            ammoSpawnTimer -= ammoSpawnTime;
            fieldObjectSpawner.SpawnAmmo();
        }
        else if (speedItemSpawnTime < speedItemSpawnTimer)
        {
            speedItemSpawnTimer -= speedItemSpawnTime;
            fieldObjectSpawner.SpawnSpeedItem();
        }
    }
}
