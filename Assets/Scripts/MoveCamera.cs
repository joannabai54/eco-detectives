using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float inputX, inputZ;

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");
        if (inputX != 0)
        {
            moveacross();
        }
        //if (inputY != 0)
        //{
        //    movevertical();
        //}
        if (inputZ != 0)
        {
            movevertical();
        }

    }

    private void moveacross()
    {
        transform.position += transform.right * inputX * Time.deltaTime;

    }

    private void movevertical()
    {
        transform.position += transform.up * inputZ * Time.deltaTime;

    }

    //private void moveforward()
    //{
    //    transform.position += transform.forward * inputZ * Time.deltaTime;
    //}

}
