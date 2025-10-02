using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject monsterCapsule;
    [SerializeField] private GameObject ammo;
    [SerializeField] private GameObject speedItem;

    [SerializeField] Ground ground;

    public GameObject SpawnMonster()
    {
        Vector3 spawnPos = ground.GetRandomGroundPos();
        GameObject instance = Instantiate(monsterCapsule, spawnPos, Quaternion.identity);
        return instance;
    }
    public GameObject SpawnAmmo()
    {
        Vector3 spawnPos = ground.GetRandomGroundPos();
        GameObject instance = Instantiate(ammo, spawnPos, Quaternion.identity);
        return instance;
    }
    public GameObject SpawnSpeedItem()
    {
        Vector3 spawnPos = ground.GetRandomGroundPos();
        GameObject instance = Instantiate(speedItem, spawnPos, Quaternion.identity);
        return instance;
    }
}
