using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public GameObject carriedPlantPrefab;
    public bool isCarrying;
    public bool isCarryingToSell;
    public bool isMoving;
    public int money;

    public PlayerVisual playerVisual;
    public PrefabScript carriedPlant;
    public int carriedPlantPrice;


    private void Start()
    {
        money = 100;
    }
    public bool BuyPlant(GameObject plantPrefab, int price)
    {
        if (money >= price && !isCarrying && !isCarryingToSell)
        {
            money -= price;
            carriedPlantPrefab = plantPrefab;
            isCarrying = true;

            // Visual
            playerVisual.SetCarrying(true);
            

            Debug.Log("Compraste: " + plantPrefab.name);
            return true;
        }
        else
        {
            Debug.Log("No hay dinero o ya llevas algo");
            return false;
        }
    }
}
