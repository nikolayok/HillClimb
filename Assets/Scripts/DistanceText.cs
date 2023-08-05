using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceText : MonoBehaviour
{
    [SerializeField] private Text _distanceText;
    [SerializeField] private Transform _playerTransform;

    private Vector2 _startPosition;

    void Start()
    {
        _startPosition = _playerTransform.position;
    }

    void Update()
    {
        Vector2 distance = (Vector2)_playerTransform.position - _startPosition;
        distance.y = 0f;

        if (distance.x < 0)
        {
            distance.x = 0;
        }

        _distanceText.text = distance.x.ToString("F0") + "m";
    }
}
