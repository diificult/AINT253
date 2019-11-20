using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideGame : MonoBehaviour
{
    public GameObject[] sliders;

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
