using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lancador : MonoBehaviour {
	private float tempo;
	public float tempoDeMudarPosicaoDoLancador;
	public List<GameObject> obstaculos;
	private int tamListaObs;
	// Use this for initialization
	void Start () {
		tempo = 0;
		tamListaObs = obstaculos.Count;
	}
	
	// Update is called once per frame
	void Update () {
		tempo += Time.deltaTime;

		if (tempo > tempoDeMudarPosicaoDoLancador) {
			this.transform.position = new Vector2 (Random.Range (-2.5f, 2.5f), this.transform.position.y);
			Instantiate (obstaculos [Random.Range (0, tamListaObs)], this.transform.position, Quaternion.identity);
			tempo = 0;
		}
	}
}
