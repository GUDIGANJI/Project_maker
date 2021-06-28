using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static SaveData data;
    public static GameManager instance;

    public Text goldText;

    private void Awake()
    {
        instance = this;
        data = new SaveData();
        //if (PlayerPrefs.HasKey("data"))
        //{
        //    string saveData = PlayerPrefs.GetString("data");
        //    data = JsonUtility.FromJson<SaveData>(saveData);
        //}
        //else
        //{
        //    data = new SaveData();
        //}

        Refresh();
    }

    public void AddGold(int value)
    {
        data.gold += value;
        data.status += value;
        data.intelligent += value;
        data.passion += value;
        data.battlePower += value;

        Refresh();
    }

    private void Refresh()
    {
        //Debug.Log(data.gold);
        goldText.text = "¼ÒÁö±Ý " + data.gold + "G";
    }

    private void OnDestroy()
    {
        string saveData = JsonUtility.ToJson(data);
        PlayerPrefs.SetString("data", saveData);
    }

    public SaveData GetData()
    {
        return data;
    }
}
