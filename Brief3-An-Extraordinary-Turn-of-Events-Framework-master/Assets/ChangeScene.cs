using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public UnityEvent titleScene;
    public UnityEvent mainScene;
    
    public void changeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
   
}
