using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detector : MonoBehaviour
{
    [SerializeField] float raycastLength = 4f;
    Vector3 OriginPoint;   
    
    Vector3 Direction;
   
    public void Start() 
    {
        
      /*  Vector3 OriginPoint = new Vector3(transform.localPosition.x,transform.localPosition.y,transform.localPosition.z);
        OriginPoint +=  Vector3.left * 4;

        Vector3 RayEndPoint =  new Vector3(transform.localPosition.x,transform.localPosition.y,transform.localPosition.z);
        RayEndPoint -= Vector3.right * 4; */
    }

   public void FixedUpdate() {
    
        OriginPoint = transform.position + raycastLength * transform.up;
        Direction = -transform.up;

            
   
        Ray ray = new Ray(OriginPoint, Direction);
        RaycastHit hit;


        Physics.Raycast(ray, out hit, raycastLength);
        
        Debug.DrawRay(ray.origin,Direction*raycastLength,Color.green);
        
        

    


   }





}
