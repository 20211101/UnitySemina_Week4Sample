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

        Debug.Log(v + "���ظ� �Ծ���! ���� ü�� : " + hp);

        if (hp <= 0)
        {

            Debug.Log("óġ�Ǿ���!");
            Destroy(gameObject);
        }
    }
}
