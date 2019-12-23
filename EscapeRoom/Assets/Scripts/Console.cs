using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour
{

    public GameObject SlideGame;

    public GameObject Player;
    public void Hit(string inv)
    {
        if (inv.Equals("Controller"))
        {
            Player.GetComponent<inventory>().setHandItem("");
            SlideGame.SetActive(true);
            
        }
    }

}
