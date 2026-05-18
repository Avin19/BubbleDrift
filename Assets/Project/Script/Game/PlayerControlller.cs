using UnityEngine;

public class PlayerControlller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private bool spawnBubble;
    [SerializeField] private Transform bubblePf;
    [SerializeField] private Transform bubbleParent;
    [SerializeField] private LayerMask bubblelayer;
    [SerializeField] private Transform targetTransform;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (spawnBubble)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector2 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                if (Physics2D.OverlapPoint(spawnPosition, bubblelayer))
                {
                    Collider2D collider = Physics2D.OverlapPoint(spawnPosition, bubblelayer);
                    Destroy(collider.gameObject);
                }
                else
                {

                    BubbleVisual bubble = Instantiate(bubblePf, spawnPosition, Quaternion.identity, bubbleParent).GetComponent<BubbleVisual>();
                    bubble.SetThePosition(targetTransform.position);
                }

            }
        }

    }
}
