using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName ="Newnpcdialoge", menuName = "npc dialoge")]
public class Interaction : MonoBehaviour
{
    [SerializeField] private string npcNavn;
    [SerializeField] private string[] dialogeLines;
    [SerializeField] private float typingSpeed = 0.4f;
    [SerializeField] private bool[] autodialogelines;
    [SerializeField] private float autodialogelinesdelay = 0.4f;
}
