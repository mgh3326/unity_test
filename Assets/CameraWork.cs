using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWork : MonoBehaviour
{
    GameObject ball;
    // Use this for initialization
    void Start()
    {
        ball = GameObject.Find("Ball");
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");

        //Debug.Log(coins[0].name);
        //Debug.Log(coins[5].name);
        for (int i = 0; i < coins.Length; i++)
        {
            Debug.Log(coins[i].name);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("I am Camera. And ball is at " + ball.transform.position.z);
        transform.position = new Vector3(0, ball.transform.position.y + 3, ball.transform.position.z - 14);
    }
}
