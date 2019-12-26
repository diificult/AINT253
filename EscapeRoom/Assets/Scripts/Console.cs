using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour
{

    public GameObject SlideGame;

    public GameObject Player;
    public GameObject Camera;


    public void Hit(string inv)
    {
        if (inv.Equals("Controller"))
        {
            Player.GetComponent<inventory>().setHandItem("");
            Player.GetComponent<Movement>().enabled = false;
            Camera.GetComponent<CameraControl>().enabled = false;
            SlideGame.SetActive(true);
            
        }
    }

}
