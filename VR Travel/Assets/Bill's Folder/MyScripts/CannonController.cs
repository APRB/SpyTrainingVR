using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CannonController : MonoBehaviour
{
   public float rotationSpeed = 1;
  // public float blastPower = 5;
   public float reloadTime;
   [SerializeField]
   private float shootTimer;

   public GameObject cannonball;
   public Transform shotPoint;
   public Transform barrel;
    private float angleForSetting;

   public float playerHeight = 1f; //assuming
    public float blastPower;

   public GameObject explosion;

   public EnemyController enemyController;
   public NavMeshAgent agent;
   public float navMeshStopRadiusMIN = 9;
   public float navMeshStopRadiusMAX = 15;
[SerializeField]
   private bool isAlive = true;
   private AudioSource audioSource;

   
  
   void Start()
   {
       isAlive = true;
       shootTimer = reloadTime;
       audioSource = GetComponent<AudioSource>();
   }

   private void Update()
   {
       SetBarrelAngle();
      CalculateBlastPower();
     if(enemyController.distance < agent.stoppingDistance + 0.5f)
     {
         shootTimer -= 1f * Time.deltaTime;

         if(shootTimer <0 && isAlive && enemyController.isHit == false)
         {
              //Debug.Log("shoot");
              audioSource.Play();
              GameObject createCannonBall = Instantiate(cannonball, shotPoint.position, shotPoint.rotation);
              createCannonBall.GetComponent<Rigidbody>().velocity = shotPoint.transform.up * blastPower;
              shootTimer = reloadTime;

                if(explosion != null)
                {
                     Destroy(Instantiate(explosion, shotPoint.position, transform.rotation), 2);
                }
                Invoke("SetRandomStopDistance", 1f);
                Invoke("CanMoveSideways", 1f);
                
                enemyController.fuctionIsCalled = false; //for resetting a randomised value to decide move left or right
                //Screenshake.shakeAmount = 5;
            }
     }

   }
    public void CalculateBlastPower()
    {
        //Inputs
        float distance = enemyController.distance; //9 - 18
        float time = 2f; //fixed
        float gravity = Physics.gravity.y; //is fixed

        //calculation
        
        float initialHorizontalVelocity = distance / time;
        float initialVerticalVelocity = distance / initialHorizontalVelocity / 2 * gravity;
       
        //Initial Velocity
        blastPower =   Mathf.Sqrt(initialHorizontalVelocity * initialHorizontalVelocity + initialVerticalVelocity * initialVerticalVelocity);
        angleForSetting = Mathf.Asin((distance / (blastPower * blastPower)) * gravity) / 2; // = Mathf.Abs(barrel.transform.rotation.x) + 15;
       // Debug.Log("blast power:"+ blastPower + "angle:" + (barrel.transform.rotation.x - 15) +"Y velocity:"+ initialVerticalVelocity);
    }
    void SetBarrelAngle()
    {
        Mathf.Lerp(Mathf.Abs(barrel.transform.rotation.x) - 15, angleForSetting, 1* Time.deltaTime);
    }
    public void SetRandomStopDistance()
    {
       float randomRange = Random.Range(navMeshStopRadiusMIN, navMeshStopRadiusMAX);
       agent.stoppingDistance = randomRange;
    }
    public void CanMoveSideways()
    {
       enemyController.canMoveSideways = true;
    }
}
