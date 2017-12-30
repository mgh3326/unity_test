using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //int count = 1;
    float startingPoint;
    SphereCollider myCollider;
    bool shouldPrintOver20 = true;
    bool shouldPrintOver30 = true;
    // Use this for initialization
    void Start()
    {
        myCollider = GetComponent<SphereCollider>();
        Debug.Log("Start");
        startingPoint = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //myCollider.radius += 0.01f;
        float distance;
        distance = transform.position.z - startingPoint;
        //Debug.Log(distance);
        if(Input.GetKeyDown(KeyCode.Space))//누르눈 순간
            //GetKeyUp//떼는 순간
            //GetKey //눌릴때
        {
            //Debug.Log("Space를 눌렀습니다.");
            GetComponent<Rigidbody>().AddForce(Vector3.up*300);
        }
       


    }
}
