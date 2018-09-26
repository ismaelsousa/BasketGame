using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]

public class Obstaculo : MonoBehaviour {
	public GameObject explosao;
	public AddForcaABola pontoBola;

	void Start(){
		this.GetComponent<Collider2D> ().isTrigger = true;
		pontoBola = GameObject.Find ("Ponto").GetComponent<AddForcaABola>(); // precisa disso para poder verificar se o usuario ta clicando ou nao para lançar a bola, se tiver nao pode destruir a bola


	}
	void OnTriggerEnter2D(Collider2D bola){
		if (!pontoBola.clicando) {
			if (bola.tag == "Bola") {
				Destroy (bola.gameObject);
				Instantiate (explosao, this.transform.position, Quaternion.identity);
			}

		}

	}
}
