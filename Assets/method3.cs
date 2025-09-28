using UnityEngine;

public class method3 : MonoBehaviour
{
    private void Awake()
    {
        int a = 3, b = 4;
        Debug.Log($"Befor a = {a}, b = {b}");
        Swap(a, b);
        Debug.Log($"After a = {a}, b = {b}");
    }

    public void Swap(int num1, int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
}