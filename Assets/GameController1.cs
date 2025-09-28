using System.Runtime.CompilerServices;
using UnityEngine;

public class GameController1 : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player();
        player02 = new Player("유니티", 10);

    }

    private int damage = 10;

    public void Hit(Enemy enemy)
    {
        enemy.TakeDamage(damage);
    }

}


public class Player
{
    public string ID
    {
        get; set;
    }
    private int CurrentHP
    {
        get; set;
    }

    public int currentHP;



    public Player()
    {
        ID = "고박사";
        currentHP = 1000;
    }

    public Player(string id, int hp)
    {
        ID = id;
        currentHP = hp;
    }

    public Player DeepCopy()
    {
        Player clone = new Player();
        clone.currentHP = currentHP;

        return clone;
    }

    public void SetCurrentHP(int hp)
    {
        if(hp > 0)
        {
            currentHP = hp;
        }
    }

    public int GetCurrentHP()
    {
        return currentHP;
    }

    private int damage = 10;

    public void Hit(Goblin goblin)
    {
        goblin.TakeDamage(damage);
    }

    public void HIt(Slime slime)
    {
        slime.TakeDamage(damage);
    }

    public void HIt(Dragon dragon)
    {
        dragon.TakeDamage(damage);
    }
}

public class Entity
{
    public void Attack()
    {
        Debug.Log("적을 공격한다.");
    }

    public void Heal()
    {
        Debug.Log("채력을 회복한다.");
    }
}

public class Goblin1 : Entity
{
    public void Avoid()
    {
        Debug.Log("도망가자!");
    }

    public void Heal()
    {
        Debug.Log("고블린의 채력회복!");
    }
}

public class Enemy
{
    public int numeric;
    public static string specise;

    public void TakeDamage(int damage)
    {
        Debug.Log($"적 : {damage}만큼 체력 감소");
    }
}


public class Goblin : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"고블린 : {damage}만큼 채력 감소");
    }
}

public class Slime : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"슬라임 : {damage}만큼 채력 감소");
    }
}

public class Dragon : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"드래곤 : {damage}만큼 채력 감소");
    }
}

