﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Vector3 direction = transform.position - collision.gameObject.transform.position;
        direction = direction.normalized * 1000;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(direction);
    }
    float delta = 0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float newXposition = transform.localPosition.x + delta;
        transform.localPosition = new Vector3(newXposition, transform.localPosition.y, transform.localPosition.z);
        if (transform.localPosition.x < -3.5)
        {
            delta = 0.1f;
        }
        else if (transform.localPosition.x > 3.5)
        {
            delta = -0.1f;
        }
    }
}
