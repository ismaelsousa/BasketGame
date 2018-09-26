using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Ponto : MonoBehaviour {
	public int pontoEmGame;
	private int pontuacaoMaxima;
	public Text pontotxt;
	private Transform sexta;
	public Transform paredeDir;
	public Transform paredeEsq;


	void Start(){
		pontoEmGame = 0;
		pontuacaoMaxima = PlayerPrefs.GetInt ("pontuacaoMaxima");
		sexta = GameObject.Find ("Sexta").GetComponent<Transform>();
		InformacoesJogo.instancia.pontos = pontoEmGame;
		mudarSextaDeLugar ();
		mudarParedesDeLugar ();

	}
	void OnTriggerEnter2D(Collider2D obj){
		if (obj.tag == "Bola") {
			Destroy (obj.gameObject);
			//Atualiza os pontos 
			pontoEmGame++;
			InformacoesJogo.instancia.pontos = pontoEmGame;
			pontotxt.text = pontoEmGame.ToString ();
			mudarSextaDeLugar ();
			mudarParedesDeLugar ();
			//se a pontuação que o jogador conseguir for maior do que a pontuação antiga, ele guarda


			if (pontoEmGame > pontuacaoMaxima) {
				pontuacaoMaxima = pontoEmGame;
				PlayerPrefs.SetInt ("pontuacaoMaxima", pontuacaoMaxima);
			}
		} 



		//troca de desafio

	}



	void mudarSextaDeLugar(){
		sexta.position = new Vector2 (Random.Range (-1.73f,1.73f),Random.Range (0.3f,2.3f));
		float novaRotacao = Random.Range (-50f, 50f);
		if (novaRotacao < 50f && novaRotacao > -50f) {
			sexta.Rotate (0, 0, novaRotacao);
		
		}

	}
	void mudarParedesDeLugar(){
		paredeDir.position = new Vector2 (paredeDir.position.x, Random.Range (0f, 4f));
		paredeEsq.position = new Vector2 (paredeEsq.position.x, Random.Range (0f, 4f));


	}

	void atualizaRankingLocal(string nick, int pontos){


	}
	void atualizaRankingOnline(string nick, int pontos){


	}


}
