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
    public bool CastMe(int index)
    { 
        switch (index)
        {

            case 0: return Religion_1_HolyLight();
            case 1: return Religion_2_Heal();
            case 2: return Religion_3_WaterToWine();
            case 3: return Religion_4_CreateFood();
            case 4: return Religion_5_Resurrection();
            case 5:
            case 6:
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
            default: Debug.Log(string.Format("Index out of range: {0}", index)); return false;
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

    public static void DebugMe(int index)
    {
        Debug.Log("Delegate Function Called: " + index);
    }
    public static void DebugF()
    {
        Debug.Log("Delegate Function Called.");
    }
}
