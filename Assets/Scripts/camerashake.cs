using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerashake : MonoBehaviour
{
    public IEnumerator Shake (float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;
        // först skapade jag en variabel som sparar camerans position
        float elapsed = 0.0f;

        while (elapsed < duration)
        // här skapar jag en while loop som kollar att tidennsom gått är mindre än längen av camershake
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;
        // jag ger ett random y och ett random x värde för kameran multiplicerat med magnituden
            transform.localPosition = new Vector3(x, y, originalPos.z);
        
            elapsed += Time.deltaTime;
        // jag kollar hur lång tid som gått och lägger till 1 varje sekund
            yield return null;
        }

        transform.localPosition = originalPos;
    }// till slut så tar jag tillbaka cameran till orginal positionen
}
