using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
   // ü�¹� �����

    public float initHealth;
    private float health = 100f;

    [SerializeField] Slider healthSlider;
    [SerializeField] Image fillImage;

    [SerializeField] int[] stateGealth;
  
    private void Awake()
    {
       healthSlider = GetComponentInChildren<Slider>();// �ڽ����¼� �����ͼ� ����ϱ� 
       
    }

    void Start()
    {   
        initHealth = health;

        healthSlider.value = health / initHealth;

        OnState();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            OnState();
            OnDamage(10);

        }
    }

    public void OnDamage(float damage)
    {
        health -= damage;

        healthSlider.value = health / initHealth;
    }

    public void OnState()
    {
        if(healthSlider.value >= 0.5f)
        {
            fillImage.color = new Color(0, 1, 0);
        }
        else if(healthSlider.value >=0.2f)
        {
            fillImage.color = new Color(1, 1, 0);
        }
        else if(healthSlider.value >= 0.1f)
        {
            fillImage.color = new Color(1, 0, 0);
        }
    }

}
