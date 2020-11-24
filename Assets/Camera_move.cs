using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_move : MonoBehaviour
{
    public Transform sphere;

    Vector3 dist;

    // Start is called before the first frame update
    void Start()
    {
        dist = transform.position - sphere.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = sphere.position + dist;
    }
}
