using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Piece1 p1;
    [SerializeField]
    private Piece2 p2;
    [SerializeField]
    private Piece3 p3;
    [SerializeField]
    private Piece4 p4;

    public GameObject button;

    void Start()
    {
        p1 = (Piece1)FindObjectOfType(typeof(Piece1));
        p2 = (Piece2)FindObjectOfType(typeof(Piece2));
        p3 = (Piece3)FindObjectOfType(typeof(Piece3));
        p4 = (Piece4)FindObjectOfType(typeof(Piece4));

        button.SetActive(false);
    }

    public void IsGameOver()
    {
        if (p1.locked && p2.locked && p3.locked && p4.locked)
            button.SetActive(true);
    }

    public void ProximaFase(string scene)
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
