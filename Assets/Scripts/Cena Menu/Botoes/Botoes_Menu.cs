using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Botoes_Menu: MonoBehaviour {
	GerenciarDadosSalvos dados;
	public Text pontos;

	void Start(){
		dados = GerenciarDadosSalvos.gerenciadorDeDados;


	}
	public void Sair(){
		Application.Quit ();



	}
	public void Jogar(){
		SceneManager.LoadScene ("Jogo");


	}
	public void Ranking(){
		//mudar para a cena de ranking
		SceneManager.LoadScene("Ranking");


	}
	//metodo temporario
	public void zerarPontuacao(){
		PlayerPrefs.SetInt ("pontuacaoMaxima", 0);
		pontos.text = "0";

	}
	public void zerarPlayers(){
		PlayerPrefs.SetInt ("numeroDeNicksSalvos", 0);
		Debug.Log ("Zerado");

	}
}
