using UnityEngine;

public class PlantingTile : MonoBehaviour


{

    public PlantsController plantsController;
    public bool isPlanted = false;
    private bool playerInRange = false;
    private AudioSource audioSource;


    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
                playerInRange = true;
                Debug.Log("Jugador en rango");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
    void Start()
    {
        isPlanted = false;
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && !isPlanted)
        {
            if (plantsController != null)

            {
                plantsController.audioSource = audioSource;
                plantsController.PlantPlant(this);
                Debug.Log("Llega a ejecutar el plantplant");
            }
        }
    }
}
