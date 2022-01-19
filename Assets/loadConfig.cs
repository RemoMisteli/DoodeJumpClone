using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadConfig : MonoBehaviour
{
        public Material defaultSkyBox;

        public Material skbox0;
        public Material skbox1;
        public Material skbox2;
        public Material skbox3;

        private Material setSkybox;
    void Start()
    {

         int  skyBox=PlayerPrefs.GetInt("skBox");
        
             switch(skyBox){
                    case 0: setSkybox=skbox0;break;
                    case 1: setSkybox=skbox1;break;
                    case 2: setSkybox=skbox2;break;
                    case 3: setSkybox=skbox3;break;
             }
        
        RenderSettings.skybox=setSkybox;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
