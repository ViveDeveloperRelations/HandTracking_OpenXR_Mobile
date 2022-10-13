using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Interactable : XRGrabInteractable
{
    private Color originalColor = Color.red;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = originalColor;
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
        base.OnSelectEntered(args);
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        gameObject.GetComponent<Renderer>().material.color = originalColor;
        base.OnSelectExited(args);
    }
}
