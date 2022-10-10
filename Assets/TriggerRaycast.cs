using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRaycast : MonoBehaviour
{
    [SerializeField] float raycastLength = 4f;

    Vector3 OriginPoint;   
    
    Vector3 Direction;

    public bool Cancast;

    public float CooldownTime = 0.2f;

    IEnumerator coroutine;

    public GameManager GameManager;

        public GameObject GoodUi;
        
    public GameObject PerfectUi;

    public GameObject MissUi;





    private void Start()
    {

        Cancast = true;

    }

    private void Update() 
    {   
       
      



        if(Input.GetKeyUp("e"))
        {
            if(Cancast == false)
            {
               return; 
            }
            else if(Cancast)
            {
            CastRay();

             Cancast = false;
            coroutine = Cooldowning(CooldownTime);
            StartCoroutine(coroutine);
            }
        }


           Ray Ray2 = new Ray(OriginPoint, Direction);
        RaycastHit hit2;
        Debug.DrawRay(Ray2.origin,Direction*raycastLength,Color.red);


        if(Physics.Raycast(Ray2, out hit2, raycastLength))
            {

                if (hit2.transform.gameObject.layer == LayerMask.NameToLayer("Miss"))
                {

                    Debug.Log("Miss");
                    GameManager.multiplier = 0;

                        PerfectUi.gameObject.SetActive(false);
                        MissUi.gameObject.SetActive(true);
                        GoodUi.gameObject.SetActive(false);
                }


            }


    }   
    public IEnumerator Cooldowning(float CooldownTime)
    {
        yield return new WaitForSeconds(CooldownTime);

        Cancast = true;
    }

       
        

   private void CastRay()
    {

          OriginPoint = transform.position + raycastLength * transform.up;
        Direction = -transform.up;

        Ray ray = new Ray(OriginPoint, Direction);
        RaycastHit hit;
        Debug.DrawRay(ray.origin,Direction*raycastLength,Color.green);


        if(Physics.Raycast(ray, out hit, raycastLength))
        {
              if(hit.transform.gameObject.layer ==  LayerMask.NameToLayer("Excellent"))
        {
            Debug.Log("excellent");

            GameManager.AddperfectScore();

            PerfectUi.gameObject.SetActive(true);
            MissUi.gameObject.SetActive(false);
            GoodUi.gameObject.SetActive(false);

        }

        else if(hit.transform.gameObject.layer ==  LayerMask.NameToLayer("Good"))
        {
            Debug.Log("Good");
            
            GameManager.AddGoodScore();
            PerfectUi.gameObject.SetActive(false);
            MissUi.gameObject.SetActive(false);
            GoodUi.gameObject.SetActive(true);
        }
        else
        {

            Debug.Log("miss");

            
            GameManager.multiplier = 0;
            PerfectUi.gameObject.SetActive(false);
            MissUi.gameObject.SetActive(true);
            GoodUi.gameObject.SetActive(false);


        }
        

        }


    }   

        


   /* if(Input.GetKey("space"))
    {
             


        Physics.Raycast(ray, out hit, raycastLength);
        
        Debug.DrawRay(ray.origin,Direction*raycastLength,Color.green);

        if(hit.transform.gameObject.layer ==  LayerMask.NameToLayer("Excellent"))
        {
            Debug.Log("excellent");

        }

        else if(hit.transform.gameObject.layer ==  LayerMask.NameToLayer("Good"))
        {
            Debug.Log("Good");
        }

    }

*/
    }



