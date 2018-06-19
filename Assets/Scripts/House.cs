using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class House : MonoBehaviour {

    // Use this for initialization


    // Syntax for creating an array of set size.
    Door[] doorPool = new Door[4];

    // Prefabs for Floor and Table
    [SerializeField] GameObject Floor;
    [SerializeField] GameObject Table;


    [SerializeField] NavMeshSurface navSurface;

    [SerializeField] int camStartHeightScale = 15;

    public float planeCenteringOffset = 0.5f;

    #region HouseStart
    // Possible House Dimensions
    [SerializeField] int minHouseWidth = 2;
    [SerializeField] int minHouseHeight = 2;
    [SerializeField] int maxHouseWidth = 4;
    [SerializeField] int maxHouseHeight = 4;
    [SerializeField] int ScaleFactor = 10;

    [SerializeField] int minTables = 2;
    [SerializeField] int maxTables = 5;

    int houseWidth;
    int houseHeight;
    int numOfTables;
    

    int floorWidth = 1;
    int floorHeight = 1;

    int tableWidth = 1;
    int tableHeight = 1;
    #endregion

    void Start () {
        InitialiseValues();
        InitialiseHouse();
        FindObjectOfType<Camera>().transform.position = new Vector3(houseWidth * ScaleFactor / 2, houseWidth * camStartHeightScale, houseHeight * ScaleFactor / 2 - 5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void InitialiseValues() {
        floorWidth = (int)Floor.transform.localScale.x;
        floorHeight = (int)Floor.transform.localScale.z;

        tableWidth = (int)Table.transform.localScale.x;
        tableHeight = (int)Table.transform.localScale.z;
    }

    void InitialiseHouse()
    {
        houseHeight = Random.Range(minHouseHeight, maxHouseHeight + 1);
        houseWidth = Random.Range(minHouseWidth, maxHouseWidth + 1);

        Quaternion noRotation = new Quaternion();

        for (int i = 0; i < houseHeight; i++)
        {
            for (int j = 0; j < houseWidth; j++)
            {
                float xPos = j * ScaleFactor * floorWidth;
                float zPos = i * ScaleFactor * floorHeight;
                Vector3 floorPos = new Vector3(xPos + planeCenteringOffset, 0, zPos + planeCenteringOffset);
                Instantiate(Floor, floorPos, noRotation, this.transform);
                //Instantiate(Floor, floorPos, noRotation, navSurface.transform);
            }
        }

        string debug = string.Format("Dimensions: HouseW {0}, HouseH {1}.", houseWidth, houseHeight);
        Debug.Log(debug);
    }
}
