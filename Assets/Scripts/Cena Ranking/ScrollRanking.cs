using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScrollRanking : MonoBehaviour {
	GerenciarDadosSalvos dados;
	public GameObject[] ranking;
	// Use this for initialization
	void Start () {
		
		for (int i = 0; i < ranking.Length; i++) {
			ranking [i] = GameObject.Find ((i+1).ToString ());
		}
		dados = GerenciarDadosSalvos.gerenciadorDeDados;

		Jogador[] lista = ordenarRanking(dados.carregarDadosPlayer ());

		if (lista[0] != null) {
			for (int i = 0; i < ranking.Length; i++) {
				if (lista [i] != null) {
					ranking [i].GetComponentInChildren<Text> ().text = lista [i].getNick ()+"     " + lista [i].getPontos ();
				} else {
					ranking [i].GetComponentInChildren<Text> ().text = "Empty     0";
					ranking [i].GetComponentInChildren<Text> ().color = Color.grey;
				
				}
			}
		} else {
			for (int i = 0; i < ranking.Length; i++) {
					ranking [i].GetComponentInChildren<Text> ().text = "Empty     0";
					ranking [i].GetComponentInChildren<Text> ().color = Color.grey;

			}
		}


	}
	public static Jogador[] ordenarRanking(Jogador[] rank){
		for (int x = 0; x < rank.Length - 1; x++) {
			
			for (int i = 0; i < rank.Length - 1; i++) {
				if (rank [i] != null && rank [i+1] != null) {
					if (rank [i].getPontos () < rank [i + 1].getPontos ()) {
						Jogador aux = rank [i];
						rank [i] = rank [i + 1];
						rank [i + 1] = aux;

					} 	
				
				} 

			}	
		
		}
		return rank;


	}


}
