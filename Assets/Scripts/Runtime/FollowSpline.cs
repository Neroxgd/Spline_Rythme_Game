using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSpline : MonoBehaviour
{
    public SplineBest _spline;
    private float distance = 0;
    [Range(0, 30)] public float speed = 1;
    private static float _indexVoiture = 0;
    [SerializeField] private AudioSource _audiosource;

    public Vector3 offset = Vector3.zero;

    // Start is called before the first frame update
    void Awake()
    {
        _audiosource.pitch = 1;
        if (PlayerPrefs.GetInt("Voiture_index") == 0)
        {
            _indexVoiture = 1f;
            _audiosource.pitch = 1f;
        }

        if (PlayerPrefs.GetInt("Voiture_index") == 1)
        {
            _indexVoiture = 1.25f;
            _audiosource.pitch = 1.25f;
        }

        if (PlayerPrefs.GetInt("Voiture_index") == 2)
        {
            _indexVoiture = 1.5f;
            _audiosource.pitch = 1.5f;
        }

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
            distance += (Time.deltaTime * speed) * _indexVoiture;
        }

        transform.position = _spline.transform.TransformPoint(_spline.computePointWithLength(distance) + offset);

        Orientation orientation = _spline.computeOrientationWithLenght(distance, Vector3.up);

        transform.rotation = Quaternion.LookRotation(_spline.transform.TransformDirection(orientation.forward), _spline.transform.TransformDirection(orientation.upward));
    }
}
