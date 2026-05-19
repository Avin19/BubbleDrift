using UnityEngine;


public class BubbleReferenceSO : MonoBehaviour
{
    private BubbleTypeSO bubbleTypeSO;

    public void SetBubbleTypeSO(BubbleTypeSO _bubbleSO)
    {
        bubbleTypeSO = _bubbleSO;
    }
    public BubbleTypeSO GetBubbleTypeSO()
    {
        return bubbleTypeSO;
    }
}