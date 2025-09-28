using System.Runtime.CompilerServices;
using UnityEngine;

public class GameController1 : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player();
        player02 = new Player("����Ƽ", 10);

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
        ID = "��ڻ�";
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
        Debug.Log("���� �����Ѵ�.");
    }

    public void Heal()
    {
        Debug.Log("ä���� ȸ���Ѵ�.");
    }
}

public class Goblin1 : Entity
{
    public void Avoid()
    {
        Debug.Log("��������!");
    }

    public void Heal()
    {
        Debug.Log("����� ä��ȸ��!");
    }
}

public class Enemy
{
    public int numeric;
    public static string specise;

    public void TakeDamage(int damage)
    {
        Debug.Log($"�� : {damage}��ŭ ü�� ����");
    }
}


public class Goblin : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"��� : {damage}��ŭ ä�� ����");
    }
}

public class Slime : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"������ : {damage}��ŭ ä�� ����");
    }
}

public class Dragon : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"�巡�� : {damage}��ŭ ä�� ����");
    }
}

