using UnityEngine;

[CreateAssetMenu(fileName ="Newnpcdialoge", menuName = "npc dialoge")]
public class Interaction : ScriptableObject
{
    public string npcNavn;
    public string[] dialogeLines;
    public float typingSpeed = 0.4f;
    public bool[] autodialogelines;
    public float autodialogelinesdelay = 0.4f;
}
