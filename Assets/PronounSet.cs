using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCustomPronounSet", menuName = "ScriptableObjects/NewCustomPronounSet", order = 1)]
public class PronounSet : ScriptableObject
{
    public string title;
    public string genderIdentityYoung;
    public string genderIdentityMature;
    public string subjectPronoun;
    public bool plural = false;
    public string objectPronoun;
    public string possesivePronoun;
}
