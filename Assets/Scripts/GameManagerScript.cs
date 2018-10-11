using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour {

	public Text timer_t;
	public Text torre_t;
	

	public float time;
	public string torre;

	

	void Start () {
		time = 30;
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if((int) time <= 0)
		{
			timer_t.text = "0";
			SceneManager.LoadScene(1);
		}
		else if((int)time > 0)
			timer_t.text = ((int)time).ToString();
	}

	public void SetTime(int amount)
	{
		time += amount;
		timer_t.text = time.ToString();
	}

		public void SetTextTorre(string amount)
	{
		torre += amount;
		torre_t.text = torre.ToString();
	}

	public float getTime () {
		return time;
	}



}


