using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBounds : MonoBehaviour
{
  //  public float moveSpeed;
  /*  public double minX = -0.83;
    public double maxX = 1.08;
    public double minY = -3.42;
    public double maxY = 3.3; */

  //  float MinX = (float)minX;

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.GetAxis("Mouse x") > 0 || Input.GetAxis("Mouse x") < 0)
            {
                transform.position = new Vector3(Mathf.Clamp(transform.position.x, (float)-0.83, (float)1.08), Mathf.Clamp(transform.position.y, (float)-3.42, (float)3.3), transform.position.z );
            }
        }


      /*  if (Input.MousePosition.x > leftBound && Input.MousePosition.x < rightBound)
            GetComponent<Camera>().position.x = Input.MousePosition.x;
        else if (Input.mousePosition.x > rightBound)
            GetComponent<Camera>().position.x = rightBound;
        else if (Input.mousePosition.x < leftBound)
            GetComponent<Camera>().position.x = leftBound; */
    }





}
