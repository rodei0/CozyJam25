using UnityEngine;

public class ShopUI : MonoBehaviour
{
    public PlayerInventory player; // referencia al jugador
    public GameObject daisyPrefab;
    public GameObject tulipPrefab;
    public GameObject narcissusPrefab;
    public GameObject lilyPrefab;
    public GameObject peonyPrefab;
    public GameObject irisPrefab;
    public GameObject magnoliaPrefab;
    public GameObject camelliaPrefab;
    public GameObject sakuraPrefab;
    public GameObject butterflyPeaPrefab;
    
    public PlayerVisual playerVisual;

    public Sprite daisySprite;
    public int daisyPrice = 10;
    public Sprite tulipSprite;
    public int tulipPrice = 20;
    public Sprite narcissusSprite;
    public int narcissusPrice = 50;
    public Sprite lilySprite;
    public int lilyPrice = 100;
    public Sprite peonySprite;
    public int peonyPrice = 250;
    public Sprite irisSprite;
    public int irisPrice = 300;
    public Sprite magnoliaSprite;
    public int magnoliaPrice = 450;
    public Sprite camelliaSprite;
    public int camelliaPrice = 550;
    public Sprite sakuraSprite;
    public int sakuraPrice = 600;
    public Sprite butterflyPeaSprite;
    public int butterflyPeaPrice = 2000;

    private AudioSource audioSource;
    public AudioClip clip2;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();  
    }

    public void BuyDaisy()
    {
        bool bought = player.BuyPlant(daisyPrefab, daisyPrice);
        if (bought) {
        playerVisual.SetCarriedSprite(daisySprite);
        audioSource.Play();
        }
        
    }

    public void BuyTulip()
    {
        bool bought = player.BuyPlant(tulipPrefab, tulipPrice);
        if (bought)
        {
            playerVisual.SetCarriedSprite(tulipSprite);
            audioSource.Play();
        }
    }

    public void BuyNarcissus()
    {
        bool bought = player.BuyPlant(narcissusPrefab, narcissusPrice);
        if (bought)
        {
            playerVisual.SetCarriedSprite(narcissusSprite);
            audioSource.Play();
        }
    }

    public void BuyLily()
    {
        bool bought = player.BuyPlant(lilyPrefab, lilyPrice);
        if (bought)
        {
            playerVisual.SetCarriedSprite(lilySprite);
            audioSource.Play();
        }
    }

    public void BuyPeony()
    {
        bool bought = player.BuyPlant(peonyPrefab, peonyPrice);
        if (bought)
        {
            playerVisual.SetCarriedSprite(peonySprite);
            audioSource.Play();
        }
    }

    public void BuyIris()
    {
        bool bought = player.BuyPlant(irisPrefab, irisPrice);
        if (bought)
        {
            playerVisual.SetCarriedSprite(irisSprite);
            audioSource.Play();
        }
    }

    public void BuyMagnolia()
    {
        bool bought = player.BuyPlant(magnoliaPrefab, magnoliaPrice);
        if (bought)
        {
            playerVisual.SetCarriedSprite(magnoliaSprite);
            audioSource.Play();
        }
    }

    public void BuyCamellia()
    {
        bool bought = player.BuyPlant(camelliaPrefab, camelliaPrice);
        if (bought)
        {
            playerVisual.SetCarriedSprite(camelliaSprite);
            audioSource.Play();
        }
    }

    public void BuySakura()
    {
        bool bought = player.BuyPlant(sakuraPrefab, sakuraPrice);
        if (bought)
        {
            playerVisual.SetCarriedSprite(sakuraSprite);
            audioSource.Play();
        }
    }

    public void BuyButterflyPea()
    {
        bool bought = player.BuyPlant(butterflyPeaPrefab, butterflyPeaPrice);
        if (bought)
        {
            playerVisual.SetCarriedSprite(butterflyPeaSprite);
            audioSource.Play();
            audioSource.PlayOneShot(clip2);

        }
    }
}
