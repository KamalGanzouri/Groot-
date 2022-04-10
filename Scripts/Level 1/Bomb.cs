using UnityEngine;
using System.Collections;
public class Bomb : MonoBehaviour {
  private LevelManager gameLevelManager;
  // Use this for initialization
  void Start () {
    gameLevelManager = FindObjectOfType<LevelManager> ();
  }

  // Update is called once per frame
  void Update () {

  }
           void OnTriggerEnter2D(Collider2D other){
              if(other.tag == "Player"){
                    gameLevelManager.CheckLiveNumber();
                    Destroy (gameObject);
                    }
           }

}
