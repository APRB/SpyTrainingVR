using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyAfterTime : MonoBehaviour
{
  [SerializeField]
    private bool startFading = false;
    private Renderer render;
    private Collider col;
    private Color fade;
    
    public float fadeMultiplier = 1;

    private float fadeValue;

    public List<Material> materialsOnGameObject;
      void Awake()
    {
        startFading = false;
        render= GetComponent<Renderer>();
        col = GetComponent<Collider>();

      render.GetMaterials(materialsOnGameObject);
    }
        
  void OnCollisionEnter(Collision other)
  {
      if(other.gameObject.layer == 10)
      {  
        Invoke("DestroySelf",5f);
      }
  }
  /* void Fading()
   {

   }
    public void Update()
   {
       Fading();

       if(startFading)
       {
         
       }
   }*/
   public void DestroySelf()
   {
     Destroy(gameObject);
   }
}
