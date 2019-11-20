using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{

    string handItem = "";

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
