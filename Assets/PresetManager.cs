using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresetManager : MonoBehaviour
{
    public PronounManager pronounManager;

    public List<PronounSet> pronounPresets = new List<PronounSet>();

    public void PresetUpdate(int choice) 
    {
        switch (choice)
        {
            case 0:
                break;
            default:
                pronounManager.UpdatePronounsFromPreset(pronounPresets[choice-1]);
                break;
        }
    }
}
