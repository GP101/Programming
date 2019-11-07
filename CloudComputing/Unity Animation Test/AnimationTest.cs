using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    double cubeTimer = 0.0;
    Animator anim;

    void Start()
    {
        //StartCoroutine( MoveCube() );
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 dir = gameObject.transform.forward;
        //cubeTimer += Time.deltaTime;
        //if( cubeTimer < 1.0f )
        //    gameObject.transform.position += dir * Time.deltaTime;

        if( Input.GetKeyDown( KeyCode.A ) )
        {
            //anim.Play( "CubeAnimation" );
            anim.SetTrigger( "Move" );
        }
    }

    IEnumerator MoveCube()
    {
        while( cubeTimer < 1.0f )
        {
            Vector3 dir = gameObject.transform.forward;
            cubeTimer += Time.deltaTime;
            gameObject.transform.position += dir * Time.deltaTime;
            yield return null;
        }
    }
}
