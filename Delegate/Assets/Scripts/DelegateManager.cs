using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class DelegateManager : MonoBehaviour
{
    public delegate void mouseClickDelegate();// Tanimi
    public static mouseClickDelegate OnClick; // Objesi

    public delegate void MouseClickWithParameter(string text);
    public static MouseClickWithParameter Click;

    public delegate int DelegateMath(int x1, int x2);
    public static DelegateMath math;


    private string txt = "clicked with parameter";
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (OnClick != null)
            {
                OnClick();
                Click(txt);
            }
        }
    }

    public static void AddMethod(DelegateMath method)
    {
        math += method;
    }
    public static void RemoveMethod(DelegateMath method)
    {
        math -= method;
    }
}
