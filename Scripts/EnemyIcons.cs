using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using Object = UnityEngine.Object;

public class EnemyIcons : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private EnemySpawn _enemyCounter;
    private Stack<Image> _images = new Stack<Image>();

    private void Start()
    {
        var counter = _enemyCounter.enemyCounter;
        for (int i = 0; i < counter; i++)
        {
            var image = Instantiate(_image, transform);
            _images.Push(image);
        }
    }
    public void DestroyImage()
    {
        Destroy(_images.Pop());
    }
    
}
