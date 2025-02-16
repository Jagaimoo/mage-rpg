using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 5;
    [SerializeField] private GameObject player;
    private SpriteRenderer spr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake() {
        spr = player.GetComponent<SpriteRenderer>();    
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float y = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        player.transform.position += new Vector3(x, y, 0);
        if (x > 0)
        {
            spr.flipX = false;
        } else if (x < 0)
        {
            spr.flipX = true;
        }

    }

    

}
