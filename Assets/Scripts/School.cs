using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class School : MonoBehaviour {

    // Use this for initialization
    [SerializeField] public List<GameObject> Buttons;
    //[SerializeField] public List<GameObject> Techniques;
    [SerializeField] List<int> spellIndexes;
    [SerializeField] GameObject Technique;
    [SerializeField] int knownTechniques = 0;

    [SerializeField] GameObject SM;
    void Start () {
        if (SM == null)
        SM = GameObject.FindWithTag("SpellManager");
	}

    public bool learnTechnique()
    {
        Buttons[knownTechniques].SetActive(true);
        Button b = Buttons[knownTechniques].GetComponent<Button>();
        b.onClick.AddListener(delegate { Spellbook.DebugF(); });

        knownTechniques++;
        if (knownTechniques > Buttons.Count)
            knownTechniques = Buttons.Count;
        return true;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
