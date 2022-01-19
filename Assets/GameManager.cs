using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject jumpPad;
    public Camera camera;
    public int platformCount = 30;
    
     private Vector3 spawnPosition = new Vector3();

    void Start()
    {
       createPlatforms(platformCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void createPlatforms(int count){

       
        for(int i =0; i < count; i++)
        {
            
   
            float aspect = (float)Screen.width / Screen.height;
            
            float worldHeight = camera.orthographicSize * 2;
            
            float worldWidth = worldHeight * aspect;

            float cameraLocation= camera.transform.position.x;
    
            spawnPosition.y += Random.Range(.5f, 2f);
            spawnPosition.x = Random.Range(-(worldWidth/2)+cameraLocation, worldWidth/2+cameraLocation);

            Instantiate(randomizePlatform(), spawnPosition, Quaternion.identity);

        }
    }

    private GameObject randomizePlatform(){

        if(Random.Range(1,100)<10){
            return jumpPad;
        }

        return platformPrefab;
    }
}
