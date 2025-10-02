using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    float speed = 10;
    public void Init(Vector3 dir)
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = dir.normalized * speed;
        Destroy(gameObject, 10);
    }

    public float d
    {
        get; private set;
    }

    private void OnTriggerEnter(Collider other)
    {
        Monster monster = other.GetComponent<Monster>();
        if(monster)
        {
            monster.Damaged();
            Destroy(gameObject);
        }
    }
}
