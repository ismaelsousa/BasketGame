using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine ("tempoExplosao");
	}
	
	IEnumerator tempoExplosao(){
		yield return new WaitForSeconds(1f);
		Destroy(this.gameObject);

	}
}
