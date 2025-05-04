using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Networking;

/** Will locate forst camera device PC is connected to via WebCamTexture inbuilt lib, uses the combined scaffolding efforts of https://stackoverflow.com/questions/19482481/display-live-camera-feed-in-unity **/
public class CamStream : MonoBehaviour
{

    UnityWebRequest webRequest;
    byte[] bytes = new byte[90000];

    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        for (var i = 0; i < devices.Length; i++) {
            print("Webcam available: " + devices[i].name);
        }

        WebCamTexture tex = new WebCamTexture(devices[0].name);

        RawImage m_rawImage;
        m_rawImage = GetComponent<RawImage>();
        m_rawImage.texture = tex;
        tex.Play();
    }
}