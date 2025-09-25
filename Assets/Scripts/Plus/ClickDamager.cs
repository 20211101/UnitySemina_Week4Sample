using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDamager : MonoBehaviour
{
    Camera cam;
    private void Awake()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            ApplyDamage();
    }

    private void ApplyDamage()
    {
        Damagable target = SearchDamagable();
        if (target == null)
            return;
        target.Damaged(10);
    }

    private Damagable SearchDamagable()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) 
        {
            Damagable damagable = hit.transform.GetComponent<Damagable>();
            if (damagable != null)
                return damagable;
        }
        return null;
    }
}
