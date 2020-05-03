using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotGoal : MonoBehaviour
{
    public Transform Ball;
    public ChangeScene changeScene;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(transform.position, Ball.position));
        if (Vector3.Distance(transform.position, Ball.position) < 1)
        {
            Debug.Log("gotcha");
            changeScene.mainScene.Invoke();
        }
    }
}
