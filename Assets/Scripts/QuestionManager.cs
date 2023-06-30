using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] List<GameObject> CanvasNPCs;
    [SerializeField] List<Button> ButtonList;

    private int ind;
    private int lastInd = -1;
    void Start()
    {
        ind = -1;
        foreach (Button b in ButtonList) {
            ind++;
            btnClicekd(ind, b);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void btnClicekd(int i, Button btn) {
        btn.onClick.AddListener(() => showChat(i));
    }

    void showChat(int i)
    {
        if (lastInd != -1)
        {
            CanvasNPCs[lastInd].SetActive(false);

        }
        CanvasNPCs[i * 5].SetActive(true);
        lastInd = i * 5;
    }
}
