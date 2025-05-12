using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    private Animator anim;
    public SpriteRenderer carryRender;
    public PlayerMovement movement;
    public PlayerInventory inventory;
    void Start()
    {
        anim = GetComponent<Animator>();
        carryRender.sprite = null;
    }

    void Update()
    {
        Moving();
    }
    public void SetCarrying(bool isCarrying)
    {
        anim.SetBool("isCarrying", isCarrying);
        if (!isCarrying)
        {
            carryRender.sprite = null; // Si deja de llevar, quitamos el sprite
        }

    }

    public void Moving()
    {
        if ((movement.horizontal != 0 || movement.vertical != 0)) {
        anim.SetBool("isMoving", true);
        } else
        {
            anim.SetBool("isMoving", false);
        }
    }


    public void SetCarriedSprite(Sprite plantSprite)
    {
        carryRender.sprite = plantSprite;
    }
}
