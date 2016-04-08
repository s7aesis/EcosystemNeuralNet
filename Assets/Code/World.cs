﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Assets.Code.Entities;

[System.Serializable]
public class World : MonoBehaviour {
    public GeneticAlgorithm geneticAlgorithm;
    private List<Vector3> foodLocations;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		List<Entity> population = this.getEntities ();

		foreach (Entity e in population) {
			// how update entity?
			//Debug.Log(e.getTankTreadPower());
		}
	}

    public void initialize()
    {
        foodLocations = new List<Vector3>();
        for (int i = 0; i < Parameters.numFood; i++)
        {
            foodLocations.Add(new Vector3(Random.Range(-4.5f, 4.5f), Random.Range(-4.5f, 4.5f)));
        }
        geneticAlgorithm = new GeneticAlgorithm(Parameters.populationSize, Parameters.crossoverRate, Parameters.mutationRate, Parameters.numWeights);
        geneticAlgorithm.initialize();

        List<Entity> population = this.getEntities();
        Debug.Log(population[0].getTankTreadPower());
    }

    public List<Entity> getEntities() {
        return geneticAlgorithm.getPopulation();
    }

    public List<Vector3> getFood()
    {
        return foodLocations;
    }

    public void createNextGeneration()
    {
        geneticAlgorithm.createNextGeneration();
    }
}
