using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CarregarPontuacaoMaxima : MonoBehaviour {
	GerenciarDadosSalvos dados;
	public Text nickTxt;
	string nick;
	// Use this for initialization
	void Start () {
		dados = GerenciarDadosSalvos.gerenciadorDeDados;

		Jogador[] listaJogadores = dados.carregarDadosPlayer ();
		int maior = 0;
		if (listaJogadores [0] != null) {
			for (int i = 0; i < dados.getNumeroDeJogadoresSalvos (); i++) {
				if (listaJogadores [i].getPontos () > maior) {
					maior = listaJogadores [i].getPontos ();
					nick = listaJogadores [i].getNick ();
				}

			}
			nickTxt.text = nick;
			this.GetComponent<Text> ().text = maior.ToString ();
		} 
		}
	

}
