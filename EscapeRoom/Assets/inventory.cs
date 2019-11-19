using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{

    string handItem;

    public bool setHandItem(string item)
    {
        if (handItem == "")
        {
            handItem = item;
            return true;
        }
        else return false;
    }
    public string getHandItem()
    {
        return handItem;
    }

}
