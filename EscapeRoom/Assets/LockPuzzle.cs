using UnityEngine;
using UnityEngine.UI;

public class LockPuzzle : MonoBehaviour
{

    public GameObject[] digits = new GameObject[4];
    string solution = "2976";
    public void CheckCode()
    {
        string usercode = "";
        foreach (GameObject digit in digits)
        {
            usercode += digit.GetComponent<Text>().text;
        }
        if (usercode == solution)
        {
            Debug.Log("Solution Found");
        }

    }
}
