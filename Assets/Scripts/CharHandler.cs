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

}

