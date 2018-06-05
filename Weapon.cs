using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour 
{
	[SerializeField]
	public float Cooldown { get; protected set; } //The cooldown of the attack

	[SerializeField]
	protected int Damage;		//How much damage the attack does
	[SerializeField]
	protected float Range;		//How far the attack can shoot

	protected bool Shooting;	//Whether weapon is currently shooting
	
	[SerializeField]
	protected LayerMask StrikeableMask;  //Layermask that determines what the attack can hit
	[SerializeField] 
	protected ParticleSystem WeaponEffect;	//Particle system for visual effect of the weapon	
	[SerializeField] 
	protected ParticleSystem HitEffect;	//Particle system for visual effect of the weapon	
	
	//--------------------------------------------
	//METHODS
	//--------------------------------------------
	public abstract void Fire();
	
}
