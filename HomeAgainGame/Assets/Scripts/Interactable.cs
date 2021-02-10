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
        if (collision.CompareTag("Player") && gameObject.tag == "view")
            collision.GetComponent<May_control_script>().OpenInteractableIcon();

        if (collision.CompareTag("Player") && gameObject.tag == "light")
            collision.GetComponent<May_control_script>().OpenInteractableIconlight();

        else if (collision.CompareTag("Player") && gameObject.tag == "Door")
            collision.GetComponent<May_control_script>().OpenInteractableIcondoor();



        Debug.Log(collision.name + "Enter");
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player") && gameObject.tag == "view")
            collision.GetComponent<May_control_script>().CloseInteractableIcon();

        if (collision.CompareTag("Player") && gameObject.tag == "light")
            collision.GetComponent<May_control_script>().CloseInteractableIconlight();

        if (collision.CompareTag("Player") && gameObject.tag == "Door")
            collision.GetComponent<May_control_script>().CloseInteractableIcondoor();

        Debug.Log(collision.name + "Exit");
    }

    private void Start()
    {

    }
}
