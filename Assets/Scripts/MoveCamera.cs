using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MoveCamera : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    float inputX, inputY;

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");
        if (inputX != 0)
        {
            Debug.Log("Sprite X: " + transform.position.x);

            moveacross();

            if ((transform.position.x > 18.0f) || (transform.position.x < -18.0f))
            {
                transform.Translate(-1 * transform.right * inputX * moveSpeed * Time.deltaTime);
            }
        }

        if (inputY != 0)
        {
            Debug.Log("Sprite Y: " + transform.position.y);

            movevertical();

            if ((transform.position.y > 1.35f) || (transform.position.y < -1.35f))
            {
                transform.Translate(-1 * transform.up * inputY * moveSpeed * Time.deltaTime);
            }
        }
    }

    private void moveacross()
    {
        transform.position += transform.right * inputX * moveSpeed * Time.deltaTime;

    }

    private void movevertical()
    {
        transform.position += transform.up * inputY * moveSpeed * Time.deltaTime;

    }

    //private void moveforward()
    //{
    //    transform.position += transform.forward * inputZ * Time.deltaTime;
    //}

}
