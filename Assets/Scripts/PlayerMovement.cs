using DG.Tweening;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float limitValue = 1.5f;
    
    private float _halfScreen;
    private void Start() => _halfScreen = Screen.width * 0.5f;

    void Update()
    {
        if (!Input.GetMouseButton(0)) return;
        
        MovePlayer();
    }

    private void MovePlayer()
    {
        var inputXPosition = ((Input.mousePosition.x - _halfScreen) / _halfScreen) *  limitValue;

        playerTransform.DOLocalMoveX(Mathf.Clamp(inputXPosition, -limitValue, limitValue), 0);
    }
}
