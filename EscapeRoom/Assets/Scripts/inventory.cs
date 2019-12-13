using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnInvUpdate : UnityEvent<string>{}

public class inventory : MonoBehaviour
{

    string handItem = "";

    public OnInvUpdate update;

    public void setHandItem(string item)
    {
        if (handItem == "")
        {
            handItem = item;
            update.Invoke("Hand: " + handItem);
        }
    }
    
    public string getHandItem()
    {
        return handItem;
    }

}
