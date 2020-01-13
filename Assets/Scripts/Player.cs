using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController cc;
    public float speed = 10.0f;
    private Vector3 moveDirection;
    public Animator am;
    void Start()
    {
        Vector3 moveDirection = Vector3.zero;
    }
    private void Awake()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if(moveDirection.magnitude>0)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(moveDirection), 0.1f);
        moveDirection.y = -9.8f;
        cc.Move(moveDirection * speed * Time.deltaTime);
        am.SetFloat("speed",cc.velocity.magnitude);
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            am.SetBool("canRun", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            am.SetBool("canRun", false);
        }
    }
}
