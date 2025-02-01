using TMPro;
using UnityEngine;
using VContainer;

public class ManaCounterUI : MonoBehaviour {

    private ResourceService _resourceService;

    [Inject]
    public void Construct(ResourceService resourceService) {
        _resourceService = resourceService;
        Debug.Log("ResourceService injected");
    }

    private void Update() {
        if (_resourceService != null) {
            Debug.LogError("ResourceService is not null");
            Debug.Log($"Mana: {_resourceService.Mana}");
        }
        else {
            Debug.LogError("ResourceService is null");
        }
    }
}