using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detector : MonoBehaviour
{

   
    private void Start() {
        
       





    }

   public void FixedUpdate() {
    

        
        Vector3 OriginRay = transform.position ;

            
   
        Ray ray = new Ray(OriginRay, Vector3.down);
        RaycastHit hit;


        if(Physics.Raycast(ray, out hit, 10))
        {
            Debug.DrawLine(ray.origin,hit.point,Color.green);
        }
        




   }





}
