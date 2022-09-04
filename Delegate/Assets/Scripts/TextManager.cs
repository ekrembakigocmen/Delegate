using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class TextManager : MonoBehaviour
{
    public string text;

    private void OnEnable()
    {
        DelegateManager.OnClick += () =>Debug.Log(text = "Cliked");//Lambda Expression
        DelegateManager.Click += (txt) => Debug.Log(txt);
        DelegateManager.Click += (txt) => Debug.Log(txt="text value changed");
    }

   
}
