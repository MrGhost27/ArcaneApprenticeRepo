using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambition : MonoBehaviour {

    [SerializeField] private int strengthBonus;
    [SerializeField] private int willBonus;
    [SerializeField] private int intelligenceBonus;
    [SerializeField] private string ambitionTitle;

    // Use this for initialization
    void Start () {
        GetStats();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void GetStats()
    {
        // In future the intention is to present questions to determine the character's Ambition. Like Jagged Alliance 2.
        strengthBonus = Random.Range(1, 11);
        willBonus = Random.Range(1, 11);
        intelligenceBonus = Random.Range(1, 11);

        // Magic Number 4... Use of Vectors because it's dynamic? (List, it's using Generics).
        // string[] ambitionTitlesArray = new string[4]; OLD Array mechanism.
        //List<string> ambitionTitles =  new List<string>{"Andy", "Bob", "Charlie", "Derrick" };

        List<string> ambitionTitles = new List<string>();
        ambitionTitles.Add("Aggression");
        ambitionTitles.Add("Boldness");
        ambitionTitles.Add("Charity");
        ambitionTitles.Add("Destruction");

        int pickone = Random.Range(0, ambitionTitles.Count);

        ambitionTitle = ambitionTitles[pickone];

        strengthBonus = Random.Range(10, 25);
        willBonus = Random.Range(10, 25);
        intelligenceBonus = Random.Range(10, 25);

        Debug.Log(string.Format("stats generated: {0}, {1}, {2}", strengthBonus, willBonus, intelligenceBonus));
    }
}
