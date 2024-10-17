using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoPlacement : MonoBehaviour
{
    public OVRHand leftHand;  // OVRHand for the left hand
    public OVRHand rightHand; // OVRHand for the right hand
    public GameObject piano;   // Reference to your piano object
    public float grabDistanceThreshold = 0.2f;  // Distance threshold for grabbing (in meters)
    private bool isGrabbingLeft;
    private bool isGrabbingRight;

    private Vector3 pianoOffset; // Offset to maintain relative movement
    private Quaternion pianoRotationOffset; // Offset for rotation
    private bool isHoldingPiano = false;
    private float smoothSpeed = 5f; // Adjust for how smooth the movement should be

    void Update()
    {
        // Check if the left or right hand is pinching (used for grabbing)
        isGrabbingLeft = leftHand.GetFingerIsPinching(OVRHand.HandFinger.Index);  // Detect if left hand is pinching
        isGrabbingRight = rightHand.GetFingerIsPinching(OVRHand.HandFinger.Index); // Detect if right hand is pinching

        if (isGrabbingLeft && !isHoldingPiano && IsTouchingPiano(leftHand))
        {
            StartGrab(leftHand);
        }
        else if (isGrabbingRight && !isHoldingPiano && IsTouchingPiano(rightHand))
        {
            StartGrab(rightHand);
        }
        else if (!isGrabbingLeft && !isGrabbingRight && isHoldingPiano)
        {
            EndGrab();
        }

        if (isHoldingPiano)
        {
            MoveAndRotatePianoWithHand();
        }
    }

    void StartGrab(OVRHand hand)
    {
        // Calculate the offset between the hand and the piano when starting to grab
        pianoOffset = piano.transform.position - hand.transform.position;
        pianoRotationOffset = Quaternion.Inverse(hand.transform.rotation) * piano.transform.rotation; // Store rotation offset
        isHoldingPiano = true; // Mark that the piano is currently being held
    }

    void EndGrab()
    {
        // When the grab stops, release the piano
        isHoldingPiano = false;
    }

    void MoveAndRotatePianoWithHand()
    {
        // Move and rotate the piano smoothly while maintaining the offset
        OVRHand activeHand = isGrabbingLeft ? leftHand : rightHand; // Determine which hand is holding

        // Calculate the target position and rotation
        Vector3 targetPosition = activeHand.transform.position + pianoOffset;
        Quaternion targetRotation = activeHand.transform.rotation * pianoRotationOffset;

        // Smoothly move the piano to the new position and rotation
        piano.transform.position = Vector3.Lerp(piano.transform.position, targetPosition, smoothSpeed * Time.deltaTime);
        piano.transform.rotation = Quaternion.Slerp(piano.transform.rotation, targetRotation, smoothSpeed * Time.deltaTime);
    }

    bool IsTouchingPiano(OVRHand hand)
    {
        // Check the distance between the hand and the piano
        float distance = Vector3.Distance(hand.transform.position, piano.transform.position);

        // Only allow grabbing if the hand is within the distance threshold
        return distance <= grabDistanceThreshold;
    }
}
