using UnityEngine;
using System.Collections;

public class AddForcaABola : MonoBehaviour {

	public GameObject bola;
	public float forca = 15, distanciaMax = 3;
	Vector3 posicMouse;
	GameObject instanciaTemp;
	bool instanciou = false;
	public bool clicando = false;

	void Update () {
		if (Input.GetMouseButton (0)) {
			clicando = true;
			posicMouse = Camera.main.ScreenPointToRay (Input.mousePosition).GetPoint (0);
			posicMouse.z = transform.position.z;
			if (instanciou == false) {
				instanciou = true;
				instanciaTemp = Instantiate (bola, posicMouse, transform.rotation) as GameObject;
				instanciaTemp.GetComponent<Rigidbody2D> ().isKinematic = true;
			}
			if (Vector3.Distance (transform.position, posicMouse) < distanciaMax) { 
				instanciaTemp.transform.position = posicMouse;
			} else {
				Vector3 lugarCorreto = transform.position + (posicMouse - transform.position).normalized * distanciaMax;
				instanciaTemp.transform.position = lugarCorreto;
			}
		}

		if (Input.GetMouseButtonUp (0) && instanciou == true) {
			clicando = false;
			Vector3 direcao = transform.position - instanciaTemp.transform.position;
			instanciaTemp.GetComponent<Rigidbody2D> ().isKinematic = false;
			instanciaTemp.GetComponent<Rigidbody2D> ().AddForce (direcao * forca, ForceMode2D.Impulse);
			instanciou = false;
			instanciaTemp = null;
		}
	}
}
