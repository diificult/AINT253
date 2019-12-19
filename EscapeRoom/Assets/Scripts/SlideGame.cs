using UnityEngine;

public class SlideGame : MonoBehaviour
{
    public GameObject[] sliders;
    public GameObject invisible;
    public GameObject[,] map = new GameObject[3, 3];
    public GameObject[,] solution;

    void OnEnable()
    {

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        int i = 0;
        for (int y = 0; y < 3; y++)
        {
            for (int x = 0; x < 3; x++)
            {
                if (x == 1 && y == 2)
                {
                    map[x, y] = invisible;
                }
                else
                {
                    map[x, y] = sliders[i];
                    i++;
                }

            }
        }
        solution = new GameObject[,] {{sliders[0], sliders[4], sliders[7]},
                                            {sliders[1],sliders[5], sliders[6]},
                                            {sliders[2],invisible,sliders[3]}};
    }

    public void Swap(GameObject swaping)
    {
        int[] swapingLocation = GetLocation(swaping);
        int[] invisibleLocation = GetLocation(invisible);
        //Checks if UP/Down and not left or right OR left/right and not up or down.
        if (((swapingLocation[0] + 1 == invisibleLocation[0] || swapingLocation[0] - 1 == invisibleLocation[0]) && swapingLocation[1] == invisibleLocation[1])
            || ((swapingLocation[1] + 1 == invisibleLocation[1] || swapingLocation[1] - 1 == invisibleLocation[1]) && swapingLocation[0] == invisibleLocation[0]))
        {
            Vector3 swapingPos = swaping.GetComponent<RectTransform>().anchoredPosition;
            map[swapingLocation[0], swapingLocation[1]] = invisible;    
            map[invisibleLocation[0], invisibleLocation[1]] = swaping;
            //  swaping.transform.position = invisible.transform.position;
            swaping.GetComponent<RectTransform>().anchoredPosition = invisible.GetComponent<RectTransform>().anchoredPosition;
            invisible.GetComponent<RectTransform>().anchoredPosition = swapingPos;
            
        }

        if (map == solution) Debug.Log("YOU WON");
        else Debug.Log(map[0,0].name + " " + map[1,0].name + " " + map[2,0].name + "\n " + map[0, 1].name + " " + map[1, 1].name + " " + map[2, 1].name + " \n" + map[0, 2].name + " " + map[1, 2].name + " " + map[2, 2].name);
    }

    public int[] GetLocation(GameObject find)
    {
        //  int[] loc = null;
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                if (map[x, y] == find) return new int[] { x, y };
            }
        }
        return null;
    }
}
