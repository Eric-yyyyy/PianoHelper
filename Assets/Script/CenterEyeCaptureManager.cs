using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenCvSharp;

public class CenterEyeCaptureManager : MonoBehaviour
{
    public Camera centerEyeCamera;  // Reference to the CenterEyeAnchor camera
    public RenderTexture renderTexture;  // Reference to the RenderTexture

    private int frameCounter = 0;
    private int frameInterval = 10;  // Process every 10 frames for performance

    void Start()
    {
        // Ensure the render texture is assigned
        if (renderTexture == null)
        {
            renderTexture = new RenderTexture(Screen.width, Screen.height, 24);  // Use a smaller resolution for performance
            centerEyeCamera.targetTexture = renderTexture;  // Assign the RenderTexture to the CenterEye camera
        }
    }

    void Update()
    {
        frameCounter++;
        if (frameCounter % frameInterval == 0)  // Process frame less frequently for performance
        {
            // Convert the RenderTexture to a Texture2D
            Texture2D texture2D = RenderTextureToTexture2D(renderTexture);

            // Convert the Texture2D to OpenCV Mat for further processing
            Mat frame = OpenCvSharp.Unity.TextureToMat(texture2D);
            ProcessFrame(frame);
        }
    }

    // Convert RenderTexture to Texture2D
    private Texture2D RenderTextureToTexture2D(RenderTexture rTex)
    {
        RenderTexture currentRT = RenderTexture.active;
        RenderTexture.active = rTex;

        // Create a new Texture2D and read pixels from the RenderTexture
        Texture2D texture = new Texture2D(rTex.width, rTex.height, TextureFormat.RGB24, false);
        texture.ReadPixels(new UnityEngine.Rect(0, 0, rTex.width, rTex.height), 0, 0);
        texture.Apply();

        RenderTexture.active = currentRT;
        return texture;
    }

    // Custom function to process the captured frame using OpenCV
    private void ProcessFrame(Mat frame)
    {
        // Example: Convert the frame to grayscale
        Mat grayFrame = new Mat();
        Cv2.CvtColor(frame, grayFrame, ColorConversionCodes.BGR2GRAY);

        // Example: Apply Canny edge detection
        Mat edges = new Mat();
        Cv2.Canny(grayFrame, edges, 50, 150);

        // Debugging: Print information when frame is processed
        Debug.Log("Processed a frame from the CenterEye camera using OpenCV.");
    }
}
