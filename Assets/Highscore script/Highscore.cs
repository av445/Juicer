using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public int playerScore; // spelarens po�ng

    [SerializeField]
    private Text scoreDisplay; // po�ng texten


    // Start is called before the first frame update
    void Start()
    { // po�ngen �r 0 vid start
        scoreDisplay.text = "score:" + 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
