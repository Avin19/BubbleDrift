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



    void Start()
    {
        SpawnNormalBubble();
        SpawnHeavyBubble();
    }

    public void GetNormalBubble(Vector3 spawnPoint)
    {
        bool check = false;
        foreach (Transform bubble in normalBubble)
        {
            if (!bubble.gameObject.activeSelf)
            {
                bubble.GetComponent<BubbleVisual>().SetTransfromOfBubble(spawnPoint);
                bubble.gameObject.SetActive(true);
                check = true;
                break;

            }
        }
        if (!check)
        {
            SpawnNormalBubble();
            GetNormalBubble(spawnPoint);
        }





    }

    private void SpawnNormalBubble()
    {
        for (int i = 0; i <= 5; i++)
        {
            Transform bubble = Instantiate(bubblePf, transform);
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

    public void ReturnToPool(Transform bubble)
    {

        bubble.gameObject.SetActive(false);
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
}
