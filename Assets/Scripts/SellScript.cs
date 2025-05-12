using UnityEngine;

public class SellScript : MonoBehaviour
{
    public PlayerInventory inventory;
    public PlayerVisual visual;
    public UIScript uiManager;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && inventory.isCarryingToSell)
        {
            Sell();
            audioSource.Play();
        }
    }
    public void Sell()
    {
        if (inventory.carriedPlant != null)
        {
            Debug.Log("Vendiendo planta por: " + inventory.carriedPlant.priceSell);
            inventory.money += inventory.carriedPlantPrice;
            uiManager.UpdateText();
            Debug.Log("Dinero actual: " + inventory.money);
            inventory.carriedPlantPrice = 0;

            inventory.isCarrying = false;
            inventory.isCarryingToSell = false;
            visual.SetCarrying(false);

            Destroy(inventory.carriedPlant.gameObject);
            inventory.carriedPlant = null;

            Debug.Log("Planta vendida");
        }
    }
}
