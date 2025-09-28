using System.ComponentModel;
using UnityEngine;

public class GameController5 : MonoBehaviour
{
    private void Awake()
    {
        Parent p = new Parent();
        p.Method01();

        Child c = new Child();
        c.Method01();

        Parent pc = new Child();
        pc.Method01();
    }
}

public class Parent
{
    public void Method01()
    {
        Debug.Log("Parent");
    }
}

public class Child : Parent
{
    public new void Method01()
    {
        Debug.Log("Child");
    }
}

