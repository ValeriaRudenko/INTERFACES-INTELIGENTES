using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebcamController : MonoBehaviour
{   
    private Material screenMaterial;
    public string capturePath;
    private WebCamTexture webcamTexture;
    private int captureCounter = 1;
    private bool isWebcamActive = false;

    // Start is called before the first frame update
    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        webcamTexture = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();
        screenMaterial = renderer.material;
        capturePath = "C:\\";
        isWebcamActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("s")) { // Activate webcam
            if (!isWebcamActive) {
                isWebcamActive = true;
                screenMaterial.mainTexture = webcamTexture;
                webcamTexture.Play();
            }
        }

        if (Input.GetKey("p")) { // Pause webcam
            if (isWebcamActive) {
                isWebcamActive = false;
                webcamTexture.Stop();
            }
        }

        if (Input.GetKey("x")) { // Take screenshot
            if (isWebcamActive) {
                Texture2D snapshot = new Texture2D(webcamTexture.width, webcamTexture.height);
                snapshot.SetPixels(webcamTexture.GetPixels());
                snapshot.Apply();
                System.IO.File.WriteAllBytes(capturePath + captureCounter.ToString() + ".png", snapshot.EncodeToPNG());
                ++captureCounter;
                Debug.Log(capturePath + captureCounter.ToString());
            } 
        }
    }
}
