using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class isNewHigscore : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject newHsLabel; 
        public TextMeshProUGUI score;
    public TextMeshProUGUI hs;
     

    void Start()
    {
        newHsLabel.SetActive(false);
        int oldHighScore = int.Parse(hs.text);
        int newScore =  int.Parse(score.text);

       
        Debug.Log($"old: {oldHighScore}");
        Debug.Log($"new: {newScore}");

        if (oldHighScore <= newScore)
        {
            Debug.Log($"new:sdfasfd {newScore}");
                    newHsLabel.SetActive(true);

        }
    }

    // Update is called once per frame
    void Update()
    {
newHsLabel.SetActive(false);
    }
}
