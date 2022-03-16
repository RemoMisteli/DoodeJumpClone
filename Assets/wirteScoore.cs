using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class wirteScoore : MonoBehaviour
{
    public GameObject player = null;
    public TextMeshProUGUI score;

    public bool highScore = false;
    public int multiplier = 10;
    public int numerOfZerosInScore = 5;

    private int newScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (highScore)
        {
            score.text = PlayerPrefs.GetInt("HighScore").ToString();
        }
        else
        {
            score.text = PlayerPrefs.GetString("score");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            newScore = Mathf.RoundToInt(player.transform.position.y * multiplier);
            score.text = PrependWithNum(newScore, 0, numerOfZerosInScore + 1);
        }

    }
    void OnDisable()
    {
        PlayerPrefs.SetString("score", PrependWithNum(newScore, 0, numerOfZerosInScore + 1));
        checkIfNewHighScore();
    }

    void checkIfNewHighScore()
    {
        int oldHighScore = 0;
        if (PlayerPrefs.HasKey("HighScore")){
       
            oldHighScore = PlayerPrefs.GetInt("HighScore"); 
        } 
       

        if (oldHighScore <= newScore)
        {
           
            PlayerPrefs.SetInt("HighScore", Mathf.RoundToInt(newScore));
        }
    }
    public static string PrependWithNum(float f, int numToInsert, int nTimes)
    {
        int positonToInsert = 0;
        if (f < 0)
        {
            positonToInsert += 1;
        }
        string str = f.ToString();
        nTimes -= str.Length;
        for (int i = 0; i < nTimes - 1; i++)
        {

            str = str.Insert(positonToInsert, numToInsert.ToString());
        }
        return str;
    }
}
