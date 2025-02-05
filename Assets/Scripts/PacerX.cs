using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacerX : MonoBehaviour
{

    public float speed = 5.0f;
    private float xMax = 7.5f;
    private float xMin = -7.5f;
    private int direction = 1;

    // Update is called once per frame
    void Update()
    {
        float xNew = transform.position.x + direction * speed *Time.deltaTime;
        if (xNew >= xMax)
        {
            xNew = xMax;
            direction *= -1;
        }
        else if (xNew <= xMin)
        {
           xNew = xMin;
            direction *= -1;
        }
        transform.position = new Vector3(xNew, transform.position.y, transform.position.z);

    }
}
