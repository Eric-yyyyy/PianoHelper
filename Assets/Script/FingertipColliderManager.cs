using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingertipColliderManager : MonoBehaviour
{
    public OVRSkeleton skeleton; // Assign this to your OVRHandPrefab

    // Size of the collider
    public float colliderRadius = 0.01f;
    public bool displayColliders = true;

    void Start()
    {
        // Find each fingertip bone in the skeleton
        foreach (var bone in skeleton.Bones)
        {
            if (IsFingertip(bone.Id))
            {
                AddSphereCollider(bone.Transform);
            }
        }
    }

    // Check if the bone is a fingertip
    bool IsFingertip(OVRSkeleton.BoneId boneId)
    {
        return boneId == OVRSkeleton.BoneId.Hand_ThumbTip ||
               boneId == OVRSkeleton.BoneId.Hand_IndexTip ||
               boneId == OVRSkeleton.BoneId.Hand_MiddleTip ||
               boneId == OVRSkeleton.BoneId.Hand_RingTip ||
               boneId == OVRSkeleton.BoneId.Hand_PinkyTip;
    }

    // Add a sphere collider to a given fingertip transform
    void AddSphereCollider(Transform fingertip)
    {
        SphereCollider collider = fingertip.gameObject.AddComponent<SphereCollider>();
        collider.radius = colliderRadius;

        // If you want to visualize the collider in the XR
        if (displayColliders)
        {
            var sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.SetParent(fingertip);
            sphere.transform.localPosition = Vector3.zero;
            sphere.transform.localScale = Vector3.one * colliderRadius * 2;
            Destroy(sphere.GetComponent<Collider>()); // Remove the extra collider
        }
    }
}
