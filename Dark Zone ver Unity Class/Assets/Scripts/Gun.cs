using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	public GameObject shoot;
	public GunEffect effect;

	public int fireDamage = 100;
	public float fireRange = 20;
	public float fireRate = 0.25f;

	private float fireInterval;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0) && Time.time > fireInterval) {

			fireInterval = Time.time + fireRate;

			Vector3 rayOrign = shoot.transform.position;
			RaycastHit hit;

			if(Physics.Raycast(rayOrign, shoot.transform.forward, out hit,fireRange)) {

				hit.collider.transform.root.SendMessage( "ApplyDamage", fireDamage );

				effect.HandleHit( hit );
			}

			effect.GunShoot();
		}
	}
}
