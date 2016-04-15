using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Loading : MonoBehaviour {

    public string sceneName;

    IEnumerator Start () {
        yield return new WaitForSeconds(1f);
        sceneName = "Game";
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
