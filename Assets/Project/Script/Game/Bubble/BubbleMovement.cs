// Reads BubbleTypeSO:

// drift speed
// wobble amount
// rotation speed
using UnityEngine;
using DG.Tweening;


public class BubbleMovement : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private Vector3 movePoint;
    private BubbleTypeSO bubbleTypeSO;
    public float shakeDuration = 0.5f;
    public Vector3 shakeStrength = new Vector3(0.1f, 0.1f, 0);
    public int vibrato = 10;
    public void SetThePosition(Vector3 _movePoint)
    {
        movePoint = _movePoint;
    }
    public void SetTransfromOfBubble(Vector3 spawnPoint)
    {
        transform.position = spawnPoint;
    }
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        bubbleTypeSO = GetComponent<BubbleReferenceSO>().GetBubbleTypeSO();

    }
    void Update()
    {
        if (transform.position != movePoint)
        {
            rigidbody2D.DOMove(movePoint, bubbleTypeSO.Speed, false);

        }
        else
        {

        }
    }
}