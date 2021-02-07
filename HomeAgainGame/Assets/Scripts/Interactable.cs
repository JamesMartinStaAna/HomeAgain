using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public abstract class Interactable : MonoBehaviour
{
    public void Reset()
    {
        GetComponent<BoxCollider>().isTrigger = true;
    }

    public abstract void Interact();

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
            collision.GetComponent<May_control_script>().OpenInteractableIcon();

        Debug.Log(collision.name + "Enter");
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
            collision.GetComponent<May_control_script>().CloseInteractableIcon();

        Debug.Log(collision.name + "Exit");
    }

}
