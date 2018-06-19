using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcaneTechnique : MonoBehaviour {

    [SerializeField] string techniqueName;
    [SerializeField] int number;
    [SerializeField] Texture image;
    [SerializeField] public int level;
    [SerializeField] public int school;
    [SerializeField] public int spellIndex;

    [SerializeField] bool locked = true;
    [SerializeField] bool visible = false;
    [SerializeField] bool set = false;

    public bool SetMe(int spellIndex, Texture image)
{
        if (!set)
        {
            Debug.Log("notSet - Setting Now...");
            this.spellIndex = spellIndex;
            this.image = image;
            this.set = true;
            return true;
        }
        else {
            Debug.Log("Trying to reset. Already set. ");
            return false;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool Cast()
    {
        if (set)
            return Spellbook.CastMe(spellIndex);
        else
        {
            Debug.Log("Trying to cast an unset spell");
            return false;
        }
    }
}
