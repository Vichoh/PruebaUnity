using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

  public GameObject mainMenu;
	public GameObject optionMenu;


	public Button[] mainMenuButtons = new Button[3];
	public int punteroFlecha = 0;

		private GameObject GM;
	private MenuManagerScript GM_S;

	// Use this for initialization
	void Start () {

				GM = GameObject.Find("MenuManager");
		GM_S = GM.GetComponent<MenuManagerScript>();



	

		

	}


	
	// Update is called once per frame
	void Update () {




		
	}



	public void PlayGame() 
	{
		SceneManager.LoadScene(0);
	}

	public void QuitGame()
	{
			Debug.Log("Se cerro el juego");
			Application.Quit();
	}

	public void LoadMainMenu()
	{	
		optionMenu.SetActive(false);
		mainMenu.SetActive(true);
	}

	public void LoadOptionMenu()
	{
		mainMenu.SetActive(false);
		optionMenu.SetActive(true);
	}
}
