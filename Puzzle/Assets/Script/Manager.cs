using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Manager : MonoBehaviour
{
   // public AudioSource win;
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public int correct_index;
    public bool playOnAwake;
    public AudioSource Win;

    void Start()
    {
        correct_index = Random.Range(0, audioClips.Length);
        audioSource.clip = audioClips[correct_index];
        Debug.Log(correct_index);
        Win.playOnAwake = false;
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
            Win.playOnAwake = true;
        }
        else
        {
            Debug.Log("Errado");
        }
    }
}
