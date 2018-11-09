using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SplashToTitle : MonoBehaviour {


	void Start () {
		StartCoroutine (SokolToMenu());
	}

	IEnumerator SokolToMenu()
	{
		yield return new WaitForSeconds (4);
		SceneManager.LoadScene (1);
	}
}

