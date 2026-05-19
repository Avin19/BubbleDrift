using UnityEngine;
using DG.Tweening;

// Reads BubbleTypeSO:

// color
// glow
// scale
// material

// Applies visuals.
public class BubbleVisual : MonoBehaviour
{
    private Vector3 movePoint = new Vector3(0f, 0f, 0f);
    private Rigidbody2D rigidbody2D;
    private BubbleTypeSO bubbleTypeSO;
    public void SetThePosition(Vector3 _movePoint)
    {
        movePoint = _movePoint;
    }
    public void SetBubbleType(BubbleTypeSO _bubbleTypeSO)
    {
        bubbleTypeSO = _bubbleTypeSO;
    }
    public BubbleTypeSO GetBubbleType()
    {
        return bubbleTypeSO;
    }
    public void SetTransfromOfBubble(Vector3 spawnPoint)
    {
        transform.position = spawnPoint;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        DOTween.Init();
        transform.DOPunchScale(new Vector3(1.05f, 1.05f, 1.05f), 0.5f, 5, 1);
        float scale = Random.Range(0.5f, 1.5f);
        transform.localScale = new Vector3(scale, scale, scale);



    }


    // Update is called once per frame
    void Update()
    {
        if (transform.position != movePoint)
        { rigidbody2D.DOMove(movePoint, bubbleTypeSO.Speed, false); }
        else
        {

        }
    }

    public void PopUP()
    {
        /*
        wobble
       scale pulse
       glow increase
       */
        transform.DOPunchScale(new Vector3(.85f, .85f, .85f), 0.5f, 5, 1);

        //Reset the Scale
        transform.DOPunchScale(new Vector3(1f, .1f, .1f), 0.2f, 5, 1);

    }
}
