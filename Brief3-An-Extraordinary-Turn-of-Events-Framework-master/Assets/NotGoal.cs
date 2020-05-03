using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotGoal : MonoBehaviour
{

    public Transform Ball;
    public float distance = 1;
    public GameManager gm;

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(Ball.position, transform.position) < distance)
        {
           
        }
    }
}
