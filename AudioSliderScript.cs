using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSliderScript : MonoBehaviour
{
    [Header("Master Volume")]
    public Slider masterVolume;
    public AudioSource masterSound;

    [Header("Game Music")]
    public Slider musicVolume;
    public AudioSource musicSound;

    [Header("Button Sounds")]
    public Slider buttonSoundVolume;
    public AudioSource buttonSound;

    [Header("SFX Sounds")]
    public Slider sfxSoundVolume;
    public AudioSource sfxSound;

    // Start is called before the first frame update
    void Awake()
    {
        masterVolume.value = PlayerPrefs.GetFloat("masterVolume", .25f);
        musicVolume.value = PlayerPrefs.GetFloat("musicVolume", .25f);
        buttonSoundVolume.value = PlayerPrefs.GetFloat("buttonVolume", 1f);
        sfxSoundVolume.value = PlayerPrefs.GetFloat("sfxVolume", .5f);
    }

    public void OnSliderChange(float newValue)
    {
        PlayerPrefs.SetFloat("masterVolume", newValue);
        PlayerPrefs.SetFloat("musicVolume", newValue);
        PlayerPrefs.SetFloat("buttonVolume", newValue);
        PlayerPrefs.SetFloat("sfxVolume", newValue);
    }

    // Update is called once per frame
    void Update()
    {
        //////////***** MASTER SOUND *****//////////
        masterSound.volume = masterVolume.value;

        //////////***** MAIN MENU MUSIC *****//////////
        if(masterVolume.value < musicVolume.value)
        {
            musicSound.volume = masterVolume.value;
        }
        else
        {
            musicSound.volume = musicVolume.value;
        }

        //////////***** ALL BUTTONS *****//////////
        if (masterVolume.value < buttonSoundVolume.value)
        {
            buttonSound.volume = masterVolume.value;
        }
        else
        {
            buttonSound.volume = buttonSoundVolume.value;
        }

        //////////***** ALL SFX *****//////////
        if (masterVolume.value < sfxSoundVolume.value)
        {
            sfxSound.volume = masterVolume.value;
        }
        else
        {
            sfxSound.volume = sfxSoundVolume.value;
        }

    }

    public void OnSaveButtonClick()
    {
        PlayerPrefs.SetFloat("masterVolume", masterVolume.value);
        Debug.Log("Saved master volume..");

        PlayerPrefs.SetFloat("musicVolume", musicVolume.value);
        Debug.Log("Saved menu music volume..");

        PlayerPrefs.SetFloat("buttonVolume", buttonSoundVolume.value);
        Debug.Log("Saved button volume..");

        PlayerPrefs.SetFloat("sfxVolume", sfxSoundVolume.value);
        Debug.Log("Saved button volume..");
    }
}
