using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance; // g�r s� att man kan n� det h�r scriptet fr�n andra skript

    public Text highScoreText; // Highscore texten 
    public Text scoreText; // po�ng texten

    int score = 0; // po�ng v�rdet �r 0 vis start
    int highscore = 0; // highscore v�rdet �r 0 vid start

    private void Awake() 
    {
        instance = this; 
    }


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "score:" + score.ToString(); //Vid start �ndras score texten till score: 0
        highScoreText.text = "HIGHSCORE:" + highscore.ToString();//Vid start �ndras highscore texten till highscore: 0
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Addpoint() // n�r den h�r metoden spelas s� �kar po�ngen med 1 och �ndrar po�ng texten s� att den visar samma po�ng
    {
        score += 1;
        scoreText.text = "score:" + score.ToString();
    }

   
}
