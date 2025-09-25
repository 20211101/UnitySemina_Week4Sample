using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagable : MonoBehaviour
{
    protected int hp = 100;
    protected void Init(int hp)
    {
        this.hp = hp;
    }

    internal void Damaged(int v)
    {
        hp -= v;

        Debug.Log(v + "피해를 입었다! 남은 체력 : " + hp);

        if (hp <= 0)
        {

            Debug.Log("처치되었다!");
            Destroy(gameObject);
        }
    }
}
