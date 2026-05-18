using UnityEngine;

public class PlayerControlller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private bool spawnBubble;

    [SerializeField] private LayerMask bubblelayer;
    [SerializeField] private BubblePoolManager bubblePoolManager;




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
                    collider.gameObject.GetComponent<BubbleVisual>().PopUP();
                    SFXManager.Instance.PlayPopUp();
                    bubblePoolManager.ReturnToPool(collider.transform);
                }
                else
                {
                    bubblePoolManager.GetNormalBubble(spawnPosition);

                    SFXManager.Instance.BubbleSpawnAudio();

                }

            }
        }

    }
}
