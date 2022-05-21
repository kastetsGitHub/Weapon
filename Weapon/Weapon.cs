using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected Bullet Bullet;
    [SerializeField] private string _label;
    [SerializeField] private float _price;
    [SerializeField] private Sprite _icon;
    [SerializeField] private bool _isBought;

    public string Lable => _label;
    public float Price => _price;
    public Sprite Icon => _icon;
    public bool IsBought => _isBought;

    public abstract void Fire(Transform firePoint);

    public void Buy() => _isBought = true;
}
