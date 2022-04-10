using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelManager1 : MonoBehaviour {
  public float respawnDelay;
  public PlayerController1 gamePlayer;
  public int coins;
  public int score;
  public int ChecksNumber;
  public int ToLiveNumber = 3;
  public Text coinText;
  public Text ScoreText;
  public Text LiveText;
  public Text ReachedText;
  private Vector3 respawnPoint;
  // Use this for initialization
  void Start () {
    gamePlayer = FindObjectOfType<PlayerController1> ();
    respawnPoint = gamePlayer.transform.position;
  }

  // Update is called once per frame
  void Update () {

  }
  public void Respawn(){
    gamePlayer.transform.position = respawnPoint;
  }

  public void AddCoins(int numberOfCoins){
    coins += numberOfCoins;
    coinText.text = coins.ToString();
  }
  public void AddCoinScore(int numberOfCoins){
      score += numberOfCoins*10;
      ScoreText.text = score.ToString();
  }
  public void AddCheckScore(int numberOfChecks){
          score += numberOfChecks;
          ScoreText.text = score.ToString();
          ChecksNumber +=1;
         ReachedText.text = ChecksNumber.ToString()+"/6";
    }
  public void AddrespawnPoint(Vector3 respawnPoint1){

            respawnPoint = respawnPoint1;
        }
  public void CheckLiveNumber(){
           if (ToLiveNumber > 0){
           ToLiveNumber -=1;
           LiveText.text = ToLiveNumber.ToString();
           Respawn();
           }
           else{
           Gameover();
        }
        }
  public void Gameover(){
        SceneManager.LoadScene("Lose");
  }
  public void Finish(){
        SceneManager.LoadScene("won");
  }
  public void CheckFinish(){
            if (ChecksNumber == 6){
                Finish();
            }
            else{
                Debug.Log("Still");
         }
  }
  }