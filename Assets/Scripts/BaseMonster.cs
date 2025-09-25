using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMonster : /*MonoBehaviour*/  Damagable
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }
    
    void Attack()
    {
        Debug.Log("АјАн!!!");
    }
}
