using UnityEngine;
using Zenject;

public class MovementHandler : MonoBehaviour
{
    private RotateHandler RotateHandler;
    [SerializeField] private float speedMovement;
    [SerializeField] private GameObject PlayerIcon;
    private IInputSystem inputSystem;

    [Inject]
    public void Construct(IInputSystem inputSystem, RotateHandler rotateHandler)
    {
        this.inputSystem = inputSystem;
        RotateHandler = rotateHandler;
    }

    private void Start()
    {
        speedMovement = speedMovement == 0 ? 3 : speedMovement;
        PlayerIcon = transform.GetChild(0).gameObject;
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        inputSystem.Update(transform, speedMovement, horizontalInput, verticalInput);
        if (horizontalInput > 0)
            RotateHandler.RotateRight(PlayerIcon.transform);
        else if (horizontalInput < 0)
            RotateHandler.RotateLeft(PlayerIcon.transform);
        else if (verticalInput > 0)
            RotateHandler.RotateUp(PlayerIcon.transform);
        else if (verticalInput < 0)
            RotateHandler.RotateDown(PlayerIcon.transform);
    }
}
