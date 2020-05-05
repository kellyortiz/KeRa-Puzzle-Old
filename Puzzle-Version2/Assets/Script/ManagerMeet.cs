using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManagerMeet : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips;
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

}
