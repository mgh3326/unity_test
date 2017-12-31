﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float zRotation = transform.localEulerAngles.z;
        zRotation = zRotation - Input.GetAxis("Horizontal");
        transform.localEulerAngles = new Vector3(10, 0, zRotation);

        if(Input.touchCount>0||Input.GetMouseButton(0))//0번째가 왼쪽 마우스 버튼을 뜻함
        {
            Debug.Log("mouse down:" + Input.mousePosition);
            if(Input.mousePosition.x<Screen.width/2)
            {//왼쪽을 클릭
                transform.localEulerAngles = new Vector3(10, 0, transform.localEulerAngles.z+1.0f);

            }
            else
            {
                transform.localEulerAngles = new Vector3(10, 0, transform.localEulerAngles.z - 1.0f);
            }
        }
	}
}
