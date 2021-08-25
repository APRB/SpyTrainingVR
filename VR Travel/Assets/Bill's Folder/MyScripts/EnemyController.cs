
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius;
    public GameObject target;
    public GameObject backwardsDirection;
    NavMeshAgent agent;
    public float strafeSpeed;
    public float speed;
    public bool moveRight;
    public bool fuctionIsCalled;

   public bool canMoveSideways = false; // needs to be public
   public float distance; //needs to be public, since it's being acessed by cannon, maybe i can use protected
   public Vector3 horizontalDisplacement;

    public bool isHit = false;
    public GameObject explosion;

    public float despawnTime = 10f;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindWithTag("Player");
    }

   public void Update()
    {
        distance = Vector3.Distance(target.transform.position, transform.position);
        horizontalDisplacement = transform.position - target.transform.position; 
        transform.LookAt(target.transform);
        //AI movement
        if(!isHit)
      {

            if(distance <= lookRadius) //AI going Forwards
        {
            if(distance > agent.stoppingDistance)
            {
                agent.SetDestination(target.transform.position);
            }
            if(distance < agent.stoppingDistance) //AI going backwards
            {
                Vector3 direction =  transform.position - target.transform.position; //AI direction to player
                Vector3 newDirection = direction + transform.position;
                transform.position = Vector3.MoveTowards(transform.position, newDirection, speed * Time.deltaTime);
            }
            if(canMoveSideways)
            {
                //Vector3 localRight = transform.worldToLocalMatrix.MultiplyVector(transform.right);

                if(fuctionIsCalled == false)
                {
                    fuctionIsCalled = true;
                    RandomBool();
                }
               

                if (moveRight)
                {
                    transform.Translate(Vector3.right * strafeSpeed * Time.deltaTime);
                    Invoke("CanNolongerMove", 1.3f);
                }
                if(!moveRight)
                {
                    transform.Translate(Vector3.right * -strafeSpeed * Time.deltaTime);
                    Invoke("CanNolongerMove", 1.3f);
                }
               // Debug.Log(pickSide);
            }
        }
        
      }

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
    private void CanNolongerMove()
    {
        canMoveSideways = false;
    }
    private void RandomBool()
    {
        float pickSide = Random.value;
        if(pickSide <  0.5) { moveRight = false; }
        if(pickSide >= 0.5) { moveRight = true; }
        //Debug.Log(pickSide);
    }
    public void AIDeath()
    {
        isHit = true;
        StartCoroutine(AIexplode());
    }
    public IEnumerator AIexplode()
    {
      yield return new WaitForSeconds(despawnTime);
      Destroy(Instantiate(explosion, transform.position, transform.rotation), 2);
      Destroy(gameObject, 0.5f);
      
    }
}
