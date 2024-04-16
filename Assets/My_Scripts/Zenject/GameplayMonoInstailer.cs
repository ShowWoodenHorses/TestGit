
using Zenject;

public class GameplayMonoInstailer : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IInputSystem>().To<DesktopMovement>().AsSingle();
        Container.Bind<MovementHandler>().AsSingle();
        Container.Bind<RotateHandler>().AsSingle();
    }
}
