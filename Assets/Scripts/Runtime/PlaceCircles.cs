using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCircles : MonoBehaviour
{
    [SerializeField] private GameObject Torus;
    [SerializeField] private SplineBest _splinebest;
    [SerializeField] private uint sequence = 10;
    private List<GameObject> List_Torus = new List<GameObject>();
    private bool runtime = false;
    /*[SerializeField] private Transform Target;
    private Quaternion _lookRotation;
    private Vector3 _direction;*/

    public void GenerateTorus(int i, Vector3 point, Vector3 lastpoint)
    {
        // if (List_Torus.Count > _splinebest.returnNBpoints()/sequence)
        //     throw new System.Exception("il y a déjâ les cercles de généré");
        if (i % sequence == 0)
        {
            /*Orientation orientation = _splinebest.computeOrientationWithLenght(0, Vector3.up);
            Quaternion rotation = Quaternion.LookRotation(_splinebest.transform.TransformDirection(orientation.forward), _splinebest.transform.TransformDirection(orientation.upward));*/
            Vector3 _direction = (point - lastpoint).normalized;
            Quaternion _lookRotation = Quaternion.LookRotation(_direction);
            GameObject _torus = Instantiate(Torus, new Vector3(point.x, point.y, point.z), _lookRotation);
            // List_Torus.Add(_torus);
        }
    }

    /*public void DestroyTorus()
    {
        foreach (GameObject T in List_Torus)
        {
            Destroy(T);
        }
        List_Torus.Clear();
    }*/
    public bool ifruntime()
    {
        return runtime;
    }
    /*public bool listobj()
    {
        return List_Torus != null;
    }*/
    void Start()
    {
        runtime = true;
        _splinebest.computeLengths();
    }

    // Update is called once per frame
    void Update()
    {
        runtime = false;
        /*for (int i = 0; i < List_Torus.Count; i++)
        {
            _direction = (Target.position - List_Torus[i].transform.position).normalized;
            _lookRotation = Quaternion.LookRotation(_direction);
            List_Torus[i].transform.rotation = Quaternion.Slerp(List_Torus[i].transform.rotation, _lookRotation, 10);
        }*/
        
    }
}
