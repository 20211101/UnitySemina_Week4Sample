using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Monster : MonoBehaviour
{
    Rigidbody rb;
    Transform target;
    float moveSpeed = 10f;

    public void Init(Transform _target)
    {
        target = _target;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(target != null)
        {
            rb.velocity = (target.position - transform.position).normalized * moveSpeed;
        }
    }

    public void Damaged()
    {
        Destroy(gameObject);
    }
}
