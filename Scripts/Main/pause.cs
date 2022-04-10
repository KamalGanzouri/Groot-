using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    // Start is called before the first frame update
        public static bool GameIsPause;
    public GameObject PauseMenuUI;

    // Update is called once per frame

      void Start () {
        PauseMenuUI.SetActive(false);
      }
      void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if (GameIsPause){
                       PauseMenuUI.SetActive(false);
                       Time.timeScale = 1f;
                       GameIsPause = false;
            }else{
                        PauseMenuUI.SetActive(true);
                        Time.timeScale = 0f;
                        GameIsPause = true;
            }
        }
    }
    public void Restart() {
    Application.Quit();
    }
    public void quit() {
    Time.timeScale = 1f;
    SceneManager.LoadScene("menu");
    }

}
