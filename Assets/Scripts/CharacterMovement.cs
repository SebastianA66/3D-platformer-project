
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterMovement : MonoBehaviour
{

    public float startSpeed = 30f;
    public float moveSpeed = 30f;
    public float jumpSpeed = 10f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;
    public CharacterController controller;

    public bool isDashing;




    private void Start()
    {
        controller = this.GetComponent<CharacterController>();
        Cursor.visible = false;

    }

   

    void Update()
    {

        if (controller.isGrounded || isDashing)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));


            moveDirection = transform.TransformDirection(moveDirection);

            moveDirection *= moveSpeed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);



    }
}
