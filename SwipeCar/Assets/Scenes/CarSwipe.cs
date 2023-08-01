using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSwipe : MonoBehaviour
{
    float moveSpeed = 0;
    float damplingCoefficient = 0.98f;
    private Vector3 downPos;
    private Vector3 startPos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.LogFormat("Down: {0}",Input.mousePosition);
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Debug.LogFormat("Up: {0}", Input.mousePosition);

            Vector3 endPos = Input.mousePosition;

            float swipeLength = endPos.x - startPos.x;
            Debug.LogFormat("swipeLength {0}",swipeLength);

            this.moveSpeed = swipeLength / 500; //화면좌표계에서의 두점사이의 거리에 비례해서 이동
            Debug.LogFormat("moveSpeed: {0}", this.moveSpeed);
        }

        this.transform.Translate(this.moveSpeed, 0, 0);

        this.moveSpeed *= this.damplingCoefficient;
    }
}
