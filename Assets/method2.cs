using UnityEngine;
using UnityEngine.Rendering;

public class method2 : MonoBehaviour
{
    private void Awake()
    {
        int a = Max(10, 20);
        Debug.Log(Max(100, 200));
        Max(5, 10);
    }

    public int Max(int num1, int num2)
    {
        if (num1 >  num2)
        {
            return num1;
        }
        return num2;
    }
}
