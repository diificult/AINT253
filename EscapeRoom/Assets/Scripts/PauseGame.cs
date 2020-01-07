using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject PauseMenu;
    public CameraControl c;

    public LockedCupboard[] lc;
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1 && !lc[0].inPuzzle && !lc[1].inPuzzle)
            {
                Time.timeScale = 0;
                PauseMenu.SetActive(true);
                c.enabled = false;
            }
            else if (Time.timeScale == 0 )
            {
                Time.timeScale = 1;
                PauseMenu.SetActive(false);
                c.enabled = true;
            }
        }
    }
}
