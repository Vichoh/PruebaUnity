using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObjetoFinalScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other)
	{
		//Revisa el tag del objeto con el que colisiono
		if(other.gameObject.tag == "Player")
		{
			Debug.Log("Final");
			if(Input.GetKey(KeyCode.Return))
			{
				Debug.Log("enter");
				SceneManager.LoadScene(0);
			}
			
		}
	}
}
