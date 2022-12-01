using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float speed = 1.0f;

    [SerializeField]
    float lookSensitivity = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Translation
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
            transform.position -= transform.forward * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            transform.position -= transform.right * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.position += transform.right * speed * Time.deltaTime;

        // Rotation
        float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * lookSensitivity;
        float rotationY = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * lookSensitivity;
        transform.localEulerAngles = new Vector3(rotationY, rotationX, 0); 

    }
}
