using UnityEngine;
using UnityEngine.UI;

public class updateText : MonoBehaviour
{


    private void OnEnable()
    {
        inventory.OnInvUpdate += textUpdate;
    }
    private void OnDisable()
    {
        inventory.OnInvUpdate -= textUpdate;
    }

    public void textUpdate(string newText)
    {
        GetComponent<Text>().text = newText;
    }
}
