using UnityEngine;
using Wave.OpenXR.Toolkit;
using Wave.OpenXR.Toolkit.Hand;

public class JointMovement : MonoBehaviour
{
    public int jointNum;
    public bool isLeft;

    void Update()
    {
        HandJoint joint = HandTracking.GetHandJointLocations(isLeft ? HandFlag.Left : HandFlag.Right)[jointNum];
        if (joint.isValid)
        {
            transform.position = joint.position;
            transform.rotation = joint.rotation;
        }
    }
}
