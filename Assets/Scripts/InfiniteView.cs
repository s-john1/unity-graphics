using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script makes a GameObject follow a camera on the X and Z coordinates,
// making it seem like it extends infinitely.
// It is important that the GameObject (e.g. a plane) is equal size or bigger than the
// camera's far clipping distance value

public class InfiniteView : MonoBehaviour
{
    [SerializeField]
    GameObject plane; // the plane of the ground/sea

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the plane's X and Z coordinates to follow the camera
        plane.transform.position = new Vector3(transform.position.x, plane.transform.position.y, transform.position.z);
    }
}
