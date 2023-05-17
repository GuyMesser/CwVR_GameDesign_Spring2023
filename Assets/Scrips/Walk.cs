using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public Transform Player;
    int MoveSpeed = 3;
    int MaxDist = 10;
    int MinDist = 2;

    void FixedUpdate()
    {
            transform.LookAt(Player);
    }


    void Start()
    {

    }

    void Update()
    {

        
    }
}