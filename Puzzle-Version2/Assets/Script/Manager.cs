using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Manager : MonoBehaviour
{
    public GameObject win, gameover;
    public Image Image1, Image2;
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
            //Elimina a possibilidade de clicar nas imagens e som
            Image1.enabled = false;
            Image2.enabled = false;
            audioSource.enabled = false;          
            
            win.gameObject.SetActive(true);
            Debug.Log("Certa");
        }
            
        
        else
        {
            Image1.enabled = false;
            Image2.enabled = false;
            audioSource.enabled = false;
            
            gameover.gameObject.SetActive(true);
            Debug.Log("Errado");
        }
    }

}
