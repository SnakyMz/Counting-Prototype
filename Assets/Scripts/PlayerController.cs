using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float range = 9;
    private Animator playerAnim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = new Quaternion(0, 180, 0, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            playerAnim.SetFloat("Speed_f", 1);
        } else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            playerAnim.SetFloat("Speed_f", 1);
        } else
        {
            playerAnim.SetFloat("Speed_f", 0);
        }

        if (transform.position.z > range)
        {
            transform.position = new Vector3(0, 0, range);
        } else if (transform.position.z < -range)
        {
            transform.position = new Vector3(0, 0, -range);
        }
    }
}
