using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {
	
	Vector3 direccion = new Vector3(1f,1f,0f);
	Vector3 transportar= new Vector3(0f,0f,0f);

	float velocidad;

	// Use this for initialization
	void Start () {
		velocidad = Random.Range (1f, 5f);
	}

	// Update is called once per frame
	void Update () {

		transform.Translate(direccion * Time.deltaTime * velocidad);

		if (transform.position.x < -5) {
			transportar.x=5;
			transportar.y=transform.position.y;
			transform.position=transportar;
		} else if (transform.position.x > 5) {
			transportar.x=-5;
			transportar.y=transform.position.y;
			transform.position=transportar;
		}else if(transform.position.y<-5){
			transportar.y=5;
			transportar.x=transform.position.x;
			transform.position=transportar;
		}else if(transform.position.y>5){
			transportar.y=-5;
			transportar.x=transform.position.x;
			transform.position=transportar;
		}
	}
}
