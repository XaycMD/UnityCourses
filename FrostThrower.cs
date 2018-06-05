using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrostThrower : Weapon
{

	// Use this for initialization
	void Awake ()
	{
		Cooldown = 0.01f;
		WeaponEffect.startLifetime = Range/WeaponEffect.startSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void Fire()
	{
		WeaponEffect.Play();
		
		//Create a ray from the current position and extending straight forward
		Ray ray = new Ray(transform.position, transform.forward);
		//Create a RaycastHit variable which will store information about the raycast
		RaycastHit hit;

		//If our raycast hits something...
		if (Physics.Raycast(ray, out hit, Range, StrikeableMask))
		{
			//...move the lightning hit game object to the point of the hit...
			//HitEffect.transform.position = hit.point;
			//...and play the effect...
			//HitEffect.Play();
			//...then set the end point of the lightning bolt..
			//_lightningBolt.EndPoint = hit.point;
			//...then try to get a reference to an EnemyHealth script...
			EnemyHealth enemyHealth = hit.collider.GetComponent<EnemyHealth>();
			//...if the script exists...
			if (enemyHealth != null)
			{	
				//...tell the enemy to take damage
				enemyHealth.TakeDamage(Damage);
			}
		}
		//Otherwise, if our raycast doesn't hit anything...
		else
		{
			//...place the end of the bolt at maximum range
			//_lightningBolt.EndPoint = ray.GetPoint(_range);
		}
		//Turn the lightning bolt game object on
		//_lightningBolt.gameObject.SetActive(true);
	}
}
