using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCapsule : MonoBehaviour
{
    [SerializeField] GameObject monster;
    float SpawnTime = 5;
    float SpawnTimer = 0;
    float SpawnRatio => SpawnTimer / SpawnTime;

    Transform target;
    public void Init(Transform target)
    {
        this.target = target;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTimer += Time.deltaTime;
        transform.localScale = Vector3.Lerp(Vector3.one, new Vector3(0.1f,0.1f,0.1f), SpawnRatio);
        if(SpawnTimer > SpawnTime)
        {
            Instantiate(monster, transform.position, Quaternion.identity).GetComponent<Monster>().Init(target);
            Destroy(gameObject);
        }
    }
}
