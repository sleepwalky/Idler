using UnityEngine;
using VContainer;
using VContainer.Unity;

public class GameLifetimeScope : LifetimeScope {
    [SerializeField]
    ManaCounterUI manaCounterUI;

    protected override void Configure(IContainerBuilder builder) {
        builder.Register<ResourceService>(Lifetime.Singleton);
        builder.RegisterComponent(manaCounterUI);
    }
}
