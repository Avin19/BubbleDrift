using UnityEngine;
[CreateAssetMenu(fileName = "Bubble", menuName = " Bubble Type SO")]
public class BubbleTypeSO : ScriptableObject
{
    public BubbleType bubbleType;
    public float Speed;
    public AudioClip popAudio;
    public AudioClip spawnClip;

}
