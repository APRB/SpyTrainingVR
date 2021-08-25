using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutWire : MonoBehaviour
{
    public GameObject Wire;
	public GameObject BrokenWire;
	
	public bool isCut = false;
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Pliers"))
		{
			Wire.SetActive(false);
			BrokenWire.SetActive(true);
			//Timer.timeStop = true;
			isCut = true;
		}
	}
}
