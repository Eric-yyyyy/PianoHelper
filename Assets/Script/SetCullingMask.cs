using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCullingMask : MonoBehaviour
{
    public Camera myCamera; // Assign your camera here

    void Start()
    {
       
        myCamera.cullingMask = 0;
        Debug.Log("switch,success");
    }
}
