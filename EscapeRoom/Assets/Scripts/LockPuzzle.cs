using UnityEngine;
using UnityEngine.UI;

public class LockPuzzle : MonoBehaviour
{

    public GameObject[] digits = new GameObject[4];

    public GameObject cupboard;

    public bool solved = false;
    public GameObject Player;
    public GameObject Camera;
    [SerializeField]
    private string solution = "2976";
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

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
         //   cupboard.GetComponent<Rigidbody>().AddForce(Vector3.up * 10f);
        //    cupboard.GetComponent<Rigidbody>().AddForce(Vector3.forward * 10f);
        //    cupboard.GetComponent<Rigidbody>().AddForce(Vector3.right * 10f);
            Player.GetComponent<Movement>().enabled = true;
            Camera.GetComponent<CameraControl>().enabled = true;
            solved = true;
            cupboard.GetComponent<Animator>().SetTrigger("OpenDoor");
            transform.parent.gameObject.SetActive(false);

        }

    }
}
