using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wonScript1 : MonoBehaviour
{
    public void Play(){
    SceneManager.LoadScene("Level2");
    }
    public void Quit(){
    Application.Quit();
    }
}
