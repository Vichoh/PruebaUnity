using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float jumpVelocity;
	private Rigidbody rb;
	public bool isGrounded;

		private GameObject GM;
	private GameManagerScript GM_S;
	
	 
	void Awake () {
		rb = GetComponent<Rigidbody>();
	}

	void Start () {
		GM = GameObject.Find("GameManager");
		GM_S = GM.GetComponent<GameManagerScript>();
	}
	
	/*Utilizar este metodo para manejar todo lo relacionado con fisica */
	void FixedUpdate () {
		isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.5f);
		InputHandler();
	}

	void InputHandler()
	{
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			rb.velocity = new Vector3(-1 * speed, rb.velocity.y, 0);
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			rb.velocity = new Vector3(1 * speed, rb.velocity.y, 0);
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			rb.velocity = new Vector3(0, rb.velocity.y, 1 * speed);
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			rb.velocity = new Vector3(0, rb.velocity.y, -1 * speed);
		}
		if(Input.GetKey(KeyCode.Escape))
		{
			SceneManager.LoadScene(1);
		}




	}

	void OnCollisionEnter(Collision other)
	{
		//Revisa el tag del objeto con el que colisiono
		if(other.gameObject.tag == "Box8")
		{
			Debug.Log("torre1");
			GM_S.SetTextTorre("Perdiste Por que colisionaste con una torre");
			 StartCoroutine(MyMethod());
			SceneManager.LoadScene(1);
		}
		if(other.gameObject.tag == "roca")
		{
			Debug.Log("roca");

			GM_S.SetTextTorre("Ganaste");
			 new WaitForSeconds(2);
			SceneManager.LoadScene(1);
		}
	}

	IEnumerator MyMethod() {
  Debug.Log("Before Waiting 2 seconds");
  yield return new WaitForSeconds(2);
  Debug.Log("After Waiting 2 Seconds");
 }

}
