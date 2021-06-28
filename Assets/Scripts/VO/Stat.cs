using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat : MonoBehaviour
{
    [SerializeField]
    private float lerpSpeed;
    public Text statText;

    private float currentFill;
    public float MyMaxValue { get; set; }


    [SerializeField]
    private Image[] ProgressBars;
    // 능력치의 현재 값 실행
    public float MycurrentValue
    {
        get
        {
            return currentValue;
        }

        set
        {
            if (value > MyMaxValue) currentValue = MyMaxValue;
            else if (value < 0) currentValue = 0;
            else currentValue = value;

            currentFill = currentValue / MyMaxValue;
            statText.text = currentValue + " / " + MyMaxValue;
        }
    }

    private float currentValue;

    void Start()
    {

    }

    void Update()
    {
         BarRefresh();
    }
    
    // 값 세팅(현재 값 / 최대 값)
    public void Initialize(float currentValue, float maxValue) {
        MyMaxValue = maxValue;
        MycurrentValue = currentValue;

    }

    private void BarRefresh()
    {
        ProgressBars[0].fillAmount = GameManager.instance.GetData().health / 999; 
        ProgressBars[1].fillAmount = GameManager.instance.GetData().status / 999; 
        ProgressBars[2].fillAmount = GameManager.instance.GetData().intelligent / 999; 
        ProgressBars[3].fillAmount = GameManager.instance.GetData().indurence / 999; 
        ProgressBars[4].fillAmount = GameManager.instance.GetData().passion / 999; 
        ProgressBars[5].fillAmount = GameManager.instance.GetData().battlePower / 999;
        // ProgressBars[6].fillAmount = GameManager.instance.GetData().tired / GameManager.data.health;
    }
}
