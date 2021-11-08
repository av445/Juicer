using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlayer : MonoBehaviour
{
    public static AudioClip playershoot, playerhurt, enemyshoot, explotion;
    static AudioSource Audiosrc;
    void Start()
    {
        
        playerhurt = Resources.Load<AudioClip>("playerhurt");
        enemyshoot = Resources.Load<AudioClip>("enemyshoot");
        explotion = Resources.Load<AudioClip>("explotion");

        Audiosrc = GetComponent<AudioSource>();

    }

    public static void PlaySound(string clip)
    {
        
        switch (clip)
        {
            case "playerhurt":
                Audiosrc.PlayOneShot(playerhurt);
                break;
        }
        switch (clip)
        {
            case "enemyshoot":
                Audiosrc.PlayOneShot(enemyshoot);
                break;
        }
        switch (clip)
        {
            case "explotion":
                Audiosrc.PlayOneShot(explotion);
                break;
        }

    }
}
