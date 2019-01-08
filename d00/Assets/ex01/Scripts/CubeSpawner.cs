using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {

	public GameObject	Key;

	private float		spawnTime;
	private bool is_spawned = false;

	void Update () {
		if(is_spawned == false){
			spawnTime = Time.time;
			GameObject.Instantiate(Key, Key.transform.position, Quaternion.identity);
			is_spawned = true;
		}
		if (spawnTime + Random.Range( 2, 10 ) < Time.time){
			is_spawned = false;
		}
	}
}
