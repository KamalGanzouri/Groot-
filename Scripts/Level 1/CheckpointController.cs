using UnityEngine;
using System.Collections;
public class CheckpointController : MonoBehaviour {
  private LevelManager gameLevelManager;
  public int CheckValue;
  private Vector3 respawnPoint;
  // Use this for initialization
  void Start () {
    gameLevelManager = FindObjectOfType<LevelManager> ();
  }

  // Update is called once per frame
  void Update () {

  }
  void OnTriggerEnter2D(Collider2D other){
    if(other.tag == "Player"){
      respawnPoint = gameObject.transform.position;
      gameLevelManager.AddCheckScore(CheckValue);
      gameLevelManager.AddrespawnPoint(respawnPoint);
      Destroy (gameObject);
    }
  }
}
