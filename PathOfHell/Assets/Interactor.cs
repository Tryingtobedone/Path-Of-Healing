using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    [SerializeField] private Transform _interactionPoint;
    [SerializeField] private float _interactionPointRad;
    [SerializeField] private LayerMask _interactionMask;

    private readonly Collider[] colliders = new Collider[3];
    [SerializeField] private int NumFound;

    private void Update()
    {
                
    }
}
