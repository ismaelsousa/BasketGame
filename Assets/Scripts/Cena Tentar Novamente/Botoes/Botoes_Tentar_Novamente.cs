using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Botoes_Tentar_Novamente : MonoBehaviour {
	public Text nick;
	public Text pontos;
	GerenciarDadosSalvos dados;


	void Start(){
		dados = GerenciarDadosSalvos.gerenciadorDeDados;

	}
	public void Tentar_Novamente(){
		
		SceneManager.LoadScene("Jogo");

	}
	public void Menu(){
		
		SceneManager.LoadScene("Menu");

	}
	private bool trava = true;
	public void Save(){
		if (nick.text != "" && trava) {
			setNick ();
			setPontos ();
			dados.salvar ();
			trava = false;
		
		}

	
	}

	public void setNick(){
		dados.setNick (nick.text);

	
	}

	public void setPontos(){
		dados.setPontos (int.Parse(pontos.text));
	
	}
}
