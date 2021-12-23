using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//-0.51 0.51
public class Player : Fighter
{

    Vector2 cntrl;
    // Update is called once per frame
    void Update()
    {
        cntrl=new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (cntrl.x != 0)
        {
            sr.flipX = cntrl.x < 0;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
              StartCoroutine(Punch());
        }
        isGuard = Input.GetKey(KeyCode.X);

        anim.SetBool("IsGuard", isGuard);

        if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Punch") 
            && !anim.GetCurrentAnimatorStateInfo(0).IsName("GetPunch") 
            && !anim.GetCurrentAnimatorStateInfo(0).IsName("Guard"))
        {
            anim.SetBool("IsWalking", cntrl.magnitude != 0);
            rb.velocity = new Vector2(cntrl.x * horizontalSpeed, cntrl.y * verticalSpeed);
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, LimitsY.y, LimitsY.x), transform.position.z);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }
}
