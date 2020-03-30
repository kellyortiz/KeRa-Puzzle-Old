using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips;

    private int correct_index;

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

    public void ButtonClicked(int id)
    {
        if (id == correct_index)
        {
            Debug.Log("Certa");
        }
        else
        {
            Debug.Log("Errado");
        }
    }
}
