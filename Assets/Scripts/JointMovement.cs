using UnityEngine;
using Wave.OpenXR.Toolkit.Hand;

public class JointMovement : MonoBehaviour
{
    public int jointNum;
    public bool isLeft;
    private HandJointManager handJointManager;

    private void Start()
    {
        handJointManager = GameObject.Find("HandJointManager").GetComponent<HandJointManager>();
    }

    void Update()
    {
        HandJoint joint = handJointManager.GetJoint(isLeft, jointNum);
        if (joint.isValid)
        {
            transform.position = joint.position;
            transform.rotation = joint.rotation;
        }
    }
}
