using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleport : MonoBehaviour {

	public int LevelToLoad;

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.CompareTag ("Player")) {
			Application.LoadLevel (LevelToLoad);
		}
	}
}
