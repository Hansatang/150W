using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleMovement : MonoBehaviour
{
    private GameObject _player;
    private float speed = 2.0f;
    public Animator anim;
    public float hf = 0.0f;
    public float vf = 0.0f;
    private static readonly int Horizontal = Animator.StringToHash("Horizontal");
    private static readonly int Vertical = Animator.StringToHash("Vertical");

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        Vector3 position1 = _player.transform.position;

        hf = Mathf.InverseLerp(-10, 10, position.x - position1.x);
        hf = (hf - 0.5f) * -2.0f;

        vf = Mathf.InverseLerp(-10, 10, position.y - position1.y);
        vf = (vf - 0.5f) * -2.0f;

        anim.SetFloat(Horizontal, hf);
        anim.SetFloat(Vertical, vf);

        transform.position = Vector2.MoveTowards(position, position1, speed * Time.deltaTime);
    }
}