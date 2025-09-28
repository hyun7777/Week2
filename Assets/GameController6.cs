using UnityEngine;

public class GameController6 : MonoBehaviour
{
    private void Awake()
    {
        Enemy enemy01 = new Enemy();
        enemy01.numeric = 0;
        Enemy enemy02 = new Enemy();
        enemy02.numeric = 1;

        Debug.Log(enemy01.numeric);
        Debug.Log(enemy02.numeric);

        Enemy.specise = "°íºí¸°";
        Debug.Log(Enemy.specise);
    }
}
