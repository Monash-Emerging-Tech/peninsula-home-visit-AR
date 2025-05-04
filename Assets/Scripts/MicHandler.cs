using UnityEngine;
using System;

/** Uses code from https://medium.com/university-of-games/capturing-audio-from-a-microphone-in-unity3d-263f7312f030 **/
public class MicHandler : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        string[] devices = Microphone.devices;
        for(int i = 0; i < devices.Length; i++)
        {
            Debug.Log("Name: " + devices[i]);
        }

        // WARNING: The mic choice is hardcoded here, as in future it will be a stream input from a headset
        try
        {
            AudioClip mic = Microphone.Start(devices[0], true, 20, 44100);
            audioSource.clip = mic;
            audioSource.Play();
        }
        catch(Exception e)
        {
            Debug.Log("Cannot find mic");
            print(e);
        }

    }
}
