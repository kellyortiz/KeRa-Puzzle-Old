using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class audio : MonoBehaviour
    {
        AudioSource audioSource;

        void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
                audioSource.mute = !audioSource.mute;
        }
    }