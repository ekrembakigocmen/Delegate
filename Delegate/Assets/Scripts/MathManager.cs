using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MathManager : MonoBehaviour
{

    void Start()
    {
        DelegateManager.AddMethod(Addition);
        DelegateManager.AddMethod(Subtraction);
        DelegateManager.AddMethod(Multiplication);
        DelegateManager.AddMethod(Division);

        Delegate[] funcs = DelegateManager.math.GetInvocationList();

        for (int i = 0; i < funcs.Length; i++)
        {
            int result = ((DelegateManager.DelegateMath)funcs[i]).Invoke(13, 2);
            Debug.Log(result);
        }
    }




    private int Addition(int a, int b)
    {
        Debug.Log("Addition result");
        return a + b;
    }
    private int Subtraction(int a, int b)
    {
        Debug.Log("Subtraction result ");
        return a - b;

    }
    private int Multiplication(int a, int b)
    {
        Debug.Log("Multiplication result ");
        return a * b;
    }
    private int Division(int a, int b)
    {
        Debug.Log("Division result");
        return a / b;
    }
}
