using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTimeM : MonoBehaviour
{
    public static float Scorevalue ;
    public Text ScoreTExt;
    public Text HighScoreText;
    int highScore;
    Text Scoretext;
    // Start is called before the first frame update
    void Start()
    {
        Scoretext = GetComponent<Text>();
     
       
    }

    // Update is called once per frame
    void Update()
    {
        Scoretext.text = "Score:  " + Scorevalue;
        Scorevalue = Scorevalue + Time.deltaTime;

       
    }
}
