using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Digit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void digitUp()
    {
        int value = int.Parse(GetComponent<Text>().text);
        if (value == 9) value = 0;
        else value++;
        GetComponent<Text>().text = ""+value;
        
    }
    public void digitDown()
    {
        int value = int.Parse(GetComponent<Text>().text);
        if (value == 0) value = 9;
        else value--;
        GetComponent<Text>().text = "" + value;

    }
}
