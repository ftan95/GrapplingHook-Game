﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    private GameManager Gm;
    public int Next;

    void OnTriggerEnter2D(Collider2D col)
    {
        this.Gm.LoadNextLevel(Next);
    }
    // Start is called before the first frame update
    void Start()
    {
        this.Gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
