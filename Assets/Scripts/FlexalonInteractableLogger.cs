using Flexalon;
using UnityEngine;

public class FlexalonInteractableLogger : MonoBehaviour
{
    void Awake()
    {
        var interactable = GetComponent<FlexalonInteractable>();
        interactable.HoverStart.AddListener((i) => Debug.Log("Hover Start: " + name));
        interactable.HoverEnd.AddListener((i) => Debug.Log("Hover End: " + name));
        interactable.SelectStart.AddListener((i) => Debug.Log("Select Start: " + name));
        interactable.SelectEnd.AddListener((i) => Debug.Log("Select End: " + name));
        interactable.DragStart.AddListener((i) => Debug.Log("Drag Start: " + name));
        interactable.DragEnd.AddListener((i) => Debug.Log("Drag End: " + name));
        interactable.Clicked.AddListener((i) => Debug.Log("Click: " + name));
    }
}