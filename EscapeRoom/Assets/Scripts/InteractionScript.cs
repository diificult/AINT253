using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform c;

    // Update is called once per frame
    void Update()
    {


        RaycastHit hit;
       // if (Physics.Raycast(c.position, transform.TransformDirection(c.forward), out hit, 100f))
       // {
       //     Debug.DrawRay(c.position, transform.TransformDirection(c.forward) * hit.distance, Color.red);
       // }
       // Debug.Log(transform.localEulerAngles);

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Yeah 1!");
            if ( Physics.Raycast(c.position, transform.TransformDirection(c.forward), out hit, 100f))
            {
                Debug.Log(hit.transform.gameObject.layer);
                Debug.Log("Yeah 2!");

                if (hit.transform.gameObject.layer == 10)
            {
                    Debug.Log("Yeah 3!");
                    if  ( GetComponent<inventory>().getHandItem().Equals(""))
            {
                        hit.transform.SendMessage("Hit", SendMessageOptions.DontRequireReceiver);
                    }
            } 
            } 
            
            
        }
            
        {
        }
 

            //int layerMask = 1 << 8;
            //layerMask = ~layerMask;
            //RaycastHit hover;
            //Physics.Raycast(transform.position, transform.localEulerAngles, out hover, 100f, LayerMask.GetMask("Interactable"));
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hover.distance, Color.green, 10f);
            //Debug.Log(hover.transform);
            ////hover.transform.SendMessage("Hover", SendMessageOptions.DontRequireReceiver);
            //if (Input.GetKeyDown(KeyCode.E))
            //{
            //    RaycastHit hit;
            //    Physics.Raycast(transform.position, transform.localEulerAngles, out hit, Mathf.Infinity, layerMask);
            //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow, 10f);
            //    Debug.Log(hit.transform.position);
            //   // hit.transform.SendMessage("Hit", SendMessageOptions.DontRequireReceiver);
            //}


    }


}
