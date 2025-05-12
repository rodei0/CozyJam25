using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text money;
    public PlayerInventory playerInventory;
    private void Start()
    {
        //money.text = .ToString();
        money.text = playerInventory.money.ToString();
    }

   
    //no se si esto puede dar lag? porq mira cada frame a ver si pasa eso con el if pero idk
    void Update()
    {
        if (money.text != playerInventory.money.ToString())
        {
            money.text = playerInventory.money.ToString();
        }
    }

    public void UpdateText()
    {
        money.text = playerInventory.money.ToString();
    }
}
