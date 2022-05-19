using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioCtl : MonoBehaviour
{
    public viewAudio viewaudio;
    private void Awake()
    {
        viewaudio = GameObject.Find("Audio").GetComponent<viewAudio>();
        viewaudio.MainMenu.Play();
    }

    public void playAudiobg()
    {
        viewaudio.bg.Play();
    }
    public void pauseAudiobg()
    {
        viewaudio.bg.Pause();
    }
    public void playAudioitem()
    {
        viewaudio.item.Play();
    }
    public void playAudioskill()
    {
        viewaudio.skill.Play();
    }
    public void playAudiobreak()
    {
        viewaudio.breaking.Play();
    }
    public void playAudiohurt()
    {
        viewaudio.hurt.Play();
    }
    public void playAudiogameover()
    {
        viewaudio.gameover.Play();
    }
    public void playAudiowingame()
    {
        viewaudio.win.Play();
    }
    public void playAudioMenu()
    {
        viewaudio.MainMenu.Play();
    }
    public void pauseAudioMenu()
    {
        viewaudio.MainMenu.Pause();
    }
}
