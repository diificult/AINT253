using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class pickupItem : UnityEvent<string> { }

public class Controller : MonoBehaviour
{

    public pickupItem pickup;
    public void Hit()
    {
        pickup.Invoke("Controller");
        enabled = false;
    }
}
