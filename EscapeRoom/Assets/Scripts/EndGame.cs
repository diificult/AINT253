using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    public SceneController sc;

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Triggered");
        if (collision.collider.gameObject.layer == LayerMask.GetMask("End"))
        {
            sc.EndGame();
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if (other.gameObject.name == "EndTrigger")
        {
            sc.EndGame();
        }
    }
}

