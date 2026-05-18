using UnityEngine;
using DG.Tweening;

public class BubbleVisual : MonoBehaviour
{
    private Vector3 movePoint = new Vector3(0f, 0f, 0f);
    private Rigidbody2D rigidbody2D;
    public void SetThePosition(Vector3 _movePoint)
    {
        movePoint = _movePoint;
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
        { rigidbody2D.DOMove(movePoint, 3f, false); }
        else
        {

        }
    }
}
