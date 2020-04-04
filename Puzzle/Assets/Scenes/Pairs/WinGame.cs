using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    public int correct_index;

    public GameObject win;

    void Start()
    {
        win.SetActive(false);
    }

    public void Win(int id)
    {
        if (id == correct_index) { }
           // win.SetActive(true);
    }

    public void Proximo(string scene)
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
