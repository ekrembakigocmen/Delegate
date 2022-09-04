using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int gold;


    private void OnEnable()
    {
        DelegateManager.OnClick += IncreaseGold; // Abone edildi
    }

    private void OnDisable()
    {
        DelegateManager.OnClick -= IncreaseGold; // Abonelikten cikarildi
    }

    private void IncreaseGold()
    {
        gold++;
    }
}
