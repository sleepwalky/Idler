using UnityEngine;

public class ResourceService {
    public int Mana { get; private set; }

    public void AddMana(int amount) {
        Debug.Log("Button clicked");
        Mana += amount;
    }
}
