using UnityEngine;

public class PlayerAnimatorHandler : MonoBehaviour
{
    private PlayerInput _playerInput;
    public Animator anim;
    public float hf = 0.0f;
    public float vf = 0.0f;
    private static readonly int Horizontal = Animator.StringToHash("Horizontal");
    private static readonly int Vertical = Animator.StringToHash("Vertical");
    private static readonly int HorizontalX = Animator.StringToHash("LastMoveX");
    private static readonly int VerticalY = Animator.StringToHash("LastMoveY");

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        _playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        hf = _playerInput.Horizontal;
        vf = _playerInput.Vertical;


        if (hf is >= 0.2f or <= -0.2f || vf is >= 0.2f or <= -0.2f)
        {
            anim.SetFloat(HorizontalX, hf);
            anim.SetFloat(VerticalY, vf);
        }

        anim.SetFloat(Horizontal, hf);
        anim.SetFloat(Vertical, vf);
    }
}