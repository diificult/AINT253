using UnityEngine;
using UnityEngine.UI;
using System;

public class LockPuzzle : MonoBehaviour
{

    public GameObject[] digits = new GameObject[4];

    public GameObject target;

    public bool solved = false;
    public GameObject Player;
    public GameObject Camera;
    public Text text;
    [SerializeField]
    private string solution = "2976";

    public  AudioSource audio;
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
            Player.GetComponent<Movement>().enabled = true;
            Camera.GetComponent<CameraControl>().enabled = true;
            solved = true;
            target.GetComponent<Animator>().SetTrigger("OpenDoor");
            transform.parent.gameObject.SetActive(false);
            audio.Play();
            try
            {
                text.text = "Hey, that door is opening!";
                text.gameObject.SetActive(true);
                Invoke("RemoveText", 3f);
            } catch (Exception e)
            {

            }
        }

    }

    private void RemoveText()
    {
        text.gameObject.SetActive(false);
    }

}
