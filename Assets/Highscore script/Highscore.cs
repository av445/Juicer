using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public int playerScore; // spelarens poäng

    [SerializeField]
    private Text scoreDisplay; // poäng texten


    // Start is called before the first frame update
    void Start()
    { // poängen är 0 vid start
        scoreDisplay.text = "score:" + 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
