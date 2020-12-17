using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PronounManager : MonoBehaviour
{
    string FirstName = "";
    string Title = "";
    string SubjectPronoun = "";
    string subjectPronoun = "";
    string LastName = "";
    string objectPronoun = "";
    string possessivePronoun = "";
    string PossessivePronoun = "";
    string genderIdentityYoung = "";
    string GenderIdentityYoung = "";
    string genderIdentityMature = "";
    string GenderIdentityMature = "";

    bool subjectPronounPlural = false;
    string subjectPronoun_Is_Are = "is";
    string subjectPronoun_Was_Were = "was";
    string subjectPronounVerbPlural = "";
    string possesivePronounPlural = "s";

    public TextMeshProUGUI exampleParagraph;
    public TextMeshProUGUI firstNameExample;
    public TextMeshProUGUI titleExample;
    public TextMeshProUGUI lastNameExample;
    public TextMeshProUGUI genderIdentityYoungExample;
    public TextMeshProUGUI genderIdentityMatureExample;
    public TextMeshProUGUI subjectPronounExample;
    public TextMeshProUGUI objectPronounExample;
    public TextMeshProUGUI possessivePronounExample;

    public TMP_InputField titleGraphics;
    public TMP_InputField genderIdentityYoungGraphics;
    public TMP_InputField genderIdentityMatureGraphics;
    public Toggle pluralBoolGraphics;
    public TMP_InputField subjectPronounGraphics;
    public TMP_InputField objectPronounGraphics;
    public TMP_InputField possesivePronounGraphics;

    // Start is called before the first frame update
    void Start()
    {
        UpdateSubjectPronounPluralLanguage();
    }

    public void UpdatePronounsFromPreset(PronounSet customPronounSet) 
    {
        if (!customPronounSet.title.Equals("") && customPronounSet.title != null)
        {
            UpdateTitle(customPronounSet.title);
            titleGraphics.text = customPronounSet.title;
        }
        if (!customPronounSet.genderIdentityYoung.Equals("") && customPronounSet.genderIdentityYoung != null)
        {
            UpdateGenderIdentityYoung(customPronounSet.genderIdentityYoung);
            genderIdentityYoungGraphics.text = customPronounSet.genderIdentityYoung;
        }
        if (!customPronounSet.genderIdentityMature.Equals("") && customPronounSet.genderIdentityMature != null)
        { 
            UpdateGenderIdentityMature(customPronounSet.genderIdentityMature);
            genderIdentityMatureGraphics.text = customPronounSet.genderIdentityMature;
        }
        
        UpdateSubjectPronounPlural(customPronounSet.plural);
        pluralBoolGraphics.isOn = customPronounSet.plural;
        UpdateSubjectPronoun(customPronounSet.subjectPronoun);
        subjectPronounGraphics.text = customPronounSet.subjectPronoun;
        UpdateObjectPronoun(customPronounSet.objectPronoun);
        objectPronounGraphics.text = customPronounSet.objectPronoun;
        UpdatePossesivePronoun(customPronounSet.possesivePronoun);
        possesivePronounGraphics.text = customPronounSet.possesivePronoun;
    }

    void UpdateSubjectPronounPluralLanguage() 
    {
        subjectPronoun_Is_Are = subjectPronounPlural ? "are" : "is";
        subjectPronoun_Was_Were = subjectPronounPlural ? "were" : "was";
        subjectPronounVerbPlural = subjectPronounPlural ? "" : "s";
    }

    void UpdateExampleParagraph() 
    {
        exampleParagraph.text = $"Our story opens on a young {genderIdentityYoung}, nervous for {possessivePronoun} first day of school...\n\n"+
            
            $"I just arrived at a new school.\n \"This is {FirstName}.\" The teacher announces. \"{SubjectPronoun} {subjectPronoun_Is_Are} a new student here. {SubjectPronoun} just transfered to Hogwarts so please be welcoming! {SubjectPronoun} {subjectPronoun_Was_Were} at Ilvermorny before, so {subjectPronoun} should be all caught up... Isn't that right {Title} {LastName}?\"\n" +
        $"She gives me a sly smile but it fades quickly. \n" +
        $"\"Please find your seat.\" The teacher asks, gesturing to an empty desk. I had already forgotten her name but she had a stern look about her so I was quick to listen." +
        $"I find my seat amongst stares. A ravenclaw girl with black hair whispers:\n\"That's {objectPronoun}, that's the new {genderIdentityYoung}!\" to her friend.\n" +
        $"\"{PossessivePronoun} wand is brand new!\" The ravenclaw boy seated beside her replies. \"I'd curse to have {possessivePronoun}{possesivePronounPlural}\"\n\n" +


        $"...with that, {FirstName} sat there thinking to {objectPronoun}self, about the crazy adventure {subjectPronoun} {subjectPronoun_Was_Were} embarking on!";
    }

    public void UpdateFirstName(string newName) 
    {
        FirstName = newName;
        UpdateExampleParagraph();
        firstNameExample.text = $"Hi! My name is {FirstName}!";
    }

    public void UpdateTitle(string newTitle)
    {
        Title = newTitle;

        UpdateExampleParagraph();

        titleExample.text = $"{Title} {LastName} please turn your book to page to 237.";
        lastNameExample.text = $"{Title} {LastName} please turn your book to page to 237.";
    }

    public void UpdateLastName(string newName)
    {
        LastName = newName;

        UpdateExampleParagraph();

        titleExample.text = $"{Title} {LastName} please turn your book to page to 237.";
        lastNameExample.text = $"{Title} {LastName} please turn your book to page to 237.";
    }

    public void UpdateGenderIdentityYoung(string newGenderIdentityYoung)
    {
        genderIdentityYoung = newGenderIdentityYoung.ToLower();
        if (genderIdentityYoung.Length > 0)
        if (genderIdentityYoung.Length > 0)
            GenderIdentityYoung = char.ToUpper(genderIdentityYoung[0]) + genderIdentityYoung.Substring(1);

        UpdateExampleParagraph();

        genderIdentityYoungExample.text = $"I'm playing a game right now! I'm a real gamer {genderIdentityYoung}";
    }

    public void UpdateGenderIdentityMature(string newGenderIdentityMature)
    {
        genderIdentityMature = newGenderIdentityMature.ToLower();
        if (genderIdentityMature.Length > 0)
            GenderIdentityMature = char.ToUpper(genderIdentityMature[0]) + genderIdentityMature.Substring(1);

        UpdateExampleParagraph();

        genderIdentityMatureExample.text = $"What a clever young {genderIdentityMature}";
    }

    public void UpdateSubjectPronounPlural(bool plural) 
    {
        subjectPronounPlural = plural;
        UpdateSubjectPronounPluralLanguage();
        UpdateSubjectPronoun(SubjectPronoun);
    }

    public void UpdateSubjectPronoun(string newSubjectPronoun)
    {
        subjectPronoun = newSubjectPronoun.ToLower();
        if (subjectPronoun.Length > 0)
            SubjectPronoun = char.ToUpper(subjectPronoun[0]) + subjectPronoun.Substring(1);

        UpdateExampleParagraph();

        subjectPronounExample.text = $"{SubjectPronoun} dance{subjectPronounVerbPlural} like no one's watching\n{SubjectPronoun} {subjectPronoun_Is_Are} the best\n{SubjectPronoun} {subjectPronoun_Was_Were} at my birthday party!";
    }

    public void UpdateObjectPronoun(string newObjectPronoun)
    {
        objectPronoun = newObjectPronoun;

        UpdateExampleParagraph();

        objectPronounExample.text = $"Oh I love {objectPronoun}!";
    }

    public void UpdatePossesivePronoun(string newPossessivePronoun)
    {
        possessivePronoun = newPossessivePronoun;
        if (possessivePronoun.Length > 0)
            PossessivePronoun = char.ToUpper(possessivePronoun[0]) + possessivePronoun.Substring(1);

        if (possessivePronoun.Length > 0)
            possesivePronounPlural = possessivePronoun.Substring(possessivePronoun.Length - 1).Equals("s") ? "'" : "s";

        UpdateExampleParagraph();

        possessivePronounExample.text = $"That 100 dollar bill? no that's not mine, that's {possessivePronoun}s.\nI love {possessivePronoun} hair!";
    }
}
