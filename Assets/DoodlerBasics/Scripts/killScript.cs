using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class killScript : MonoBehaviour
{

    public GameObject player;
    
    public GameManager gameManager;

    public string dathScene="DeathScene";
    private void OnCollisionEnter2D(Collision2D other)
    {
      if(other.gameObject==player){
          kill();
        }else{
            gameManager.createPlatforms(1);
            Destroy(other.gameObject);
       
        }
    }
    public void kill()
    {
                SceneManager.LoadScene(dathScene);

    }   




  

}
