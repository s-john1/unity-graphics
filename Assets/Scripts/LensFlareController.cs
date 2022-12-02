using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LensFlareController : MonoBehaviour
{
    [SerializeField]
    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Enable lens flare when the sun is sufficiently high in the sky
        Debug.Log(transform.rotation.x);
        if(transform.rotation.eulerAngles.x < 145 && transform.rotation.eulerAngles.x > 35)
        {
            cam.GetComponent<FlareLayer>().enabled = true;
        } else
        {
            cam.GetComponent<FlareLayer>().enabled = false;
        }
    }
}
