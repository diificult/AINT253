using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class pickupItem : UnityEvent<string> { }

public class Controller : MonoBehaviour
{

  //  public UnityEvent pickupItem;
    public void Hit()
    {
       // pickupItem.Invoke("Controller");
        Invoke(pickupItem, "Controller");
        enabled = false;
    }
}
