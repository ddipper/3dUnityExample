using UnityEngine;

public class ObjectInteraction : MonoBehaviour, IInteractable
{
    void Start()
    {
        
    }


    void Update()
    {
        
    }
    
    public string GetDescription()
    {
        return "Press [E] to turn <color=green>take</color> object.";
    }

    public void Interact()
    {
        gameObject.SetActive(false);
    }
}
