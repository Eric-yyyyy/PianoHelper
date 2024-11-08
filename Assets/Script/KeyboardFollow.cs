using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class KeyboardFollow : MonoBehaviour
{
    public Transform canvasTransform;       // Reference to the canvas transform
    public float extraDistance = 10000f;      // Extra distance to ensure keyboard is outside canvas bounds
    public Vector3 offset = new Vector3(0, -0.2f, 0);  // Additional offset to adjust height and position

    private RectTransform canvasRectTransform; // To access the canvas size

    void Start()
    {
        // Get the RectTransform component from the canvas
        canvasRectTransform = canvasTransform.GetComponent<RectTransform>();

        if (canvasRectTransform == null)
        {
            Debug.LogError("Canvas RectTransform not found. Ensure the canvas is set to World Space.");
        }
    }

    void Update()
    {
        if (canvasTransform != null && canvasRectTransform != null)
        {
            // Use the width of the canvas as the forward distance in world space
            float canvasDepth = canvasRectTransform.rect.width * canvasTransform.lossyScale.x;
            float safeDistance = canvasDepth / 2 + extraDistance;

            // Position the keyboard in front of the canvas with calculated distance and offset
            Vector3 forwardPosition = canvasTransform.position + canvasTransform.forward * safeDistance;
            transform.position = forwardPosition + offset;

            // Rotate the keyboard to face the same direction as the canvas
            transform.rotation = Quaternion.LookRotation(canvasTransform.forward, Vector3.up);
        }
    }
}
