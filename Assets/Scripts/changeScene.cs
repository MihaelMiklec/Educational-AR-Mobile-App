using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public string scene;
	
	public void goTo() {
		SceneManager.LoadScene(scene,LoadSceneMode.Single);
	}
}
