using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creador : MonoBehaviour {

	public GameObject aste;
	float tiempo, frecuencia;
	Vector3 posicion = new Vector3(0,0,0);

	// Use this for initialization
	void Start () {
		frecuencia = 3f;
		tiempo = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (tiempo > frecuencia) {
			Instantiate (aste, transform.position, Quaternion.identity, transform);
			tiempo = 0;
		} else {
			tiempo += Time.deltaTime;

		}
		
	}
}
