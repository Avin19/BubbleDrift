using System.Collections.Generic;
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
                Spawner(bubble, spawnPoint);

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
    public void GetHeavyBubble(Vector3 spawnPoint)
    {
        bool check = false;
        foreach (Transform bubble in heavyBubble)
        {
            if (!bubble.gameObject.activeSelf)
            {
                Spawner(bubble, spawnPoint);

                check = true;
                break;

            }
        }
        if (!check)
        {
            SpawnHeavyBubble();
            GetHeavyBubble(spawnPoint);

        }

    }
    private void Spawner(Transform _bubble, Vector3 target)
    {
        _bubble.GetComponent<BubbleMovement>().SetTransfromOfBubble(target);
        _bubble.gameObject.SetActive(true);
        SFXManager.Instance.PlaySfX(_bubble.GetComponent<BubbleReferenceSO>().GetBubbleTypeSO().spawnClip);
    }
    public void WeightSpawning(int weight, Vector3 spawnPoint)
    {
        if (weight < normalSO.weight)
        {
            GetNormalBubble(spawnPoint);
        }
        else if (weight - normalSO.weight < heavySO.weight)
        {
            GetHeavyBubble(spawnPoint);
        }
    }

    private void SpawnNormalBubble()
    {
        for (int i = 0; i <= 5; i++)
        {
            Transform bubble = Instantiate(bubblePf, transform);
            bubble.gameObject.name = "Normalbubble";
            bubble.GetComponent<BubbleMovement>().SetThePosition(targetpoint.position);
            bubble.GetComponent<BubbleReferenceSO>().SetBubbleTypeSO(normalSO);
            normalBubble.Add(bubble);
            bubble.gameObject.SetActive(false);
        }

    }

    private void SpawnHeavyBubble()
    {
        for (int i = 0; i <= 5; i++)
        {
            Transform bubble = Instantiate(bubblePf, transform);
            bubble.gameObject.name = "Heavybubble";
            bubble.GetComponent<BubbleMovement>().SetThePosition(targetpoint.position);
            bubble.GetComponent<BubbleReferenceSO>().SetBubbleTypeSO(heavySO);
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
