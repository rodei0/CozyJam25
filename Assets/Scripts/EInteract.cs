using UnityEngine;

public class EInteract : MonoBehaviour
{
    public GameObject eButton;
    public PlayerInventory playerInventory;
    void Start()
    {
        eButton.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && playerInventory.isCarrying)
        {
            eButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            eButton.SetActive(false);
        }
    }

    private void Update()
    {
        if (playerInventory.isCarrying == false)
        {
            eButton.SetActive(false);
        }
    }
}
