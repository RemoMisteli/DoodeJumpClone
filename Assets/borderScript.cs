using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borderScript : MonoBehaviour
{
    public GameObject border;
    public Camera camera;



    void Start()
    {


        Vector3 spawnPosition = new Vector3();
        float aspect = (float)Screen.width / Screen.height;

        float worldHeight = camera.orthographicSize * 2;

        float worldWidth = worldHeight * aspect;

        





            spawnPosition.x = worldWidth/2;

           GameObject rightBorder= Instantiate(border, spawnPosition, Quaternion.identity);


            spawnPosition.x = -worldWidth/2;

           GameObject leftBorder= Instantiate(border, spawnPosition, Quaternion.identity);
            
            //set Camera as parent so the will floting up
            rightBorder.transform.SetParent(camera.transform);
            leftBorder.transform.SetParent(camera.transform);

            PlatformEffector2D right = rightBorder.gameObject.GetComponent<PlatformEffector2D>();
            PlatformEffector2D left = leftBorder.gameObject.GetComponent<PlatformEffector2D>();

                right.rotationalOffset=90;
                left.rotationalOffset=-90;




        }

        // Update is called once per frame
        void Update()
        {

        }
    }
