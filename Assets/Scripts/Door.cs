using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    // Use this for initialization

    [SerializeField] private int sturdyness = 1;


    void Start() {
        Debug.Log("Door Created with Sturdyness: " + sturdyness);
    }

    // Update is called once per frame
    void Update() {
        if (sturdyness <= 0)
            Destroy(gameObject);
    }

    public void PlaceDoor(int x, int y)
    {
        
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 150, 100), "Open Door"))
        {
            Debug.Log("You clicked the Open Door Button");
        }
    }
}
