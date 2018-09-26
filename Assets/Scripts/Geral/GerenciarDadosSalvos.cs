using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

[Serializable]
class DadosPlayer{
	public string nick;
	public int pontos;



}
public class GerenciarDadosSalvos : MonoBehaviour {
	public static GerenciarDadosSalvos gerenciadorDeDados;
	private Jogador[] jogadores = new Jogador[20];
	private string nick;
	private int pontos;
	private int numeroDeNicksSalvos = 0;
	private string[] arquivoURL = new string[20];


	void Awake(){
		

		if (gerenciadorDeDados == null) {
			gerenciadorDeDados = this;
		
		} else {
			Destroy (gameObject);
		
		}
		DontDestroyOnLoad (gameObject);
		for (int i = 0; i < 20; i++) {
			arquivoURL[i] = Application.persistentDataPath + "//p"+i+".dat";
		
		}
	}
	public void salvar(){
		numeroDeNicksSalvos = PlayerPrefs.GetInt("numeroDeNicksSalvos");


		if (numeroDeNicksSalvos < 20) { // por enquanto vai ser assim
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Create (arquivoURL [numeroDeNicksSalvos]);
			numeroDeNicksSalvos++;
			PlayerPrefs.SetInt ("numeroDeNicksSalvos", numeroDeNicksSalvos);

			DadosPlayer data = new DadosPlayer ();

			data.nick = this.nick;
			data.pontos = this.pontos;

			bf.Serialize (file, data);


			file.Close ();
		} else {
			//quando for maior que 20 ainda nao esta resolvido
		
		}

	
	}

	public Jogador[] carregarDadosPlayer(){
		
		for (int i = 0; i < PlayerPrefs.GetInt ("numeroDeNicksSalvos"); i++) {
			if (File.Exists (arquivoURL[i])) {
				BinaryFormatter bf = new BinaryFormatter ();
				FileStream file = File.Open (arquivoURL[i], FileMode.Open);

				DadosPlayer data = (DadosPlayer)bf.Deserialize (file);
				file.Close ();

				this.nick = data.nick;
				this.pontos = data.pontos;

				jogadores [i] = new Jogador (this.nick, this.pontos);

			}

		}
		return jogadores;
			
	
	}
	public void setNick(string nick){
		this.nick = nick;
	
	}
	public string getNick(){
		return this.nick;
	
	}

	public void setPontos(int p){
		this.pontos = p;
	
	}
	public int getPontos(){
		return this.pontos;
	
	}
	public int getNumeroDeJogadoresSalvos(){
		numeroDeNicksSalvos = PlayerPrefs.GetInt("numeroDeNicksSalvos");
		return this.numeroDeNicksSalvos;

	}

}














