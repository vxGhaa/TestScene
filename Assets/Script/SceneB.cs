using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//data
public class SceneB : MonoBehaviour
{
    public void GoToSceneA()
    {
        SceneManager.LoadScene("SceneA");
    }
}
