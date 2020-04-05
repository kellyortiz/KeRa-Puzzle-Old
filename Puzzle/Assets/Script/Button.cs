using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class Button : MonoBehaviour
    {
    public GameObject button;

    void Start()
    {

    }
    public void Proximo(string scene)
        {
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        }
    }
