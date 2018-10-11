using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Script : MonoBehaviour {

	public float speed;
	private GameObject GM;
	private GameManagerScript GM_S;

	void Start () {
		GM = GameObject.Find("GameManager");
		GM_S = GM.GetComponent<GameManagerScript>();
	}
	
	// Metodo llamado cada frame
	void Update () {
		/*Rota el objeto a una velocidad x (speed).
		*Se utiliza Time.deltaTime para que la velocidad del giro sea independiente
		*A la potencia del procesador 
		*/
		
	}

	/*Metodo utilzado para manejar colisiones.
	*-El parametro "other" representa todas las colisiones (por frame) por 
	la cual este objeto interactua.
	*-Las colisiones se miden utilizando el "collider" del objeto.
	*-Recordar que para que las colisiones se registren, el objeto 
	*debe tener un rigidbody.	
	*/
	void OnCollisionEnter(Collision other)
	{
		//Revisa el tag del objeto con el que colisiono
		if(other.gameObject.tag == "Player")
		{
			/*Destruye al objeto una vez que colisiona con un objeto taggeado como
			"Player"
			*/
			
			GM_S.SetTime(30);
			GM_S.SetTextTorre("Mas 30 segundos");

			 GM_S.SetTextTorre("");
			Destroy(this.gameObject);
		}
	}

}
