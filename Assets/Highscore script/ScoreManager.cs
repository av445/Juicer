using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance; // gör så att man kan nå det här scriptet från andra skript - Thea

    public Text highScoreText; // Highscore texten 
    public Text scoreText; // poäng texten

    int score = 0; // poäng värdet är 0 vis start
    int highscore = 0; // highscore värdet är 0 vid start

    private void Awake() 
    {
        instance = this; 
    }


    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0); // skriver ut spelarens sparade score i highscore - Thea
        scoreText.text = "score:" + score.ToString(); //Vid start ändras score texten till score: 0
        highScoreText.text = "HIGHSCORE:" + highscore.ToString();//Vid start ändras highscore texten till highscore: 0
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Addpoint() // när den här metoden spelas så ökar poängen med 1 och ändrar poäng texten så att den visar samma poäng - Thea
    {
        score += 1;
        scoreText.text = "score:" + score.ToString();
        if(highscore < score) // om higscore är mindre än spelarens score sparas scoren och highscore ändras till spelarens score
        PlayerPrefs.SetInt("highscore", score);
    }

   
}
