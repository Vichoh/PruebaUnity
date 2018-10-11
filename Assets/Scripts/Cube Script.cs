using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

	public GameObject coinCounter;
	public ScoreScript coinCounter_C;

	public GameObject item;

	void Start () {
		coinCounter = GameObject.Find("CoinCounter");
		coinCounter_C = coinCounter.GetComponent<ScoreScript>();
	}
	
	void Update () {
		
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Player")
		{
			Debug.Log("Colisione con el jugador!");
			Instantiate(item, new Vector3(transform.position.x, transform.position.y + 2f, 
			transform.position.z), Quaternion.identity);
			//Llamos al contador
			coinCounter_C.SumarMonedas();
		}
		else 
		{
			Debug.Log("Colisione con: " + other.gameObject.name);
		}
	}

}
