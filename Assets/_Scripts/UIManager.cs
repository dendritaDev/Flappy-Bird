using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textPoints;
    public TextMeshProUGUI textMaxScore;
    public int points = 0;

    public static UIManager sharedInstance;

    private int maxScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        sharedInstance = this;
        points = 0;

        maxScore = PlayerPrefs.GetInt("maxscore", 0);
        textMaxScore.text = "Max Score: " + maxScore.ToString(); ;
    }

    public void AddPoint()
    {
        points += 1;
        textPoints.text = points.ToString();

        if(maxScore < points)
        {
            maxScore = points;
            PlayerPrefs.SetInt("maxscore", points);
            textMaxScore.text = "Max Score: " + maxScore.ToString(); ;
        }
    }

}
