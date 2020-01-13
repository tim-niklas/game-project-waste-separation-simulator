using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class Scoreboard : MonoBehaviour
{
    // Start is called before the first frame update

    private Transform entryContainer;
    private Transform entryTemplate;
    private List<HighscoreEntry> highscoreEntryList;
    private List<Transform> highscoreEntryTransformList;
    private void Awake()
    {

        //AddHighscoreEntry(10000);

        entryContainer = transform.Find("HighscoreEntryContainer");
        entryTemplate = entryContainer.Find("HighscoreEntryTemplate");

        entryTemplate.gameObject.SetActive(false);

        //Getting the saved highscoreTable json
        string jsonString = PlayerPrefs.GetString("highscoreTable");
        //Debug.Log(jsonString + "Playerprefs save");
        //putting it in the list
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);

        // SORTING 

        for (int i = 0; i < highscores.highscoreEntryList.Count; i++)
        {
            for (int j = i + 1; j < highscores.highscoreEntryList.Count; j++)
            {
                if (highscores.highscoreEntryList[j].score > highscores.highscoreEntryList[i].score)
                {
                    //switch if next one is bigger
                    HighscoreEntry tmp = highscores.highscoreEntryList[i];
                    highscores.highscoreEntryList[i] = highscores.highscoreEntryList[j];
                    highscores.highscoreEntryList[j] = tmp;

                }


            }
        }
       
        //creates a line for every score that has been made 
        highscoreEntryTransformList = new List<Transform>();
        foreach (HighscoreEntry highscoreEntry in highscores.highscoreEntryList)
        {
            CreateHighscoreEntryTransform(highscoreEntry, entryContainer, highscoreEntryTransformList);

        }

    }

    private void CreateHighscoreEntryTransform(HighscoreEntry highscoreEntry, Transform container, List<Transform> transformList)
    {
        if(transformList.Count >= 10)
        {
            return;
        }
        float templateHeight = 20f;
        Transform entryTransform = Instantiate(entryTemplate, container);
        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
        entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
        entryTransform.gameObject.SetActive(true);

        int rank = transformList.Count + 1;


        int score = highscoreEntry.score;

        entryTransform.Find("PositionText").GetComponent<Text>().text = rank.ToString();
        entryTransform.Find("ScoreText").GetComponent<Text>().text = score.ToString();

        //set background of every 2nd entry with a different background colour
        entryTransform.Find("background").gameObject.SetActive(rank % 2 == 1);

        if (rank == 1)
        {
            entryTransform.Find("PositionText").GetComponent<Text>().color = Color.yellow;
            entryTransform.Find("ScoreText").GetComponent<Text>().color = Color.yellow;
        }
        transformList.Add(entryTransform);
    }

    public void AddHighscoreEntry(int score)
    {
        //create HighscoreEntry
        HighscoreEntry highscoreEntry = new HighscoreEntry { score = score };
        //Load saved Highscores
        string jsonString = PlayerPrefs.GetString("highscoreTable");
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);
        //Add new entry to Highscores
        highscores.highscoreEntryList.Add(highscoreEntry);
        //save updated Highscores
        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("highscoreTable", json);
        PlayerPrefs.Save();
    }


    private class Highscores
    {
        public List<HighscoreEntry> highscoreEntryList;

    }


    [System.Serializable]
    private class HighscoreEntry
    {

        public int score;



    }


}
//putting the scores into a list and saving it to a json 
/*
Highscores highscores = new Highscores { highscoreEntryList = highscoreEntryList };
string json = JsonUtility.ToJson(highscores);
PlayerPrefs.SetString("highscoreTable", json);
PlayerPrefs.Save();
*/
/*
highscoreEntryList = new List<HighscoreEntry>()
{
    new HighscoreEntry{score = 51245},
    new HighscoreEntry{score = 12},
    new HighscoreEntry{score = 13},
    new HighscoreEntry{score = 50},
    new HighscoreEntry{score = 300},
    new HighscoreEntry{score = 700}
};*/
//string json = File.ReadAllText(Application.dataPath + "highscorefile.json");
//File.WriteAllText(Application.dataPath + "highscorefile.json", json);