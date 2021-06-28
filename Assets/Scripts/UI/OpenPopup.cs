using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class OpenPopup : MonoBehaviour
{
    public Transform[] popup;
    public Button[] btnBlank;
    private Vector3[] firstPosition;

    private void Awake()
    {
        for (int i = 0; i < btnBlank.Length; i++)
        {
            if (btnBlank[i] != null)
            {
                btnBlank[i].onClick.AddListener(delegate ()
                {
                    callOpeningFunc(i);
                });
            }
        }

    }

    void Start()
    {       
        for (int i = 0; i < popup.Length; i++)
        {
            popup[i].transform.position = firstPosition[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void callOpeningFunc(int i)
    {
        popup[i].DOMoveX(firstPosition[i].x + 100,  2f );
    }
}
