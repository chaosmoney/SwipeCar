using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shurikenSwipe : MonoBehaviour
{
    float moveSpeed = 0;
    Vector3 startPos;
    Vector3 endPos;
    float damplingCoefficient = 0.98f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.LogFormat("Down: {0}", Input.mousePosition);
            this.startPos = Input.mousePosition;
        }

        else if (Input.GetMouseButtonUp(0))
        {
            Debug.LogFormat("Down: {0}", Input.mousePosition);
            this.endPos = Input.mousePosition;
            float swipeLength = endPos.y - startPos.y;
            this.moveSpeed = swipeLength/1000;
        }

        this.transform.Translate(0, moveSpeed, 0, Space.World);
        if (moveSpeed > 0)
        {
            this.transform.Rotate(0f, 0f, 10f);
        }
        
        moveSpeed *= damplingCoefficient;
    }
}
