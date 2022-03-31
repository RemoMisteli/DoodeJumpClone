using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class writeCoinCount : MonoBehaviour
{
    // Start is called before the first frame update
        public TextMeshProUGUI textField;

    void Start()
    {
        textField.text = PlayerPrefs.GetInt("coinCount").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
