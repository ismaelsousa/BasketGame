using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class New_Record_Pontos : MonoBehaviour {
	public Text pontos;
	public Text newRecord;

	// Use this for initialization
	void Start () {

		this.gameObject.SetActive (false);

		if (InformacoesJogo.instancia.pontos != 0 && InformacoesJogo.instancia.pontos >= PlayerPrefs.GetInt ("pontuacaoMaxima")) {
			if (InformacoesJogo.instancia.pontos == (PlayerPrefs.GetInt ("pontuacaoMaxima")-1)) {
				newRecord.text = "Pontos";
			} else {
				newRecord.text = "New Record !!";
			}
			this.gameObject.SetActive (true); // mostra caixa de entrada para nick




		} else if (InformacoesJogo.instancia.pontos != 0 && InformacoesJogo.instancia.pontos >= (PlayerPrefs.GetInt ("pontuacaoMaxima") / 2)) {
			newRecord.text = "Pontos";
			this.gameObject.SetActive (true);// mostra caixa de entrada para nick
		


		} else {
			newRecord.text = "Pontos";
			this.gameObject.SetActive (false);
		}
		pontos.text = InformacoesJogo.instancia.pontos.ToString ();




	}


	

}
