using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // Velocita movimento
    public float speed = 5;

    // gameobject di player
    [SerializeField] private GameObject player;

    // SpriteRendere di player 
    private SpriteRenderer spr;

    // Animazione player
    private Animator anim;
    private string WALK_ANIMATION = "Walk";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        spr = player.GetComponent<SpriteRenderer>();
        anim = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movement
        float x = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float y = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        player.transform.position += new Vector3(x, y, 0);

        // Walk animation
        Animation_Walk_Player(x, y);

    }

    void Animation_Walk_Player(float x, float y)
    {
        if (x > 0)
        {
            spr.flipX = false;
            anim.SetBool(WALK_ANIMATION, true);
        }
        else if (x < 0)
        {
            spr.flipX = true;
            anim.SetBool(WALK_ANIMATION, true);
        }
        else if (y != 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
        }
        else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }
    }


}
