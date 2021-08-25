using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A simple script for calling a trigger zone when the Player Frog unleashes its tongue and for destroying a colliding object.

public class CameraTrigger : MonoBehaviour
{
	public Animator _animcam;

	//public bool triedToCatch = false;

	//public bool IcaughtFly = false;

	public Collider camTriggerZone;

	//private AudioSource _camsound;

	//public AudioSource audiodata;
	//public AudioClip frogTongue;
	//public AudioClip frogCatch;
	//public AudioClip frogBoom;

	//private AudioSource _frogsound;


	private void Awake()
	{
		camTriggerZone.enabled = false;
		//camTriggerZone.enabled = false;

		//_animcam = this.GetComponent<Animator>();
		//camTriggerZone = this.GetComponent<BoxCollider>();

		//camTriggerZone.enabled = false;
		//_frogsound = this.GetComponent<AudioSource>();
	}

	public void FixedUpdate()
	{ 
		if (!_animcam.GetCurrentAnimatorStateInfo(0).IsName("camera_idle"))
		{
			camTriggerZone.enabled = false;
		}
	}
	
	public void zSnap()
	{
	   //_animcam.Play("Camera_reticle");
	   if (!_animcam.GetCurrentAnimatorStateInfo(0).IsName("Camera_reticle"))
        {
			camTriggerZone.enabled = true;
			//AudioSource.PlayClipAtPoint(this.GetComponent<AudioSource>().clip, Camera.main.transform.position);
		}

	//audiodata.clip = frogTongue;
	//audiodata.Play()
	}


	//private void OnTriggerStay2D(Collider2D collision)
	//{
	//Debug.Log("WAH");

	//	if (_anim.GetCurrentAnimatorStateInfo(0).IsName("Frog_Tongue"))
	//	{
	//		CatchFly(collision.gameObject);
	//	}

	//	if (_anim.GetCurrentAnimatorStateInfo(0).IsName("Frog_Tongue"))
	//	{
	//		CatchFly(collision.gameObject);
	//	}
	//	}

	//public void OnTriggerEnter(Collider col)
	//{
		//if (col.tag == "Player")
	//	{
	//		_anim.SetBool("photoshot", true);
	//	}
		//_anim.SetBool("Caught", true);
		//IcaughtFly = true;
		//Destroy(_collision);
		//audiodata.clip = frogCatch;
		//audiodata.Play();
		//AudioSource.PlayClipAtPoint(this.GetComponent<AudioSource>().clip, Camera.main.transform.position);


		//var TM = GameObject.Find("TimeManager").GetComponent<TimeManager>();
		//if (this.gameObject.name == "FrogMonk P1") { TM.zP1Done(); }
		//if (this.gameObject.name == "FrogMonk P2") { TM.zP2Done(); }
	//}
}
