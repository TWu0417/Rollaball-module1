using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerLose : MonoBehaviour
{
    public GameObject rollaballField;
    public GameObject enemyObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Destroy the current object
            rollaballField.gameObject.SetActive(false);
            enemyObject.gameObject.SetActive(false);

        }
    }
}
