using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSelectInstantiate : MonoBehaviour
{
    public GameObject Prefab;
    public XRSocktInteractorTag mySocketInterator;
    public float settime = 1f;
    public float timer;

    private void Awake()
    {
        timer = settime;
    }
    private void Update()
    {
        if (mySocketInterator.selectTarget == null)
        {
            timer -= 1 * Time.deltaTime;
            if(timer<0)
            {
                SpawnPrefab();
                timer = settime;
            }
        }
        else
        {
            timer = settime;
        }
    }
    public void SpawnPrefab()
    {
        GameObject clone = Instantiate(Prefab, new Vector3(transform.position.x , transform.position.y, transform.position.z ), Prefab.transform.rotation);
    }
}
