using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithInputs : MonoBehaviour {
    public Rigidbody2D m_rb2D;
    public float m_speed = 500f;

	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.UpArrow))
            m_rb2D.MovePosition(m_rb2D.position + Vector2.up * m_speed * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            m_rb2D.MovePosition(m_rb2D.position - Vector2.up * m_speed * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            m_rb2D.MovePosition(m_rb2D.position + Vector2.right * m_speed * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            m_rb2D.MovePosition(m_rb2D.position - Vector2.right * m_speed * Time.fixedDeltaTime);

    }
}
