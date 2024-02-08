using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены

    private Shelf[] _shelves;

    private void Awake()
    {
        _shelves = FindObjectsOfType<Shelf>();
        foreach (var shelf in _shelves)
        {
            shelf.ItemSpawned += FallShelves;
            Debug.Log($"Подписался на евент у {shelf.name}"   );
        }
    }

    private void FallShelves()
    {
        Debug.Log("Вызвал евент падение полки");
        foreach (var shelf in _shelves)
        {
            Debug.Log($"проверяю количество предметов у {shelf.name} - {shelf.ItemsCount}");
            if (shelf.ItemsCount > 3)
            {
                shelf.Fall();
            }
        }
    }
}