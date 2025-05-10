using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text money;
    public PlayerMovement player;
    private void Start()
    {
        //money.text = .ToString();
        money.text = player.money.ToString();
    }

   
    //no se si esto puede dar lag? porq mira cada frame a ver si pasa eso con el if pero idk
    void Update()
    {
        if (money.text != player.money.ToString())
        {
            money.text = player.money.ToString();
        }
    }

    public void UpdateText()
    {
        money.text = player.money.ToString();
    }
}
