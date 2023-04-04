using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorHandler : MonoBehaviour
{
    private PlayerInput _playerInput;
    public Animator anim;
    public float hf = 0.0f;
    public float vf = 0.0f;
    private static readonly int Horizontal = Animator.StringToHash("Horizontal");
    private static readonly int Vertical = Animator.StringToHash("Vertical");
    private static readonly int Speed = Animator.StringToHash("Speed");

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        _playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        hf = _playerInput.Horizontal > 0.01f ? _playerInput.Horizontal : _playerInput.Horizontal < -0.01f ? 1 : 0;
        vf = _playerInput.Vertical > 0.01f ? _playerInput.Vertical : _playerInput.Vertical < -0.01f ? 1 : 0;
        if (_playerInput.Horizontal < -0.01f)
        {
            transform.localScale = new Vector3(-5, 5, 1);
        }
        else
        {
            transform.localScale = new Vector3(5, 5, 1);
        }

        anim.SetFloat(Horizontal, hf);
        anim.SetFloat(Vertical, _playerInput.Vertical);
        anim.SetFloat(Speed, vf);
    }
}