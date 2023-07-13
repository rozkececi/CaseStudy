using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownController : MonoBehaviour
{
   
    public float countdownDuration = 3f; // Geri say�m s�resi 
    public Text countdownText; // Geri say�m� g�steren metin 

    private float currentTime;

    private void Start()
    {
        currentTime = countdownDuration;
        StartCoroutine(StartCountdown());
    }

    private System.Collections.IEnumerator StartCountdown()
    {
        while (currentTime > 0)
        {
            UpdateCountdownText();
            yield return new WaitForSeconds(1f);
            currentTime--;
        }

        // Geri say�m tamamland���nda yap�lacaklar
        countdownText.text = "GO!"; // Geri say�m bitti�inde metni g�ncelle
        yield return new WaitForSeconds(1f); // "Ba�la!" metnini bir saniye g�ster

        countdownText.enabled = false; // Metni ekrandan kald�r
        // Oyuna ba�lamak i�in gerekli di�er i�lemleri buraya ekleyebilirsiniz
    }

    private void UpdateCountdownText()
    {
        countdownText.text = currentTime.ToString(); // Geri say�m metnini g�ncelle
    }
}
