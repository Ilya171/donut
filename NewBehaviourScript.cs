using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float dist1y = 293f;
    public float dist2y = 125f;
    public float dist1x = 343f;
    public float dist2x = 340f;
    

    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    transform.localScale = new Vector2(0.7f, 1);
        //}
        //else if (Input.GetMouseButtonUp(0))
        //{
        //    transform.localScale = new Vector2(1, 1);

        //}

        int yPosition = (int)Input.mousePosition.y;
        int xPosition = (int)Input.mousePosition.x;
        if (Input.GetMouseButtonDown(0) && yPosition > (Screen.height / 2 - dist1y) && yPosition < (Screen.height / 2 + dist2y) && xPosition > (Screen.width / 2 - dist1x) && xPosition < (Screen.width / 2 + dist2x))
        {

            transform.localScale = new Vector2(0.9f, 1);

        }
        else if (Input.GetMouseButtonUp(0))
        {
            transform.localScale = new Vector2(1, 1);
        }

    }
}
