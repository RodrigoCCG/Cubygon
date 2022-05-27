using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBehavior : MonoBehaviour
{
    public AudioClip playSong;
    public AudioClip gameOverSong;
    public AudioSource audioS;
    // Start is called before the first frame update
    void Start()
    {
        audioS.Stop();
        audioS.clip = playSong;
        audioS.Play();
    }

    // Update is called once per frame
    public void playGameOver(){
        audioS.Stop();
        audioS.clip = gameOverSong;
        audioS.Play();
    }
}
