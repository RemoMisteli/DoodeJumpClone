using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toggleSkbox : MonoBehaviour
{
    public int nbSkboxes=4;
    public void toggle(){
         int  skyBox=PlayerPrefs.GetInt("skBox");

       skyBox+=1;
       if(skyBox>nbSkboxes-1){
           skyBox=0;
       }

       PlayerPrefs.SetInt("skBox",skyBox);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
