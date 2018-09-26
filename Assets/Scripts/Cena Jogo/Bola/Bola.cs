using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {
	private Ponto pontos;
	public GameObject explosao;
	private AddForcaABola pontoBola;
	// Use this for initialization
	void Start () {
		
		
		
		pontos = GameObject.Find ("Sexta").GetComponent<Ponto> ();
		pontoBola = GameObject.Find ("Ponto").GetComponent<AddForcaABola>();
	}
	void OnTriggerEnter2D(Collider2D bola){
		if (!pontoBola.clicando) { // se eu não estiver clicando
			if (bola.tag == "Bola") {
				Destroy (bola.gameObject);
				Instantiate (explosao, this.transform.position, Quaternion.identity);

			}
		} 

	}
<<<<<<< HEAD


=======
>>>>>>> parent of c4b076a... funcao nova
}
