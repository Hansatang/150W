namespace Weapons
{
    public interface IWeapon
    {
        public void Upgrade(float area, float power, float speed);

        public void Stop();
    }
}