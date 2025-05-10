using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    private Animator anim;
    public SpriteRenderer carryRender;
    void Start()
    {
        anim = GetComponent<Animator>();
        carryRender.sprite = null;
    }

    void Update()
    {
        
    }
    public void SetCarrying(bool isCarrying)
    {
        anim.SetBool("isCarrying", isCarrying);
        if (!isCarrying)
        {
            carryRender.sprite = null; // Si deja de llevar, quitamos el sprite
        }

    }

    public void SetCarriedSprite(Sprite plantSprite)
    {
        carryRender.sprite = plantSprite;
    }
}
