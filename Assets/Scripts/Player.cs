using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour {

    #region playerStats (Get, Private Set)
    [SerializeField] private string playerName;
    [SerializeField] private int strengthStat;
    [SerializeField] private int willStat;
    [SerializeField] private int intelligenceStat;
    #endregion

    // Navigation
    NavMeshAgent agent;  

    // Use this for initialization
    void Start () {
        GeneratePlayerStats();
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                agent.destination = hit.point;
            }
        }
	}

    void GeneratePlayerStats() {

        List<string> names = new List<string>();
        names.Add("Andy");
        names.Add("Bob");
        names.Add("Charlie");
        names.Add("Derrick");

        //List<string> idiots = new List<string>{ "Jim", "Jeffry" };
        //var moreIdiots = new List<string> { "Kevin", "Kilroy" };

        int pickone = Random.Range(0, names.Count);

        playerName = names[pickone];

        strengthStat = Random.Range(10, 25);
        willStat = Random.Range(10, 25);
        intelligenceStat = Random.Range(10, 25);
    }
}
