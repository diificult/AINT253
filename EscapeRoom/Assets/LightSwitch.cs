using UnityEngine;

public class LightSwitch : MonoBehaviour
{

    public GameObject LightOn;
    public GameObject LightOff;
    public Light light;
    private int state = 0;
    public GameObject Code;

    public void Hit(string inv)
    {
        if (state == 0)
        {
            LightOff.SetActive(false);
            LightOn.SetActive(true);
            light.enabled = true;
            Code.SetActive(true);
            state = 1;
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
}
