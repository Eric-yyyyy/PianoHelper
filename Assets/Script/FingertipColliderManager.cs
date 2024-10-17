using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FingertipColliderManager : MonoBehaviour
{
    public OVRSkeleton handSkeleton;  // Reference to the OVR Skeleton
    public float colliderRadius = 0.01f;  // Adjust size of the fingertip collider
    public string fingertipTag = "Fingertip";  // Tag to assign to fingertip colliders

    private Dictionary<OVRSkeleton.BoneId, Transform> fingertipTransforms;

    void Start()
    {
        fingertipTransforms = new Dictionary<OVRSkeleton.BoneId, Transform>();

        // Add colliders to all fingertips
        AddFingertipColliders();
    }

    void AddFingertipColliders()
    {
        // List of fingertip bones based on the BoneId
        OVRSkeleton.BoneId[] fingertipIds = {
            OVRSkeleton.BoneId.Hand_IndexTip,
            OVRSkeleton.BoneId.Hand_MiddleTip,
            OVRSkeleton.BoneId.Hand_RingTip,
            OVRSkeleton.BoneId.Hand_PinkyTip,
            OVRSkeleton.BoneId.Hand_ThumbTip
        };

        // Loop through each bone in the skeleton
        foreach (var bone in handSkeleton.Bones)
        {
            if (System.Array.Exists(fingertipIds, id => id == bone.Id))
            {
                Transform fingertipTransform = bone.Transform;

                if (fingertipTransform != null)
                {
                    // Create a new SphereCollider
                    SphereCollider fingertipCollider = fingertipTransform.gameObject.AddComponent<SphereCollider>();
                    fingertipCollider.radius = colliderRadius;
                    fingertipCollider.isTrigger = true;

                    // Tag the fingertip colliders
                    fingertipTransform.gameObject.tag = fingertipTag;

                    // Add a small visible sphere to represent the collider
                    GameObject visualCollider = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    visualCollider.transform.SetParent(fingertipTransform);
                    visualCollider.transform.localPosition = Vector3.zero;
                    visualCollider.transform.localScale = new Vector3(colliderRadius * 2, colliderRadius * 2, colliderRadius * 2);

                    // Make the sphere semi-transparent for debugging purposes
                    Material transparentMaterial = new Material(Shader.Find("Transparent/Diffuse"));
                    transparentMaterial.color = new Color(0, 1, 0, 0.5f); // Green and semi-transparent
                    visualCollider.GetComponent<Renderer>().material = transparentMaterial;

                    // Store the transform reference for later usage (if needed)
                    fingertipTransforms[bone.Id] = fingertipTransform;
                }
            }
        }
    }

    void OnDrawGizmos()
    {
        if (fingertipTransforms != null)
        {
            Gizmos.color = Color.green;

            // Loop through each fingertip and draw the colliders in Scene view
            foreach (var fingertip in fingertipTransforms.Values)
            {
                if (fingertip != null)
                {
                    // Visualize the SphereCollider in the Scene view
                    Gizmos.DrawWireSphere(fingertip.position, colliderRadius);
                }
            }
        }
    }
}



