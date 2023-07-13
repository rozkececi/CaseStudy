using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] public GameObject PauseMenuPanel;

    public void Pause()
    {
        PauseMenuPanel.SetActive(true); // Duraklatma men�s� paneli aktif hale getirilir.
        Time.timeScale = 0f; // Oyun zaman� s�f�r olarak ayarlan�r ve oyun durur.
    }

    public void Resume()
    {
        PauseMenuPanel.SetActive(false); // Duraklatma men�s� paneli devre d��� b�rak�l�r.
        Time.timeScale = 1f; // Oyun zaman� bir olarak ayarlan�r ve oyun devam eder.
    }


    public void Restart()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("SampleScene"); // "SampleScene" sahnesini yeniden y�kler, oyuna ba�tan ba�lar.
    }
}

   

