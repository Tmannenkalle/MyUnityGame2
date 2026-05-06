using UnityEngine;

public class thief_chase : MonoBehaviour
{
    public movement move;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (move.blocks == 1)
            transform.localPosition = new Vector3(304.0044f, -17.88036f, 0f);
        else
            transform.localPosition = new Vector3(304.0044f, -1700.88036f, 0f);

    }
}
