using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
[RequireComponent(typeof(Collider2D))]
public class Perdeu : MonoBehaviour{
	private AddForcaABola addforce;
	public GameObject ponto;
	private bool trava;
	void Start(){
		this.GetComponent<Collider2D> ().isTrigger = true;
		addforce = GameObject.Find ("Ponto").GetComponent<AddForcaABola> ();
		trava = true;

	}


	void OnTriggerEnter2D(Collider2D obj){
		if (obj.tag == "Bola") {
			addforce.enabled = false; // trava o script de jogar a bola
			if (trava) { // evita chamar a cena de "tentar novamente" mais de umas vez
				perdeu (); // chama a função que vai para a cena de tentar novamente
				trava = false;
			}
		}
		Destroy (obj.gameObject); 
	}
	//Basta colcoar esse Script no objeto que quando a bola pegar vai destruir a bola e vai pra cena de tentar novamente
	public void perdeu(){
		SceneManager.LoadScene ("Tentar_Novamente");

	}
}
