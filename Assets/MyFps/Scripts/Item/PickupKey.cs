namespace Myfps
{
    public class PickupKey : PickupItem
    {
        public bool isKey = false;
        protected override bool OnPickup()
        {
            isKey = true;
            return true;
        }

    }
}