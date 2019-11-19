using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    public bool isInteractable = false;
    // Start is called before the first frame update
    public bool getInteractable()
    {
        return isInteractable;
    }
}
