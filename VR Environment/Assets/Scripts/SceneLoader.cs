using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public string sceneName;

    // Start is called before the first frame update
    public void loadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
