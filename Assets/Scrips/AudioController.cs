using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip DeadClip;
    [SerializeField] AudioClip WinClip;
    [SerializeField] PlayerHP Player;
    [SerializeField] GameManager GameManager;
    private void Start()
    {
            audioSource = GetComponent<AudioSource>();

          Player.PlayerLose += Lose;

          GameManager.PlayerWin += Win;
          
    }


   void Win()
    {
        audioSource.PlayOneShot(WinClip);
    }

    void Lose()
    {
        audioSource.PlayOneShot(DeadClip);
    }
}