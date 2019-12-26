using UnityEngine;
using UnityEngine.UI;

public class LockPuzzle : MonoBehaviour
{

    public GameObject[] digits = new GameObject[4];

    public GameObject cupboard;

    public bool solved = false;

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
            transform.parent.gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            cupboard.GetComponent<Rigidbody>().AddForce(Vector3.up * 10f);
            cupboard.GetComponent<Rigidbody>().AddForce(Vector3.forward * 10f);
            cupboard.GetComponent<Rigidbody>().AddForce(Vector3.right * 10f);
            solved = true;
        }
        
    }
}
