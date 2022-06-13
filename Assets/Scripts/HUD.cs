using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

	//Creem una "array" per a emmagatzemar les diferents imatges dels cors
	public Sprite [] HeartSprites;

	public Image HeartUI;

	private PlayerPlatformerController player;

	void Start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerPlatformerController> ();
	}

	void Update ()
	{
		HeartUI.sprite = HeartSprites[player.currentHealth];
	}
}
