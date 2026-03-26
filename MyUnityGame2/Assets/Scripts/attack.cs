using UnityEngine;

public class attack : MonoBehaviour
{
    public Transform player;
    public float atktime = 0.15f;
    public float cooldown = 1.5f;
    public movement move;
    public SpriteRenderer srs;
    public bool isatack;
    Vector3 offset = new Vector3(1.25f, 0f, 0f);
    public float isatacktimer;

    public GameObject dmgsquare;

    public movement mo;

    

    void Start()
    {
    }
    void Update()
    {
        if (mo.haveSword){
        if (Input.GetMouseButtonDown(0) && cooldown <= 0f)
        {
            isatack = true;
            atktime = 0.15f;
            cooldown = 1.5f;
            isatacktimer = 0.5f;
            if (move.sr.flipX)
            {
                transform.localScale = new Vector3(-3, 4, 1);
                offset = new Vector3(-1.5f, 0f, 0f); 
                srs.flipX = true;
            }
            else
            {
                offset = new Vector3(1.25f, 0f, 0f);
                transform.localScale = new Vector3(3, 4, 1);
                srs.flipX = false;
            }
        }  
        transform.position = player.position + offset;
    }}
    void FixedUpdate()
    {
        if (mo.haveSword){
        if (atktime <= 0f)
            transform.localScale = new Vector3(0, 4, 1);

        atktime -= Time.fixedDeltaTime;
        cooldown -= Time.fixedDeltaTime;
        isatacktimer -= Time.fixedDeltaTime;
        if (isatacktimer <= 0f)
        {
            isatack = false;
        }
    }}}

