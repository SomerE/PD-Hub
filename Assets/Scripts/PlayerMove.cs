using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 0.5f;
    public bool useRunSpeed = false;
    private Rigidbody rigid;
    public float jumpAmount = 10;
    public float sprintDistance = 0.5f;
    //private float distToGround;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //distToGround = collider.bounds.extents.y; //set to distance to ground
    }

    void FixedUpdate()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
            useRunSpeed = !useRunSpeed;

        Move(moveDirection);

        if (Input.GetKeyDown(KeyCode.Space)/* && IsGrounded()*/)
            Jump();

        if (Input.GetKeyDown(KeyCode.L))
            ShortSprint(moveDirection);
    }

    //private bool IsGrounded()
    //{
    //    return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
    //}

    private void Move(Vector3 moveDirection)
    {
        //transform.position += moveDirection; //this allows cubes to move
        speed = useRunSpeed ? 10f : 1f;

        rigid.AddForce(moveDirection * speed);
    }

    private void Jump()
    {
        print("jump");
        rigid.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
    }

    private void ShortSprint(Vector3 moveDirection)
    {
        float x = Mathf.Log(1f / (Time.deltaTime * rigid.drag + 1)) / -Time.deltaTime;
        Vector3 dashVelocity = Vector3.Scale(moveDirection, sprintDistance * new Vector3(x, 0, x));
        rigid.AddForce(dashVelocity, ForceMode.VelocityChange);
    }

}
