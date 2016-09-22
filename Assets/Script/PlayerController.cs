using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


    public int moveSpeed;

    Animator animate;



    double cooldown;
    Movement PlayerMove;

	// Use this for initialization
	void Start () {
        PlayerMove = new Movement(this.gameObject);
        animate = GetComponentInChildren<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKey(KeyCode.RightArrow) && !animate.GetBool("isAttack"))
        {
            animate.SetBool("isWalk", true);
        
            //transform.Translate(10, 0, 0);
           PlayerMove.moveForward(moveSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && !animate.GetBool("isAttack"))
        {
            animate.SetBool("isWalk", true);
            //transform.Translate(10, 0, 0);
            PlayerMove.moveBack(moveSpeed);
        }
        if (Input.GetKeyDown(KeyCode.Space) && !animate.GetBool("isAttack"))
        {
            animate.SetBool("isAttack", true);
            cooldown = 1.56;
        }


        if(animate.GetBool("isAttack"))
        {

            cooldown -= Time.deltaTime;
            if (cooldown <= 0)
                animate.SetBool("isAttack", false);

        }

       
        if (Input.GetKeyUp(KeyCode.RightArrow))
        { animate.SetBool("isWalk", false); }
        if(Input.GetKeyUp(KeyCode.LeftArrow))
        { animate.SetBool("isWalk", false); }


    }


    void OnCollisionEnter2D(Collision2D coi)
    {
        if (coi.gameObject.name == "Monster_01_Camelion")
        {
            Debug.Log("Hit");
            Stat.hp -= 1;
        }
    }


}
