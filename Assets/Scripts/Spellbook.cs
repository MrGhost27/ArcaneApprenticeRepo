using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spellbook : MonoBehaviour {

    [SerializeField] private static int maxSchools = 5;
    [SerializeField] private static int maxTechniquesPerSchool = 5;

    public bool castOne()
    {
        return Religion_1_HolyLight();
    }
    public bool castTwo()
    {
        return Religion_2_Heal();
    }
    public bool castThree()
    {
        return Religion_3_WaterToWine();
    }
    public void CastMe(int index)
    { 
        switch (index)
        {

            case 0: Religion_1_HolyLight(); break;
            case 1: Religion_2_Heal(); break;
            case 2: Religion_3_WaterToWine(); break;
            case 3: Religion_4_CreateFood(); break;
            case 4: Religion_5_Resurrection(); break;
            case 5: Elemental_1_Warmth(); break;
            case 6: Elemental_2_Regeneration(); break;
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
            case 20:
            case 21:
            case 22:
            case 23:
            case 24:
            case 25:
            default: Debug.Log(string.Format("Index out of range debug message: {0}", index)); break;
        }
    }

    // Use this for initialization
    #region Relgion
    public static bool Religion_1_HolyLight()
    {
        Debug.Log("Casts Religion_holy light_1");
        return true;
    }
    public static bool Religion_2_Heal()
    {
        Debug.Log("Casts Religion_Heal_2");
        return true;
    }
    public static bool Religion_3_WaterToWine()
    {
        Debug.Log("Casts Religion_WaterToWine_3");
        return true;
    }
    public static bool Religion_4_CreateFood()
    {
        Debug.Log("Casts Religion_CreateFood_4");
        return true;
    }
    public static bool Religion_5_Resurrection()
    {
        Debug.Log("Casts Religion_Resurrection_5");
        return true;
    }
    #endregion

    #region Elemental
    public static bool Elemental_1_Warmth()
    {
        Debug.Log("Casts Elemental_1_Warmth: You feel all warm and tingly...");
        return true;
    }
    public static bool Elemental_2_Regeneration()
    {
        Debug.Log("Casts Elemental_2_Regeneration: You begin to regenerate... ");
        return true;
    }
    #endregion


    public static void DebugMe(int index)
    {
        Debug.Log("Delegate Function Called: " + index);
    }
    public static void DebugF()
    {
        Debug.Log("Delegate Function Called.");
    }
}
