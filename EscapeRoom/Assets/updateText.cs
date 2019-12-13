using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateText : MonoBehaviour
{
    public void textUpdate(string newText)
    {
        GetComponent<Text>().text = newText;
    }
}
