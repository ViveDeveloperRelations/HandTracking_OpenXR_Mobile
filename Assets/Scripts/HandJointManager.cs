using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wave.OpenXR.Toolkit;
using Wave.OpenXR.Toolkit.Hand;

public class HandJointManager : MonoBehaviour
{
    [SerializeField] private HandJoint[] leftHandJoints;
    [SerializeField] private HandJoint[] rightHandJoints;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftHandJoints = HandTracking.GetHandJointLocations(HandFlag.Left);
        rightHandJoints = HandTracking.GetHandJointLocations(HandFlag.Right);
    }

    public HandJoint GetJoint(bool isLeft, int jointNum)
    {
        return isLeft ? leftHandJoints[jointNum] : rightHandJoints[jointNum];
    }
}
