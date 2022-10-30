using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BulletDisplay : MonoBehaviour
{
   [SerializeField] public float bullets = 20;

   public TextMeshProUGUI _TextMeshProUGUI;

   private void Update()
   {
      _TextMeshProUGUI.text = bullets.ToString();
   }
}
