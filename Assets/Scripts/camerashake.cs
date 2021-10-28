using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerashake : MonoBehaviour
{
    public IEnumerator Shake (float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;
        // f�rst skapade jag en variabel som sparar camerans position
        float elapsed = 0.0f;

        while (elapsed < duration)
        // h�r skapar jag en while loop som kollar att tidennsom g�tt �r mindre �n l�ngen av camershake
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;
        // jag ger ett random y och ett random x v�rde f�r kameran multiplicerat med magnituden
            transform.localPosition = new Vector3(x, y, originalPos.z);
        
            elapsed += Time.deltaTime;
        // jag kollar hur l�ng tid som g�tt och l�gger till 1 varje sekund
            yield return null;
        }

        transform.localPosition = originalPos;
    }// till slut s� tar jag tillbaka cameran till orginal positionen
}
