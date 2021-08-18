using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//A simple script for attributing score points to the amount of time and distance the player has managed to survive

public class PointCalculator : MonoBehaviour
{
    public Text p1txt;

    //Ali adding 'static' for Boss Entrance code.
    public static int points = 0;

    //public bool ShipKO = false;

    public Collider cameraTriggerZone;

    //public Animator civLose;

    //public Animator susWin;

    //private void Awake()
   // {
   //    cameraTriggerZone.enabled = false;
   // }

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Civilian")
        {
            points -= 1;
            //civLose.SetBool("photolose", true);
            //Destroy(col.gameObject);
        }
        if (col.tag == "Suspect")
        {
            points += 1;
            //susWin.SetBool("photowin", true);
           //Destroy(col.gameObject);
        }
        //if (col.tag == "Bomb")
        //{
            //Debug.Log("Bomb");

           // GameObject.Find("FrogMonk P1");
          //  Destroy(gameObject);
          //  Destroy(this);

          //  GameObject.Find("FrogMonk P2");
          //  Destroy(gameObject);
         //   Destroy(this);

            //Destroy(col.gameObject);

            //GetComponent<Animator>().Play("Frog_Destroy");

            //FrogKO = true;

            //GameObject.Find("Control_Manager").GetComponent<ControlManager>().enabled = false;

            //var TM = GameObject.Find("TimeManager").GetComponent<TimeManager>();
            //if (this.gameObject.name == "FrogMonk P1") { TM.zP1Done(); TM.zP2Wins(); }
            //if (this.gameObject.name == "FrogMonk P2") { TM.zP2Done(); TM.zP1Wins(); }

        //}
    }
    void Update()
    {
        p1txt.text = ""+points+"";
    }
}