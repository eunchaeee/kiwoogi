using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodButton : MonoBehaviour
{
    [SerializeField] private Button foodButton;
    [SerializeField] private GameObject foodPrefab;

    private void Awake()
    {
        foodButton.onClick.AddListener(GetFood);    
    }

    private void GetFood()
    {
        Instantiate(foodPrefab);
    }
}
