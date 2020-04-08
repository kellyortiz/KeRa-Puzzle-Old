using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Manager : MonoBehaviour
{
    public GameObject win, gameover,pairs;
    public Button Image1, Image2;
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public int correct_index;
    

    void Start()
    {
        win.gameObject.SetActive(false);
        gameover.gameObject.SetActive(false);
        correct_index = Random.Range(0, audioClips.Length);
        audioSource.clip = audioClips[correct_index];
        Debug.Log(correct_index);
        
    }

    public void PlayClicked()
    {
        audioSource.Play();
    }
    
    public void ButtonClicked(int id)
    {
       
        if (id == correct_index)
        {
            Debug.Log("Certa");
            audioSource.Pause();
            win.gameObject.SetActive(true);
            pairs.gameObject.SetActive(false);

        }
        else
        {
            gameover.gameObject.SetActive(true);
            Debug.Log("Errado");
            audioSource.Pause();
            pairs.gameObject.SetActive(false);
        }
    }

}
