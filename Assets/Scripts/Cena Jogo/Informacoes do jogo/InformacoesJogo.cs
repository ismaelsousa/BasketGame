using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformacoesJogo : MonoBehaviour{
	public static InformacoesJogo instancia;
	public int pontos;
	public string nickJogador;

	void Awake(){
		if (instancia == null) {
			instancia = this;		
		}else{
			Destroy (this.GetComponent<InformacoesJogo>());
		}
		
		DontDestroyOnLoad (instancia);

	}
}
