using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerController : PhysicsObject {

	public float maxSpeed = 7;
	public float jumpTakeOffSpeed = 7;

	public float knockback;
	public float knockbackLenght;
	public float knockbackCount;
	public bool knockFromRight;

	public int currentHealth;
	public int maxHealth = 100;

	void Awake () 
	{
		currentHealth = maxHealth;
	}
	void Die()
	{
		Application.LoadLevel (Application.loadedLevel);
	}
	protected override void ComputeVelocity()
	{
		Vector2 move = Vector2.zero;

		move.x = Input.GetAxis ("Horizontal");

		if (Input.GetButtonDown ("Jump") && grounded) {
			velocity.y = jumpTakeOffSpeed;
		} else if (Input.GetButtonUp ("Jump")) 
		{
			if (velocity.y > 0)
				velocity.y = velocity.y * .5f;
		}

		if (knockbackCount <= 0) {
			targetVelocity = move * maxSpeed;
		} else {
			if (knockFromRight)
				targetVelocity = new Vector2 (-knockback, knockback);
			if (!knockFromRight)
				targetVelocity = new Vector2 (knockback, knockback);
			knockbackCount -= Time.deltaTime;
		}
		{
			if (currentHealth > maxHealth) {
				currentHealth = maxHealth;
			}
			if (currentHealth <= 0) {
				Die ();
			}
		}
	}

	public void Damage(int dmg)
	{
		currentHealth -= dmg;
		gameObject.GetComponent<Animation> ().Play ("Player_RedFlash");
	}

}
