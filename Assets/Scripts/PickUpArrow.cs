using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpArrow : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
