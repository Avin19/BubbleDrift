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

    public void SetThePosition(Vector3 _movePoint)
    {
        movePoint = _movePoint;
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        float scale = Random.Range(0.5f, 1.5f);
        transform.localScale = new Vector3(scale, scale, scale);
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
