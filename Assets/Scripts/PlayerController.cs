using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    public bool rotateToMainCamera = false;
    public float moveSpeed = 10f;
    public float startSpeed = 10f;
    public float jumpheight = 10f;
    public Rigidbody rigid;
    private bool isGrounded = true;
    public float RayDistance = 1f;

    private void OnDrawGizmos()
    {
        Ray groundRay = new Ray(transform.position, Vector3.down);

        Gizmos.DrawLine(groundRay.origin, groundRay.origin + groundRay.direction * RayDistance);
    }

    bool IsGrounded()
    {
        Ray groundRay = new Ray(transform.position, Vector3.down);
        RaycastHit hit;
        if (Physics.Raycast(groundRay, out hit, RayDistance)) // cast a line beneath th player
        {
            return true; // is grounded so return true
        }
        return false; // is not grounded so return false
    }


    void Update()
    {
        float inputH = Input.GetAxis("Horizontal") * moveSpeed;
        float inputV = Input.GetAxis("Vertical") * moveSpeed;
        Vector3 moveDir = new Vector3(inputH, 0f, inputV);
        
        


        Vector3 force = new Vector3(moveDir.x, rigid.velocity.y, moveDir.z);



        if (Input.GetButton("Jump") && IsGrounded())
        {
            force.y = jumpheight;
        }

        rigid.velocity = force;
    }

}