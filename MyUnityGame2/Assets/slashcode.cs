using UnityEngine;
using UnityEngine.Rendering;

public class slashcode : MonoBehaviour
{
    public movement move;
    public SpriteRenderer srs;
    void Start()
    {
        srs = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (move.sr.flipX)
            srs.flipX = true;
        else    
            srs.flipX = false;
            
    }
}
