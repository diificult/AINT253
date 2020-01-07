using UnityEngine;
using UnityEngine.UI;

public class LightSwitch : MonoBehaviour
{

    public GameObject LightOn;
    public GameObject LightOff;
    public Light light;
    private int state = 0;
    public GameObject Code;
    private bool beenTurnedOn = false;
    public Text Dialog;

    public void Hit(string inv)
    {
        if (state == 0)
        {
            LightOff.SetActive(false);
            LightOn.SetActive(true);
            light.enabled = true;
            Code.SetActive(true);
            state = 1;
            if (!beenTurnedOn)
            {
                Dialog.text = "What! Who drew this on the wall! It looks so ugly as well.";
                Dialog.gameObject.SetActive(true);
                beenTurnedOn = true;
                Invoke("RemoveText", 3f);
            }
            Invoke("TurnOff", 4f);
        }
        else
        {
            LightOff.SetActive(true);
            LightOn.SetActive(false);
            light.enabled = false;
            Code.SetActive(false);
            state = 0;
        }
    }

    public void TurnOff()
    {
        LightOff.SetActive(true);
        LightOn.SetActive(false);
        light.enabled = false;
        Code.SetActive(false);
        state = 0;
    }

    private void RemoveText ()
    {
        Dialog.gameObject.SetActive(false);
    }
}
