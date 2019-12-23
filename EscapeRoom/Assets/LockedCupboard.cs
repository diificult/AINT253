using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedCupboard : MonoBehaviour
{
    public GameObject lockPuzzle;

    public bool inPuzzle = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && inPuzzle)
        {
            inPuzzle = false;
            lockPuzzle.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void Hit(string inv)
    {
        if (!inPuzzle)
        {
            lockPuzzle.SetActive(true);
            inPuzzle = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        
    }
}
