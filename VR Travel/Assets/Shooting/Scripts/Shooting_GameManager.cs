using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting_GameManager : MonoBehaviour
{
    public static float gameScore = 0.0f;

    public static float gameTime = 60.0f;
    private int scoreboardTime;

    public static bool runOnce = false;
    public static bool startGame = false;

    //Boards
    public GameObject StartQuitHolder;
    public GameObject GamePlayHolder;
    public GameObject GameOverHolder;
    public GameObject FinalScoreBanner;
    public GameObject MagazineUI;

    public GameObject bullet1;
    public GameObject bullet2;
    public GameObject bullet3;
    public GameObject bullet4;
    public GameObject bullet5;
    public GameObject bullet6;
    public GameObject bullet7;
    public GameObject bullet8;

    public Text scoreText;
    public Text timeText;
    public Text finalScore;

    public Magazine magazine;

    void Update()
    {
        if (startGame)
        {
            if (!runOnce) 
            { 
                magazine.numberOfBullets = 8;
                runOnce = true;
            }

            MagazineUI.SetActive(true);

            gameTime -= Time.deltaTime;
            scoreboardTime = (int)(gameTime % 60);

            scoreText.text = "" + gameScore + "";
            timeText.text = "" + scoreboardTime + "";
            finalScore.text = "" + gameScore + "";

                switch (magazine.numberOfBullets)
                {
                case 8:
                    bullet8.SetActive(true);
                    bullet7.SetActive(true);
                    bullet6.SetActive(true);
                    bullet5.SetActive(true);
                    bullet4.SetActive(true);
                    bullet3.SetActive(true);
                    bullet2.SetActive(true);
                    bullet1.SetActive(true);
                    break;
                case 7:
                    bullet8.SetActive(false);
                    break;
                case 6:
                    bullet7.SetActive(false);
                    break;
                case 5:
                    bullet6.SetActive(false);
                    break;
                case 4:
                    bullet5.SetActive(false);
                    break;
                case 3:
                    bullet4.SetActive(false);
                    break;
                case 2:
                    bullet3.SetActive(false);
                    break;
                case 1:
                    bullet2.SetActive(false);
                    break;
                case 0:
                    bullet1.SetActive(false);
                    break;
                default:
                    break;
                }

            if (gameTime < 30.0f && gameTime > 11.0f)
            {
                timeText.color = new Color(1,0.92f,0.016f,1) ;
            }
            else if (gameTime < 11.0f && gameTime > 0.1f)
            {
                timeText.color = new Color(1, 0, 0, 1);

            }
            else if (gameTime <= 0.0f)
            {
                timeText.color = new Color(1, 1, 1, 1);
                startGame = false;
                GamePlayHolder.SetActive(false);
                GameOverHolder.SetActive(true);
                MagazineUI.SetActive(false);
            }
        }
    }
}
