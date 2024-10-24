using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;
using UnityEngine.SceneManagement;


public class Audio : MonoBehaviour
{
    public GameObject resumeButton;

    public StudioEventEmitter Amb;
    public EventReference hoverSound;
    public EventReference buttonSFX1;
    public EventReference buttonSFX2;
    public EventReference buttonSFX3;
    public EventReference buttonSFX4;

    private bool ambStop;

    public void HoverSound()
    {
        RuntimeManager.PlayOneShot(hoverSound);
    }

    public void ButtonSFX1()
    {
        RuntimeManager.PlayOneShot(buttonSFX1);
    }

    public void ButtonSFX2()
    {
        RuntimeManager.PlayOneShot(buttonSFX2);
    }

    public void ButtonSFX3()
    {
        RuntimeManager.PlayOneShot(buttonSFX3);
    }

    public void ButtonSFX4()
    {
        RuntimeManager.PlayOneShot(buttonSFX4);
    }

    public void AmbPause()
    {
        resumeButton.SetActive(true);
        Amb.EventInstance.setPaused(true);
    }

    public void AmbResume()
    {
        resumeButton.SetActive(false);
        Amb.EventInstance.setPaused(false);
    }

    public void AmbRestart()
    {
        Amb.Play();
    }

    public void ChangeScene1()
    {
        SceneManager.LoadScene(0);
    }

    public void ChangeScene2()
    {
        SceneManager.LoadScene(1);
    }
}
