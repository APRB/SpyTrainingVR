using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public GameObject StartQuitHolder;
    public GameObject GamePlayHolder;
    public GameObject MagazineUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Shooting_GameManager.startGame = true;
            StartQuitHolder.SetActive(false);
            GamePlayHolder.SetActive(true);
            MagazineUI.SetActive(true);
        }
    }
}



