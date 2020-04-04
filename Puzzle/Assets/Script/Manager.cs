using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public Canvas Win;

    public int correct_index;

    void Start()
    {
        correct_index = Random.Range(0, audioClips.Length);
        audioSource.clip = audioClips[correct_index];
        Debug.Log(correct_index);
        
    }

    public void PlayClicked()
    {
        audioSource.Play();
    }

    public void ButtonClicked(int id, Canvas Win)
    {
       
            if (id == correct_index)
        {
            Win = GetComponent<Canvas>();
            Debug.Log(Win.enabled);
          //  Debug.Log("Certa");
        }
        else
        {
            Debug.Log("Errado");
        }
    }
}
