using UnityEngine;
using System.Collections;
using Skaillz.EditInline;

public class SampleBehaviour : MonoBehaviour
{
    public int currentHealth;
    [EditInline] public Character character;

    private void Start()
    {
        currentHealth = character.maxHealth;
    }
}
