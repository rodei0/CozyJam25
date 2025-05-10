using UnityEngine;

public class BuyButton : MonoBehaviour
{

    public GameObject shopUI;

    private void Awake()
    {
        shopUI.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            shopUI.SetActive(true);
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            shopUI.SetActive(false);
        }
    }
}
