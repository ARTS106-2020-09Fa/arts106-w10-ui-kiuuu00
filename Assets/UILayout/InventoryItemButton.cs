﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemButton : MonoBehaviour
{
    private Text buttonText;
    private string[] itemTypes = { "Armor", "Weapon", "Spell" };
    public int typeIndex;

    void Awake()
    {
        typeIndex = UnityEngine.Random.Range(0, 3);
        buttonText = GetComponentInChildren<Text>();
        buttonText.text = itemTypes[typeIndex];
    }

    
}
