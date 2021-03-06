﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUpdate : MonoBehaviour {
    public Player player;
    public Slider healthbar;
    public RectTransform bar;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player").GetComponent<Player>();
        healthbar = GetComponent<Slider>();
        bar = healthbar.GetComponent<RectTransform>();
        healthbar.maxValue = player.maxHealth;
        healthbar.value = player.health;
        bar.sizeDelta = new Vector2(healthbar.maxValue, bar.rect.height);
    }

    // Late update so it is after gameplay
    void LateUpdate () {
        healthbar.maxValue = player.maxHealth;
        healthbar.value = player.health;
        bar.sizeDelta = new Vector2(healthbar.maxValue, bar.rect.height);
    }
}
