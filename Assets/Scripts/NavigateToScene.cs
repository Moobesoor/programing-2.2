using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigateToScene : MonoBehaviour {

    [SerializeField]

    string SceneToLoad;

	public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
