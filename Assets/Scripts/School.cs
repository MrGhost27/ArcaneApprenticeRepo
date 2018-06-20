using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class School : MonoBehaviour {

    // Use this for initialization
    [SerializeField] public List<GameObject> Buttons;
    //[SerializeField] public List<GameObject> Techniques;
    [SerializeField] List<int> spellIndexes;
    [SerializeField] int knownTechniques = 0;

    [SerializeField] GameObject SM;
    void Start () {
        if (SM == null)
        SM = GameObject.FindWithTag("SpellManager");
	}

    public bool learnTechnique()
    {
        
        if (!Buttons[knownTechniques].activeSelf)
        {
            Buttons[knownTechniques].SetActive(true);
            Button b = Buttons[knownTechniques].GetComponent<Button>();

            int parameter = spellIndexes[knownTechniques];

            //b.onClick.AddListener(delegate { Spellbook.DebugMe(parameter); });

            b.onClick.AddListener(delegate { SM.GetComponent<Spellbook>().CastMe(parameter); });

            knownTechniques++;
            if (knownTechniques >= Buttons.Count)
                knownTechniques = Buttons.Count - 1;
            return true;
        }
        else
        {
            Debug.Log("Already Learnt Everything");
            return false;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
