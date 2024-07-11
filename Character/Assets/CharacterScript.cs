using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class CharacterScript : MonoBehaviour
{
    private readonly float speed = 15f;
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0,
            Input.GetAxis("Vertical") * speed * Time.deltaTime);
    }
}
