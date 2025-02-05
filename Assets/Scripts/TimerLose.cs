using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerLose : MonoBehaviour
{
	public GameObject rollaballField;
	public GameObject enemyObject;

	void Start()
	{
		Debug.Log("TimerLose script is running!");
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
