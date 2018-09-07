using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
    public float turnSpeed = 50f;


    void Update()
    {
    
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

      
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
       
        //Don't copy numbers exactly
        if (transform.position.y > 8)
            transform.localPosition += new Vector3(0,-8,0)

    }
}