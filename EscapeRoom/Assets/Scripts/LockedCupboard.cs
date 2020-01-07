using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedCupboard : MonoBehaviour
{
    public GameObject lockPuzzle;

    public bool inPuzzle = false;

    public LockPuzzle puzzleScript;
    public GameObject Player;
    public GameObject Camera;

    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && inPuzzle )
        {
            inPuzzle = false;
            lockPuzzle.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Player.GetComponent<Movement>().enabled = true;
            Camera.GetComponent<CameraControl>().enabled = true;
        }
    }

    public void Hit(string inv)
    {
        Debug.Log("oof");
        if (!inPuzzle && !puzzleScript.solved)
        {
            lockPuzzle.SetActive(true);
            inPuzzle = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Player.GetComponent<Movement>().enabled = false;
            Camera.GetComponent<CameraControl>().enabled = false;
        }
        
    }
}
