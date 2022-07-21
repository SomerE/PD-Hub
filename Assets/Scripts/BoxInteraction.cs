using UnityEngine;

public class BoxInteraction : Interactable
{
    private bool alreadyInteracted;
    private string colour = "white";

    public override void Interact()
    {
        //change colour
        if (Input.GetKeyDown(KeyCode.R))
        {
            alreadyInteracted = !alreadyInteracted;

            colour = alreadyInteracted ? "blue" : "red";
            interactText = "Press R to change colour to " + colour;

            print("R key was pressed, changing colour to " + colour);

            if (alreadyInteracted)
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            else
                gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    public void Start()
    {
        alreadyInteracted = false;
    }

    public void Update()
    {
        //Interact();
    }

    private void OnTriggerEnter(Collider other)
    {
        print("object entered trigger");
    }

    private void OnTriggerStay(Collider other)
    {
        Interact();
    }

    private void OnTriggerExit(Collider other)
    {
        print("object exited trigger");
    }

}
