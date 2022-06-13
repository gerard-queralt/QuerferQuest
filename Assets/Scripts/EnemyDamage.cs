using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

	private PlayerPlatformerController player;

	public int DmgDealt;

	void Start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerPlatformerController>();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.CompareTag("Player"))
			{
			player.Damage(DmgDealt);

			player.knockbackCount = player.knockbackLenght;
			if (player.transform.position.x < transform.position.x)
				player.knockFromRight = true;
			else
				player.knockFromRight = false;
			}
	}
}
