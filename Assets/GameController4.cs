using UnityEngine;

public class GameController4 : MonoBehaviour
{
    private void Awake()
    {
        Player player = new Player();

        player.currentHP = 100;
        Debug.Log($"HP : {player.currentHP}");

        player.SetCurrentHP(100);
        Debug.Log($"HP : {player.GetCurrentHP()}");
    }
}
