using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResearchTree : MonoBehaviour {

    [SerializeField] int[] wholeTree = new int[25];
    //[SerializeField] int[,] wholeTree = new int [5,5];    2 Dimensional representation

    [SerializeField] List<GameObject> SchoolObjects;
    [SerializeField] List<GameObject> spellButtons;
    [SerializeField] GameObject ResearchPanel;
    [SerializeField] GameObject SchoolPrefab;
    [SerializeField] int learntSchools = 0;
    [SerializeField] int learntTechniques = 0;

    [SerializeField] Vector3 spawnPosition = new Vector3(0,0,0);
    [SerializeField] Vector3 spawnOffset = new Vector3(0, -120, 0);

    public int[] startingKnownSchools = { 0 };
    public int[] startingKnownTechniques; //= { 0, 1 };

    [SerializeField] Texture testImage;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        // Doesn't currently check whether a spell is learnt or not.
        if (Input.GetKeyDown(KeyCode.Alpha1))
            castTechnique(1);
        if (Input.GetKeyDown(KeyCode.Alpha2))
            castTechnique(2);
        if (Input.GetKeyDown(KeyCode.Alpha3))
            castTechnique(3);

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Q registered");
            if (learntSchools < SchoolObjects.Count)
            {
                //Debug.Log("Should enable school");
                //SchoolImages[learntSchools].SetActive(true);
                //learntSchools++;
                learnSchool();
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {

            Debug.Log("Research Tree Class pick a random school and run \"Learn Technique\".");
            int whichSchool = Random.Range(0, learntSchools);

            GameObject getMe = SchoolObjects[whichSchool];
            getMe.GetComponent<School>().learnTechnique();
        }
    }


    void learnSchool()
    {
        #region dynamicAttempt
        /*
        Vector3 firstPosition = this.transform.position;
        //firstPosition += spawnPosition;
        GameObject newSchool = (GameObject)Instantiate(SchoolPrefab, transform.position, Quaternion.identity, ResearchPanel.transform);
        newSchool.transform.localPosition = spawnPosition;
        for (int i = 0; i < learntSchools; i++)
        {
            Debug.Log("Offset added");
            newSchool.transform.Translate(spawnOffset);
        }

        learntSchools++;
        */
        #endregion
        SchoolObjects[learntSchools].SetActive(true);
        learntSchools++;
        if (learntSchools > SchoolObjects.Count)
            learntSchools = SchoolObjects.Count;

    }

    bool learnTechnique(int spellIndex)
    {
        // Need a better way of doing this.
        //ArcaneTechnique addMe = new ArcaneTechnique(schoolNumber, techNumber, testImage);

        /*
        ArcaneTechnique addMe = gameObject.AddComponent(typeof(ArcaneTechnique)) as ArcaneTechnique;
        addMe.SetMe(spellIndex, testImage);
        knownTechniques.Add(addMe);
        */

        //SchoolObjects[learntTechniques].GetComponent<Button>().onClick.AddListener()
        //learntTechniques++;
        return false;
    }

    bool castTechnique(int spellIndex)
    {
        // Check here whether it's learnt or not.
        // This function shouldn't ever be called
        Debug.Assert(false);
        return FindObjectOfType<Spellbook>().CastMe(spellIndex);
    }
}
