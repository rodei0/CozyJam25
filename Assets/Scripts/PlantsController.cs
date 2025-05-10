using UnityEngine;

public class PlantsController : MonoBehaviour
{

    public int priceBuy;
    public int priceSell;
    public float timeToGrow;
    public PlayerMovement player;
    public UIScript uiManager;
    public PlayerVisual playerVisual;

    protected bool isCarrying;

    public Sprite carriedSprite;
    
    public virtual void BuyPlant() {
        if (player.money >= priceBuy && !isCarrying) {
        player.money -= priceBuy;
        isCarrying = true;
        uiManager.UpdateText();
        playerVisual.SetCarrying(true);
            playerVisual.SetCarriedSprite(carriedSprite);
        } else
        {
            Debug.Log("No hay dinero o ya se lleva algo");
        }
    }
}
