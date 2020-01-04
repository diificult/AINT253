using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public float sensitivity = 10f;
    // Start is called before the first frame update
    void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
     void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        float y = -Input.GetAxis("Mouse Y") * sensitivity;
        float x = Input.GetAxis("Mouse X") * sensitivity;
        y = Mathf.Clamp(y, -45.0f, 45.0f);

        transform.eulerAngles += new Vector3(y, x, 0);
        if (transform.eulerAngles.x > 65 && transform.eulerAngles.x < 90) transform.eulerAngles = new Vector3(65f, transform.eulerAngles.y, 0);
        if (transform.eulerAngles.x < 305 && transform.eulerAngles.x > 90) transform.eulerAngles = new Vector3(305, transform.eulerAngles.y, 0);
        if (Input.GetKey(KeyCode.R)) GetComponent<Camera>().fieldOfView = 30;
        else  GetComponent<Camera>().fieldOfView = 77; 
    }
}
