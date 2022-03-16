using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class killScript : MonoBehaviour
{

    public GameObject player;

    public GameObject platform;
    
    public GameManager gameManager;

    public float propForCoinProzent =10; 
    public string dathScene="DeathScene";
    private void OnCollisionEnter2D(Collision2D other)
    {
      if(other.gameObject==player){
          kill();
        }else{
            
            gameManager.createPlatforms(1);
            Destroy(other.gameObject);
            if(Random.Range(0,100)<=propForCoinProzent){
                 gameManager.createCoins(1);
            }
        }
    }
    public void kill()
    {
                SceneManager.LoadScene(dathScene);

    }   




  

}
