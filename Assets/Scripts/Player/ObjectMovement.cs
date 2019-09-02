using System.Collections;
using UnityEngine;

//set directions
public enum DIRECTION { UP, DOWN, LEFT, RIGHT }

public class ObjectMovement : MonoBehaviour
{
	private bool canMove = true, moving = false;
	private int speed = 5, buttonCooldown = 0; //button cooldown for not moving too many directions at once
	private DIRECTION dir = DIRECTION.DOWN; //facing direction									
	private Vector3 pos; //keep track of object position
	private Rigidbody2D body;

    void Start()
	{
        body = GetComponent<Rigidbody2D>();
	}
	public void Update()
	{
		buttonCooldown--;
		if (canMove)
		{
			pos = transform.position;
			move();
		}

        if (moving)
		{
            //if current position is equivalent to the position you are trying to reach
            if (transform.position == pos)
			{
				moving = false;
				canMove = true;
				move();
			}
            //movement speed 
			body.transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
		}
	}

	public void move()
	{
		if (buttonCooldown <= 0)
		{
			if (Input.GetKey(KeyCode.UpArrow))
			{
				if (dir != DIRECTION.UP)
				{
					buttonCooldown = 2;
					dir = DIRECTION.UP;
				}
				else
				{
					canMove = false;
					moving = true;
					pos += Vector3.up;
				}
			}
            else if (Input.GetKey(KeyCode.DownArrow))
			{
				if (dir != DIRECTION.DOWN)
				{
					buttonCooldown = 2;
					dir = DIRECTION.DOWN;
				}
				else
				{
					canMove = false;
					moving = true;
					pos += Vector3.down;
				}
			}
			else if (Input.GetKey(KeyCode.LeftArrow))
			{
				if (dir != DIRECTION.LEFT)
				{
					buttonCooldown = 2;
					dir = DIRECTION.LEFT;
				}
				else
				{
					canMove = false;
					moving = true;
					pos += Vector3.left;
				}
			}
			else if (Input.GetKey(KeyCode.RightArrow))
			{
				if (dir != DIRECTION.RIGHT)
				{
					buttonCooldown = 2;
					dir = DIRECTION.RIGHT;
				}
				else
				{
					canMove = false;
					moving = true;
					pos += Vector3.right;
				}
			}
		}
	}
}
