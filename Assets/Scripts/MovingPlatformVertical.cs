using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformVertical : MonoBehaviour
{

    public float speed = 1;

    void Update()
    {

        transform.position = new Vector3(PingPong(Time.time * speed, -50, 50), transform.position.y, transform.position.x);
    }

    float PingPong(float t, float minLength, float maxLength)
    {
        return Mathf.PingPong(t, maxLength - minLength) + minLength;
    }
}
