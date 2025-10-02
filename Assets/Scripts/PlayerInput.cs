using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float HorizontalInput { get; private set; } = 0f;
    public float VerticalInput { get; private set; } = 0f;
    public bool AttackInput{ get; private set; } = false;
    public Vector3 InputAxis =>new Vector3(HorizontalInput, 0, VerticalInput);

    //float horizontalInput = 0f;
    //float verticalInput = 0f;
    //bool attackInput = false;

    //public float HorizontalInput => horizontalInput;
    //public float VerticalInput => verticalInput;
    //public bool AttackInput => attackInput;

    private void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
        AttackInput = Input.GetKeyDown(KeyCode.J);
    }
}
