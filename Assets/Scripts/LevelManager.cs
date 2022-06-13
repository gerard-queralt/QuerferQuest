﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;
	private PlayerPlatformerController player;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerPlatformerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void RespawnPlayer ()
	{
		Debug.Log ("Player Respawn");
		player.transform.position = currentCheckpoint.transform.position;
	}
}
