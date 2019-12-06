using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideGame : MonoBehaviour
{
    public GameObject[] sliders;
    public GameObject invisible;

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
