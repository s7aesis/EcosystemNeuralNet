﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class Parameters : MonoBehaviour {
    public const float speedLimiter = 20f;
    public const int populationSize = 15;
    public const float crossoverRate = 0.7f;
    public const float mutationRate = 0.2f;
    public const float maxPertubation = 0.3f;
    public const int numWeights = 6;
    public const int numFood = 25;
    public const float maxTurnRate = 0.3f;
    public const float bias = -1;
    public const float P = 1.0f;
    public const float minX = -8.5f;
    public const float maxX = 8.5f;
    public const float minY = -4.5f;
    public const float maxY = 4.5f;


    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }
}
