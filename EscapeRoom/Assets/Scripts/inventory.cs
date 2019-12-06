using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[SerializeField]
public class OnInvUpdate UnityEvent : <string>();

public class inventory : MonoBehaviour
{

    string handItem = "";

    public 

    public void setHandItem(string item)
    {
        if (handItem == "")
        {
            handItem = item;
        }
    }
    
    public string getHandItem()
    {
        return handItem;
    }

}
