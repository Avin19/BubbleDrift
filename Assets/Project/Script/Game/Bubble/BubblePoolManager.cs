using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class BubblePoolManager : MonoBehaviour
{
    [Header("Bubbles")]
    [SerializeField]
    private BubbleTypeSO normalSO, heavySO;
    [SerializeField] private Transform bubblePf;
    [SerializeField] private Transform targetpoint;
    private List<Transform> normalBubble = new List<Transform>();
    private List<Transform> heavyBubble = new List<Transform>();
    private int currentNormalBubble = 0;
    private int currentHeavyBubble = 0;


    void Start()
    {
        SpawnNormalBubble();
        SpawnHeavyBubble();
    }

    public void GetNormalBubble(Vector3 spawnPoint)
    {
        normalBubble[currentNormalBubble].GetComponent<BubbleVisual>().SetTransfromOfBubble(spawnPoint);
        normalBubble[currentNormalBubble].gameObject.SetActive(true);
        currentNormalBubble++;
        if (currentNormalBubble >= normalBubble.Count)
        {
            SpawnNormalBubble();
        }
    }

    private void SpawnNormalBubble()
    {
        for (int i = 0; i <= 5; i++)
        {
            Transform bubble = Instantiate(bubblePf, transform).GetComponent<Transform>();
            bubble.GetComponent<BubbleVisual>().SetThePosition(targetpoint.position);
            bubble.GetComponent<BubbleVisual>().SetBubbleType(normalSO);
            normalBubble.Add(bubble);
            bubble.gameObject.SetActive(false);
        }

    }

    private void SpawnHeavyBubble()
    {
        for (int i = 0; i <= 5; i++)
        {
            Transform bubble = Instantiate(bubblePf, transform).GetComponent<Transform>();
            bubble.GetComponent<BubbleVisual>().SetThePosition(targetpoint.position);
            bubble.GetComponent<BubbleVisual>().SetBubbleType(heavySO);
            heavyBubble.Add(bubble);
            bubble.gameObject.SetActive(false);
        }
    }

    public void ReturnToPool()
    {

    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
}
