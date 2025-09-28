using UnityEngine;
using static classbasic1;

public class classbasic1 : MonoBehaviour
{
    public class Player
    {
        private string ID = "°í¹Ú»ç";
        private int currentHP = 1000;

        public void TakeDamage(int damage)
        {
            if (currentHP > damage)
            {
                currentHP -= damage;
            }
        }
    }

    public class Enemy
    {
        private Player player;

        public void AttackToTarget(Player target)
        {
            target.TakeDamage(100);
        }
    }
}
