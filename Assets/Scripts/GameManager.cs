﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void GameRestart()
    {
        SceneManager.LoadScene("Gameplay");
        Time.timeScale = 1;
    }
}
