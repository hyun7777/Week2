using UnityEngine;

public class GameController : MonoBehaviour
{
    private Player player01;
    private Player player02;

    private void Awake()
    {
        player01 = new Player("��ڻ�", 1000);

        player02 = player01.DeepCopy();
        player02.ID = "����Ƽ";

        Debug.Log($"ID : {player01.ID}");
        Debug.Log($"ID : {player02.ID}");
    }
}


