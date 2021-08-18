using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeValue = 60;
	public Text timerText;
	private float timeLeft = 60.0f;
	public static bool timeStop= false;

    // Update is called once per frame
    void Update()
    {
		if(!timeStop)
		{
			if (timeValue > 0)
			{
				timeValue -= Time.deltaTime;
			}
			else
			{
				
				timeValue = 0;
			}
		}
		
		DisplayTime(timeValue);
		
		timeLeft -= Time.deltaTime;
		if (timeLeft <= 0)
			GameOver();
	
    }
	
	void GameOver()
	{
		Debug.Log("You died");
		Application.Quit();
	}
	
	void DisplayTime(float timeToDisplay)
	{
		if(timeToDisplay < 0)
		{
			timeToDisplay = 0;
		}
		
		float minutes = Mathf.FloorToInt(timeToDisplay / 60);
		float seconds = Mathf.FloorToInt(timeToDisplay % 60);
		
		timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
	}
}
