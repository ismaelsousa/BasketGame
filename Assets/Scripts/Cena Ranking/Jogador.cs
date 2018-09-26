using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador{

	private string nick;
	private int pontos;

	public Jogador(string nick, int pontos){
		this.nick = nick;
		this.pontos = pontos;
	
	}
	public string getNick(){
		return nick;
	
	}
	public int getPontos(){
		return pontos;

	}
	public void setPontos(int p){
		this.pontos = p;

	}
	public void setNick(string n){
		this.nick = n;

	}
}
