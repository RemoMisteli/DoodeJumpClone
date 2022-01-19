using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
  public string sceneToLoad="game";
        public void loadScene(){
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        SceneManager.LoadScene(sceneToLoad);
   }

}
