using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResearchTree : MonoBehaviour {

    [SerializeField] int[] wholeTree = new int[25];    
    //[SerializeField] int[,] wholeTree = new int [5,5];    2 Dimensional representation
    

    [SerializeField] List<ArcaneTechnique> knownTechniques;

    [SerializeField] ArcaneTechnique oneTechnique;

    public int[] startingKnownSchools = { 0 };
    public int[] startingKnownTechniques; //= { 0, 1 };

    [SerializeField] Texture testImage;

    // Use this for initialization
    void Start () {
        Debug.Log("Try to set oneTechnique");
        oneTechnique.SetMe(oneTechnique.spellIndex, testImage);
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            oneTechnique.Cast();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            // A HACK for adding a new technique
            learnTechnique(startingKnownTechniques.Length);
        }
    }

    bool learnTechnique(int spellIndex)
    {
        // Need a better way of doing this.
        //ArcaneTechnique addMe = new ArcaneTechnique(schoolNumber, techNumber, testImage);

        ArcaneTechnique addMe = gameObject.AddComponent(typeof(ArcaneTechnique)) as ArcaneTechnique;
        addMe.SetMe(spellIndex, testImage);
        knownTechniques.Add(addMe);
        
        return true;
    }

    bool castTechnique(int spellIndex)
    {
        // Check here whether it's learnt or not.
        
        return Spellbook.CastMe(spellIndex);
    }
}
