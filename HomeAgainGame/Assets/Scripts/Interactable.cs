using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public abstract class Interactable : MonoBehaviour
{
    Collider collision;

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

        if (collision.CompareTag("Player") && gameObject.tag == "Door")
            collision.GetComponent<May_control_script>().OpenInteractableIcondoor();

        if (collision.CompareTag("Player") && gameObject.tag == "stairs")
            collision.GetComponent<May_control_script>().OpenInteractableIconstairs();

        if (collision.CompareTag("Player") && gameObject.tag == "grab_object") 
            collision.GetComponent<May_control_script>().OpenInteractableIcongrab();

        if (collision.CompareTag("Player") && gameObject.tag == "To_livingroom")
            collision.GetComponent<May_control_script>().OpenInteractableIconToLivingRoom();

        if (collision.CompareTag("Player") && gameObject.tag == "To_lobby")
            collision.GetComponent<May_control_script>().OpenInteractableIconToLobby();




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

        if (collision.CompareTag("Player") && gameObject.tag == "stairs")
            collision.GetComponent<May_control_script>().CloseInteractableIconstairs();

        if (collision.CompareTag("Player") && gameObject.tag == "grab_object")
            collision.GetComponent<May_control_script>().CloseInteractableIcongrab();

        if (collision.CompareTag("Player") && gameObject.tag == "To_livingroom")
            collision.GetComponent<May_control_script>().CloseInteractableIconToLivingRoom();

        if (collision.CompareTag("Player") && gameObject.tag == "To_lobby")
            collision.GetComponent<May_control_script>().CloseInteractableIconToLobby();



        Debug.Log(collision.name + "Exit");
    }



       
}
