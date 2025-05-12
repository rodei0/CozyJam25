using UnityEngine;
using UnityEngine.UI;
public class PrefabScript : MonoBehaviour
{
    public PlantingTile tile;
    public int priceSell;
    public float timeToGrow;
    private float growTimer = 0f;
    private bool isGrown = false;
    public GameObject tickPrefab;
    private bool playerInRange;
    public PlayerInventory inventory;
    public PlayerVisual playerVisual;
    public Sprite sprite;
    private GameObject tickInstance;
    private Vector3 initialScale;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        initialScale = transform.localScale;
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            sprite = spriteRenderer.sprite; // Ahora obtienes el sprite correctamente
        }
        inventory = FindFirstObjectByType<PlayerInventory>();
        playerVisual = FindFirstObjectByType<PlayerVisual>();
    }

    void Update()
    {
        if (!isGrown)
        {
            growTimer += Time.deltaTime;  

            
            float growthFactor = Mathf.Clamp01(growTimer / timeToGrow);  
            transform.localScale = initialScale * growthFactor;
        }
        if (growTimer >= timeToGrow && !isGrown)
        {
            Grow();// La planta está completamente crecida
        }
        Harvest();
    }

    void Grow()
    {
        isGrown = true;
        Debug.Log("Creció la planta");
        tickInstance = Instantiate(tickPrefab, this.transform.position + new Vector3(0,0.5f,0), Quaternion.identity);

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Jugador en rango para recoger");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            
            Debug.Log("Jugador no en rango en rango para recoger");
        }
    }

    void Harvest()
    {
        if (playerInRange && isGrown && Input.GetKeyDown(KeyCode.E) && !inventory.isCarrying)
        {
            AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);
            Destroy(tickInstance); 
            playerVisual.SetCarrying(true);
            playerVisual.SetCarriedSprite(sprite);
            inventory.isCarrying = true;
            inventory.isCarryingToSell = true;
            inventory.carriedPlantPrice = priceSell;
            inventory.carriedPlant = this;
            this.gameObject.SetActive(false);
            tile.isPlanted = false;
        }
    }
}
