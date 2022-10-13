using UnityEngine;

public class ShowHands : MonoBehaviour
{
    public GameObject jointPrefab;
    public Transform leftHand;
    public Transform rightHand;

    void OnEnable()
    {
        GameObject temp;

        for (int i = 0; i < 26; i++)
        {
            temp = Instantiate(jointPrefab, leftHand);
            temp.GetComponent<JointMovement>().isLeft = true;
            temp.GetComponent<JointMovement>().jointNum = i;
        }

        for (int i = 0; i < 26; i++)
        {
            temp = Instantiate(jointPrefab, rightHand);
            temp.GetComponent<JointMovement>().isLeft = false;
            temp.GetComponent<JointMovement>().jointNum = i;
        }
    }
}
