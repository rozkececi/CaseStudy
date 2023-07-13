using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None; // Farenin imlecinin serbest b�rak�l�r.
    }
    public void OyunuBa�lat()
    {
        SceneManager.LoadScene(1); // �kinci sahneyi y�kler ve oyuna ba�lar.
    }

    public void OyunuKapat()
    {
        Application.Quit(); // Oyunu kapat�r.
    }
}

