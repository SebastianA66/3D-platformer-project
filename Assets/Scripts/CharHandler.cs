using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharHandler : MonoBehaviour
{
    public bool alive;


    private void Start()
    {

        // Player starts alive
        alive = true;
    }

    public void Dead()
    {
        // Deactivate the player
        gameObject.SetActive(false);
    }

    void Update()
    {
        //check if you character fell off the platform
        if (transform.position.y < -10)
        {
            transform.position.y = 5.329594; 
            transform.position.x = 5.203072; 
            transform.position.z = -46.88659; 
        }
    }
}




