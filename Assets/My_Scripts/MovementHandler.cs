using UnityEngine;
using Zenject;

public class MovementHandler : MonoBehaviour
{
    [SerializeField] private float speedMovement;
    public IInputSystem inputSystem;

    [Inject]
    public void Construct(IInputSystem inputSystem)
    {
        this.inputSystem = inputSystem;
    }

    private void Start()
    {
        speedMovement = speedMovement == 0 ? 3 : speedMovement;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            inputSystem.HorizontalMovement(transform, speedMovement);

        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            inputSystem.VerticalMovement(transform, speedMovement);
    }
}
