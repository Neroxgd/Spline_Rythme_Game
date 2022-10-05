using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTurn : MonoBehaviour
{
    [SerializeField] private Transform centreCam;
    [SerializeField][Range(1, 30)] private float zoomSpeed = 15;
    [SerializeField][Range(1, 10)] private float moveSpeed = 5;
    [SerializeField] private GameObject posCamOrigine;

    void FixedUpdate()
    {
        transform.LookAt(centreCam);
        posCamOrigine.transform.position = new Vector3(transform.position.x, posCamOrigine.transform.position.y, transform.position.z);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
    }

    void OnGUI()
    {
        // Debug.Log(Vector3.Distance (transform.position, posCamOrigine.transform.position));
        transform.Translate(new Vector3(0, 0, Input.mouseScrollDelta.y) * Time.deltaTime * zoomSpeed);
        if (Vector3.Distance(transform.position, posCamOrigine.transform.position) > 1.5f)
            transform.Translate(new Vector3(0, 0, -Input.mouseScrollDelta.y) * Time.deltaTime * zoomSpeed);
    }
}
