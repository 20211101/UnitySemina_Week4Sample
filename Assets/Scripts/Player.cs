using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(PlayerInput))]
public class Player : MonoBehaviour
{
    private Rigidbody rb;
    private PlayerInput input;
    [SerializeField] private GameObject bullet;

    public float Speed { get; private set; } = 10f;
    public float Ammo { get; private set; } = 1f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        input = GetComponent<PlayerInput>();
    }

    void Update()
    {
        rb.velocity = input.InputAxis.normalized * Speed;
        if(input.AttackInput)
        {
            GameObject instance = Instantiate(bullet, transform.position, Quaternion.identity);
            instance.GetComponent<Bullet>().Init(input.InputAxis.normalized);
        }
    }

    public void SpeedUp()
    {
        Speed += 1;
    }
    public void AmmoUp()
    {
        Ammo += 5;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (InteractItemCollision(other)) { }
        else
        {
            Monster monster = other.GetComponent<Monster>();
            if (monster == null) return;
            gameObject.SetActive(false);
        }
    }

    bool InteractItemCollision(Collider other)
    {
        Item item = other.GetComponent<Item>();
        if (item == null) return false;
        item.Use(this);
        Destroy(other.gameObject);
        return true;
    }
}
