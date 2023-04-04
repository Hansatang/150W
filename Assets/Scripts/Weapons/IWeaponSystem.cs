using UnityEngine;

namespace Weapons
{
    public interface IWeaponSystem
    {
        public void Upgrade(float area, float power, float speed);

        public void Arm();
        void Stop();
    }
}