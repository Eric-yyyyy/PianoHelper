using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FollowCenterEye : MonoBehaviour
{
    public Transform centerEyeAnchor;    // Center Eye Anchor reference
    public float distance = 3.0f;        // Distance in front of the Center Eye
    public float rotationThreshold = 30f; // Rotation angle threshold
    public Toggle VRToggle;

    private Quaternion lastRecordedRotation;
    private Vector3 initialPosition;     // Initial position of the canvas
    private Quaternion initialRotation;  // Initial rotation of the canvas

    void Start()
    {
        // Store the initial position and rotation of the canvas
        initialPosition = transform.position;
        initialRotation = transform.rotation;

        if (!VRToggle.isOn)
        {
            if (centerEyeAnchor != null)
            {
                // Store the initial rotation of the center eye
                lastRecordedRotation = centerEyeAnchor.rotation;
                UpdateCanvasPosition();
            }
        }
    }

    void Update()
    {
        if (VRToggle.isOn)
        {
            // If VRToggle is on, reset the canvas to its initial position and rotation
            ResetCanvasToInitialPosition();
        }
        else
        {
            if (centerEyeAnchor != null)
            {
                // Calculate the angle between the current and last recorded rotation
                float angleDifference = Quaternion.Angle(lastRecordedRotation, centerEyeAnchor.rotation);

                // If the angle difference exceeds the threshold, update the canvas position
                if (angleDifference > rotationThreshold)
                {
                    UpdateCanvasPosition();

                    // Update last recorded rotation
                    lastRecordedRotation = centerEyeAnchor.rotation;
                }
            }
        }
    }

    void UpdateCanvasPosition()
    {
        // Position the canvas at a fixed distance in front of the center eye
        transform.position = centerEyeAnchor.position + centerEyeAnchor.forward * distance;

        // Make the canvas face the center eye anchor
        transform.rotation = Quaternion.LookRotation(transform.position - centerEyeAnchor.position);
    }

    void ResetCanvasToInitialPosition()
    {
        // Reset the canvas to its initial position and rotation
        transform.position = initialPosition;
        transform.rotation = initialRotation;
    }
}
