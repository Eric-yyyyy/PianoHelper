using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recenter : MonoBehaviour
{
   public void RecenterCamera()
    {
        if (OVRManager.display != null)
        {
            OVRManager.display.RecenterPose();
            Debug.Log("Camera recentered.");
        }
        else
        {
            Debug.LogError("OVRManager.display is not available. Ensure OVRManager is in your scene.");
        }
    }
}
