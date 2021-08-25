using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireManager : MonoBehaviour
{
    public CutWire BlueWire;
	public CutWire RedWire;
	public CutWire YellowWire;
	public CutWire GreenWire;
	public CutWire OrangeWire;
	public CutWire PurpleWire;
	
	private int correctWire;
	
	void Start()
	{
		correctWire = Random.Range(0, 6);
		
	}

    // Update is called once per frame
    void Update()
    {
        CheckWire();
    }
	
	private void CheckWire()
	{
		if(correctWire == 0)
		{
		Debug.Log("blueWire:" + correctWire);
			//if correct
			if(BlueWire.isCut)
			{
				Timer.timeStop = true;
				Debug.Log("blue cut");
			}
			//if incorrect
			if(RedWire.isCut)
			{
			
			}
			//if incorrect
			if(YellowWire.isCut)
			{
			
			}
			//if incorrect
			if(GreenWire.isCut)
			{
			
			}
			//if incorrect
			if(OrangeWire.isCut)
			{
			
			}
			//if incorrect
			if(PurpleWire.isCut)
			{
			
			}
		}
		if(correctWire == 1)
		{
		Debug.Log("redWire:" + correctWire);
			//if correct
			if(RedWire.isCut)
			{
				Timer.timeStop = true;
				Debug.Log("red cut");
			}
			//if incorrect
			if(BlueWire.isCut)
			{
			
			}
			//if incorrect
			if(YellowWire.isCut)
			{
			
			}
			//if incorrect
			if(GreenWire.isCut)
			{
			
			}
			//if incorrect
			if(OrangeWire.isCut)
			{
			
			}
			//if incorrect
			if(PurpleWire.isCut)
			{
			
			}
		}
		if(correctWire == 2)
		{
		Debug.Log("yellowWire:" + correctWire);
			//if correct
			if(YellowWire.isCut)
			{
				Timer.timeStop = true;
				Debug.Log("red cut");
			}
			//if incorrect
			if(BlueWire.isCut)
			{
			
			}
			//if incorrect
			if(RedWire.isCut)
			{
			
			}
			//if incorrect
			if(GreenWire.isCut)
			{
			
			}
			//if incorrect
			if(OrangeWire.isCut)
			{
			
			}
			//if incorrect
			if(PurpleWire.isCut)
			{
			
			}
		}
		if(correctWire == 3)
		{
		Debug.Log("greenWire:" + correctWire);
			//if correct
			if(GreenWire.isCut)
			{
				Timer.timeStop = true;
				Debug.Log("red cut");
			}
			//if incorrect
			if(BlueWire.isCut)
			{
			
			}
			//if incorrect
			if(RedWire.isCut)
			{
			
			}
			//if incorrect
			if(YellowWire.isCut)
			{
			
			}
			//if incorrect
			if(OrangeWire.isCut)
			{
			
			}
			//if incorrect
			if(PurpleWire.isCut)
			{
			
			}
		}
		if(correctWire == 4)
		{
		Debug.Log("orangeWire:" + correctWire);
			//if correct
			if(OrangeWire.isCut)
			{
				Timer.timeStop = true;
				Debug.Log("red cut");
			}
			//if incorrect
			if(BlueWire.isCut)
			{
			
			}
			//if incorrect
			if(RedWire.isCut)
			{
			
			}
			//if incorrect
			if(YellowWire.isCut)
			{
			
			}
			//if incorrect
			if(GreenWire.isCut)
			{
			
			}
			//if incorrect
			if(PurpleWire.isCut)
			{
			
			}
		}
		if(correctWire == 5)
		{
		Debug.Log("purpleWire:" + correctWire);
			//if correct
			if(PurpleWire.isCut)
			{
				Timer.timeStop = true;
				Debug.Log("red cut");
			}
			//if incorrect
			if(BlueWire.isCut)
			{
			
			}
			//if incorrect
			if(RedWire.isCut)
			{
			
			}
			//if incorrect
			if(YellowWire.isCut)
			{
			
			}
			//if incorrect
			if(GreenWire.isCut)
			{
			
			}
			//if incorrect
			if(OrangeWire.isCut)
			{
			
			}
		}
	}
}
