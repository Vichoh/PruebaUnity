using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

	public int contadorMonedas;

	void Start () {
		contadorMonedas = 0;
	}
	

	void Update () {
		
	}

	public void SumarMonedas() 
	{
		contadorMonedas++;
		Debug.Log("Monedas Actuales: " + contadorMonedas);
	}

}
