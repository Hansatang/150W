using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;

    public Image fill;
    // Start is called before the first frame update
    public void SetHealth(int health)
    {
        slider.value = health;

        fill.color = gradient.Evaluate(slider.value / slider.maxValue);
    }
    
    public void SetMaxHealth(int MaxHealth)
    {
        slider.maxValue = MaxHealth;
        fill.color = gradient.Evaluate(1f);
    }
}