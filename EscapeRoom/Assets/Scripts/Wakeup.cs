using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wakeup : MonoBehaviour
{
    public Text wakeupText;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("RemoveImage", 3.9f);
    }

    private void RemoveImage()
    {
        GetComponent<Image>().enabled = false;
        wakeupText.text = "Woah where am I? Did I pass out? This is my kitchen.";
        wakeupText.gameObject.SetActive(true);
        Invoke("RemoveText", 5f);
    }

    private void RemoveText()
    {
        wakeupText.gameObject.SetActive(false);
    }

}
