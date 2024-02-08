using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ObjectsInteractionTask1 : MonoBehaviour
{
    // DONE: Получите доступ к объекту со скриптом Refrigerator при помощи атрибута [SerializeField]
    // DONE: При нажатии на кнопку 1 на клавиатуре вызывайте у него метод Interact

    [SerializeField] private Refrigerator _refrigerator;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _refrigerator.Interact();
        }
    }
}
