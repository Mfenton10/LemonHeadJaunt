using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PathwayScoring : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public GameObject Pathway;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        ScoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EarnScore()
    {
        score++;
        ScoreText.text = "Score: " + score;
    }
}
