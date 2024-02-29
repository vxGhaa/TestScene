using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//cek cek test

public class SceneA : MonoBehaviour
{
    public void GoToSceneB()
    {
        SceneManager.LoadScene("SceneB");
    }
}
