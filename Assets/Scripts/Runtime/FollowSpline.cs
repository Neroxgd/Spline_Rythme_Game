using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSpline : MonoBehaviour
{
    public SplineBest _spline;
    private float distance = 0;
    [Range(0, 30)] public float speed = 1;
    private float _indexVoiture;

    public Vector3 offset = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Voiture_index") == 0)
            _indexVoiture = 1f;
        if (PlayerPrefs.GetInt("Voiture_index") == 1)
            _indexVoiture = 1.2f;
        if (PlayerPrefs.GetInt("Voiture_index") == 2)
            _indexVoiture = 1.4f;
    }

    // Update is called once per frame
    void Update()
    {
        if (distance > _spline.length())
        {
            distance = 0;
        }
        else
        {
            distance += Time.deltaTime * speed * _indexVoiture;
        }

        transform.position = _spline.transform.TransformPoint(_spline.computePointWithLength(distance) + offset);

        Orientation orientation = _spline.computeOrientationWithLenght(distance, Vector3.up);

        transform.rotation = Quaternion.LookRotation(_spline.transform.TransformDirection(orientation.forward), _spline.transform.TransformDirection(orientation.upward));
    }
}
