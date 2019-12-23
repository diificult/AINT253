using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//[System.Serializable]
//public class OnInvUpdate : UnityEvent<string>{}

public class inventory : MonoBehaviour
{

    string handItem = "";

    //public OnInvUpdate update ;

    public delegate void InvUpdate(string newText);
    public static event InvUpdate OnInvUpdate;

    public void setHandItem(string item)
    {
        if (handItem == "")
        {
            handItem = item;
            OnInvUpdate("Hand: " + handItem);
        }
    }
    
    public string getHandItem()
    {
        return handItem;
    }

}
