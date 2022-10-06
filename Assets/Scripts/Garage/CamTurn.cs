using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTurn : MonoBehaviour
{
    [SerializeField] private Transform centreCam;
    [SerializeField][Range(1, 30)] private float zoomSpeed = 15;
    [SerializeField][Range(1, 10)] private float moveSpeed = 5;
    [SerializeField] private GameObject posCamOrigine;
    private float distance_cam_centre;

    void Start()
    {
        transform.LookAt(centreCam);
        distance_cam_centre = Vector3.Distance(transform.position, centreCam.position);
        Debug.Log(Vector3.Cross(transform.position, centreCam.position));
    }

    void FixedUpdate()
    {

        posCamOrigine.transform.position = new Vector3(transform.position.x, posCamOrigine.transform.position.y, transform.position.z);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
            // Debug.Log(Vector3.Cross(transform.position, centreCam.position)) ;
            transform.RotateAround(centreCam.position, -Vector3.up*Time.deltaTime*moveSpeed, 3);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
            // Debug.Log(Vector3.Cross(transform.position, centreCam.position)) ;
            transform.RotateAround(centreCam.position, Vector3.up*Time.deltaTime*moveSpeed, 3);
        }
        transform.LookAt(centreCam);


    }

    void OnGUI()
    {
        // Debug.Log(Vector3.Distance (transform.position, posCamOrigine.transform.position));
        transform.Translate(new Vector3(0, 0, Input.mouseScrollDelta.y) * Time.deltaTime * zoomSpeed);
        if (Vector3.Distance(transform.position, posCamOrigine.transform.position) > 1.5f)
            transform.Translate(new Vector3(0, 0, -Input.mouseScrollDelta.y) * Time.deltaTime * zoomSpeed);
    }

}
