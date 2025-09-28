using System.Xml.Serialization;
using UnityEngine;

public class property : MonoBehaviour
{
    private void Awake()
    {
      Player player = new Player();
        player.ID = "°í¹Ú»ç";
        player.CurrentHP = 100;
        Debug.Log($"{player.ID} HP : {player.CurrentHP}");
    }
}
