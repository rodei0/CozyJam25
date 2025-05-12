using UnityEngine;
using UnityEngine.Tilemaps;

public class PlantsController : MonoBehaviour
{

    public PlayerMovement player;
    public PlayerVisual playerVisual;
    public PlayerInventory playerInventory;
    public Transform tileParent;
    public AudioSource audioSource;


   

    public virtual void PlantPlant(PlantingTile tile)
    {
        if (playerInventory.isCarrying && !tile.isPlanted && !playerInventory.isCarryingToSell)
        {
            GameObject newplant = Instantiate(playerInventory.carriedPlantPrefab, tile.transform.position, Quaternion.identity, tileParent);
            newplant.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

            PrefabScript plantScript = newplant.GetComponent<PrefabScript>();
            plantScript.tile = tile;
            audioSource.Play();

            tile.isPlanted = true;
            playerInventory.isCarrying = false;
            playerVisual.SetCarrying(false);
            playerVisual.SetCarriedSprite(null);


            Debug.Log("Planta sembrada");
        } else
        {
            Debug.Log("No se puede plantar");
        }
    }
}
