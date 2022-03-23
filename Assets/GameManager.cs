using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject jumpPad;
    public GameObject coins;
    public Camera camera;
    public int platformCount = 30;
    public int coinsCount = 2;
    public int genertCoinsRarity=10;

    private Vector3 spawnPositionPlatform = new Vector3();
    private Vector3 spawnPosition = new Vector3();


    void Start()
    {
        createPlatforms(platformCount);

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Random.Range(1, (int)(1.0/Time.deltaTime)*genertCoinsRarity) == 1)
        {
                   createCoins(1);

        }
    }
    public void createCoins(int count)
    {
        for (int i = 0; i < count; i++)
        {

            coinCreate(coins);

        }
    }
    public void createPlatforms(int count)
    {

        for (int i = 0; i < count; i++)
        {

            create(randomizePlatform());

        }
    }

    void create(GameObject obj)
    {
        float aspect = (float)Screen.width / Screen.height;

        float worldHeight = camera.orthographicSize * 2;

        float worldWidth = worldHeight * aspect;

        float cameraLocation = camera.transform.position.x;

        spawnPositionPlatform.y += Random.Range(.5f, 2f);
        spawnPositionPlatform.x = Random.Range(-(worldWidth / 2) + cameraLocation, worldWidth / 2 + cameraLocation);

        Instantiate(obj, spawnPositionPlatform, Quaternion.identity);
    }

    void coinCreate(GameObject obj)
    {

        float aspect = (float)Screen.width / Screen.height;

        float worldHeight = camera.orthographicSize * 2;

        float worldWidth = worldHeight * aspect;

        float cameraLocation = camera.transform.position.x;
        
        spawnPosition=spawnPositionPlatform;
        spawnPosition.y += Random.Range(.5f, 2f);
        spawnPosition.x = Random.Range(-(worldWidth / 2) + cameraLocation, worldWidth / 2 + cameraLocation);

        Instantiate(obj, spawnPosition, Quaternion.identity);
    }
    private GameObject randomizePlatform()
    {

        if (Random.Range(1, 100) < 10)
        {
            return jumpPad;
        }

        return platformPrefab;
    }
}
