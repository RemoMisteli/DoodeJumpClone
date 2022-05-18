using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class buySkin : MonoBehaviour
{

    public int skinId=0;
    public int price=10;
    public bool owend=false;
    // Start is called before the first frame update

public GameObject thisobject;

    void Start()
    {
        if(PlayerPrefs.GetInt("boughtSkinId"+skinId)==1){
            owend=true;
        }
        if(!owend){
            thisobject.GetComponentInChildren<Text>().text= price+"$";
        }else{
             thisobject.GetComponentInChildren<Text>().text= "select";

        }

        if(PlayerPrefs.GetInt("skinId")==skinId){
        thisobject.GetComponentInChildren<Text>().text= "selected";
        }



    }
    public void selectSkin(){
        if(owend){
        PlayerPrefs.SetInt("skinId",skinId);
        thisobject.GetComponentInChildren<Text>().text= "selected";

        }else{
            buy();
        }
    }

        private void buy(){

           int coins= PlayerPrefs.GetInt("coinCount");
           if(coins-price>=0){
            PlayerPrefs.SetInt("coinCount",coins-price);
            PlayerPrefs.SetInt("boughtSkinId"+skinId,1);
            thisobject.GetComponentInChildren<Text>().text= "select";

           }
    }

}
