namespace SmartHomeProject.Model.Devices
{
    public abstract class  DeviceCore
    {
        public DeviceCore(string name, string location)
        {
            Name = name;
            Location = location;
        }
        public string Name { get; set; }
        public string Location { get; set; }
        public bool IsEnable { get; protected set; }
        public virtual void PowerStatusSwitcher()
        {
            IsEnable = !IsEnable;
        }
    }
}
