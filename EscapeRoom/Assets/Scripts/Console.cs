using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour
{

    public GameObject SlideGame;
    public void Hit(string inv)
    {
        if (inv.Equals("Controller"))
        {
            SlideGame.SetActive(true);
        }
    }

}
