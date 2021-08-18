using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour
{
    public GameObject GameOverHolder;
    public GameObject GamePlayHolder;
    public GameObject MagazineUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Shooting_GameManager.startGame = true;
            GameOverHolder.SetActive(false);
            GamePlayHolder.SetActive(true);
            MagazineUI.SetActive(true);
            Shooting_GameManager.runOnce = false;
            Shooting_GameManager.gameTime = 60.0f;
            Shooting_GameManager.gameScore = 0.0f;
        }
    }
}
